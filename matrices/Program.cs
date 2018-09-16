using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Lina Maria Montaño Ramirez - @calypso_bronte
        /// Wilmar Berrio
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
