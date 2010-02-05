using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Inventarios.Core
{
    public partial class Cliente
    {
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0); }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if(NoControl == 0)
                yield return new RuleViolation("No. de control es requerido", "NoControl");

            if (String.IsNullOrEmpty(Nombre))
                yield return new RuleViolation("Nombre es requerido", "Nombre");

            if (String.IsNullOrEmpty(RFC))
                yield return new RuleViolation("RFC es requerido", "RFC");

            if (String.IsNullOrEmpty(Direccion))
                yield return new RuleViolation("Direccion es requerida", "Direccion");

            if (String.IsNullOrEmpty(Telefono))
                yield return new RuleViolation("Telefono es requerido", "Telefono");

            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Se registraron los siguientes errores al grabar");
        }
    }
}