using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using ControladorEditorTextos;

namespace EditorDeTextos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new VistaEditor());

            //Crear un objeto de la clase Vista Editor (Formulario)
            VistaEditor Vista = new VistaEditor();            

            //Crear un objeto de la clase Controlador
            //y asociarlo con el objeto Vista, al cual tendra que pasar los datos
            //De esta forma se crea la asociacion directa.
            ControladorEditor controlador = new ControladorEditor(Vista);
            //Invocar al metodo Nuevo() del controlador para que el programa
            //inicie creando un nuevo archivo.
            controlador.Nuevo();//crear un archivo nuevo por default

            //Mostrar el formulario
            Vista.ShowDialog();
        }
    }
}
