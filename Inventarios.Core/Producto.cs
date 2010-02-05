using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Inventarios.Core
{
    public partial class Producto
    {
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (Codigo == 0)
                yield return new RuleViolation("Codigo es requerido", "Codigo");

            if (String.IsNullOrEmpty(Nombre))
                yield return new RuleViolation("Nombre es requerido", "Nombre");

            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Se registraron los siguientes errores al grabar");
        }
    }
}