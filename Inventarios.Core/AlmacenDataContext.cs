using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Inventarios.Core
{
    public partial class AlmacenORMDataContext
    {
        public override void SubmitChanges(ConflictMode failureMode)
        {
            // Adding validation support when saving.
            EntityValidator.Validate(this.GetChangedEntities());

            base.SubmitChanges(failureMode);
        }

        // Gets the list of modified objects that are tracked
        // by the current data context.
        private IEnumerable<object> GetChangedEntities()
        {
            ChangeSet changes = this.GetChangeSet();

            return changes.Inserts.Concat(changes.Updates);
        }

    }
}