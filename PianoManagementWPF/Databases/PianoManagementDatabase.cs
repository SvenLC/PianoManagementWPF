using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoManagementWPF.Databases
{
    class PianoManagementDatabase
    {

        #region Singleton var

        private static Lazy<PianoManagementEntities> Instance = new Lazy<PianoManagementEntities>(() => new PianoManagementEntities());

        public static PianoManagementEntities Current => Instance.Value;

        #endregion

        #region Static Funcs

        public static void ReinitializeDatabase()
        {
            if (Instance.IsValueCreated)
            {
                Instance = new Lazy<PianoManagementEntities>(() => new PianoManagementEntities());
            }
        }

        #endregion
    }
}
