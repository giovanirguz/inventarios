using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.EnterpriseLibrary.Validation;

namespace Inventarios.Core
{
    static class EntityValidator
    {
        public static void Validate(IEnumerable<object> entities)
        {
            // Get a list of ValidationResults, one for each
            // invalid object.
            ValidationResults[] invalidResults = (
                from entity in entities
                let type = entity.GetType()
                let validator = ValidationFactory.CreateValidator(type)
                let results = validator.Validate(entity)
                where !results.IsValid
                select results).ToArray();

            // Throw an exception when there are invalid results.
            if (invalidResults.Length > 0)
            {
                throw new ValidationException(invalidResults);
            }
        }

    }

    [Serializable]
    public sealed class ValidationException : Exception
    {
        public ValidationException(ValidationResults[] results)
            : base("There are validation errors. etc. etc.")
        {
            this.Results = results.ToArray();
        }

        public IEnumerable<ValidationResults> Results
        {
            get;
            private set;
        }
    }
}