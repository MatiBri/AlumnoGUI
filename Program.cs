using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; //Librerías

namespace AlumnoGUI {
    static class Program { //Static hace referencia a una clase privada, dentro de todo el proyecto.
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAlumno()); //Ejecuta la ventana del formulario FORM1, que posteriormente cambio su referencia de formulario a frmAlumno
        }
    }

}
