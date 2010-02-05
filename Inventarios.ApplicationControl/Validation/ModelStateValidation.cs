using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventarios.Core;

namespace Inventarios.ApplicationControl.Validation
{
    public static class ModelStateValidation
    {
        public static string ValidationResults(IEnumerable<RuleViolation> ruleViolations)
        {
            var errorString = String.Empty;

            errorString += "Se registraron los siguientes errores al grabar".ToUpper() + "\n\n";
            foreach (var error in ruleViolations)
            {
                errorString += error.ErrorMessage + "\n";
            }

            return errorString;

        }
    }
}