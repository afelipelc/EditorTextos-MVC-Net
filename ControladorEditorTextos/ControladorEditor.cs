using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//agregamos la referencia del proyecto ModeloDominio para hacer uso de la clase Archivo
using ModeloDominio;

namespace ControladorEditorTextos
{
    public class ControladorEditor
    {
        //clase Controlador
        /*********************
         * ControladorEditor
         * -------------------
         * - Archivo
         * + ArchivoCargado
         * + ArchivoNuevo
         * + CambiosAGuardar
         * -------------------
         * ControladorEditor()
         * + Abrir(): void
         * + GuardarComo(): void
         * + Guardar(): void
         * + Nuevo(): void       
         */

        /*
         * Ejemplo de editor de textos basico desarrollado en la materia de Desarrollo de Aplicaciones II
         * Desarrollado por Alfonso Felipe Lima Cortes -- afelipelc@gmail.com
         * 
         * Si este codigo es usado como ejemplo, no olvides citar quien lo creo.
         * Gracias!
         */

        Archivo archivo;
        bool archivocargado;
        bool archivonuevo;
        //Instanciamos la interfaz con la que estara interactuando el controlador
        IVistaEditor _vista;

        //campos auxiliares para almacenar los streams: Writer y Reader
        StreamReader sr;
        StreamWriter sw;

        //constructor de la clase ControladorEditor que recibira una inatancia de la clase Vista
        //con la que debera interactuar el controlador
        public ControladorEditor(IVistaEditor vista)
        {
            this._vista = vista;
            //creamos la relacion pasandole la clase ControladorEditor como parametro
            vista.AplicarControlador(this);
        }

        //declarar los eventos principales a ocurrir

        //metodo que abrira un archivo, recibira como parametro la ruta del archivo
        //y creara la instancia de Archivo
        public void Abrir(string RutaArchivo)
        {            
            try
            {                
                archivo = new Archivo(RutaArchivo);

                //crear la instancia del stream (archivo) a leer
                sr = new StreamReader(archivo.RutaArchivo);
                archivo.Contenido = sr.ReadToEnd();
                _vista.Contenido = archivo.Contenido;
                this.archivocargado = true;
                this.archivonuevo = false;
                sr.Close();
            }
            catch (Exception e)
            {
                    _vista.Contenido = "";
                    _vista.Info = "No se pudo abrir el archivo";
            }
            
        }

        //creamos dos metodos para guardar el archivo

        //el metodo guardararchivo sera invocado cuando el archivo se guarde por primera vez
        public void GuardarArchivo(string RutaArchivo)
        {           
                archivo = new Archivo(RutaArchivo);
                Guardar();
                CambiosAGuardar = false;
                this.archivonuevo = false; //una vez guardado por primera vez, ya no sera nuevo
        }

        //el metodo guardar, realizara la accion de guardar el contenido del archivo
        public void Guardar()
        {
            try
            {
                //crear la instancia del stream (archivo) a leer
                sw = new StreamWriter(archivo.RutaArchivo);
                archivo.Contenido = _vista.Contenido;
                sw.Write(_vista.Contenido);                
                sw.Close();
                CambiosAGuardar = false;
            }
            catch (Exception e)
            {
                _vista.Info = "No se pudo guardar el archivo";
            }
        }

        //metodo que creara un nuevo archivo
        public void Nuevo()
        {
            archivo = new Archivo("");           
            _vista.Contenido = "";
            this.archivocargado = true;
            this.archivonuevo = true;
        }

        //propiedad para indicar si hay un archivo cargado
        public bool ArchivoCargado
        {
            get { return this.archivocargado; }
            set { this.archivocargado = value; }
        }

        //propiedad que verifica si un archivo tiene cambios realizados
        public bool CambiosAGuardar
        {
            get { return archivo.CambiosRealizados; }
            set { archivo.CambiosRealizados = value; }
        }

		//propiedad que verifica si el archivo es nuevo
        public bool ArchivoNuevo
        {
            get { return this.archivonuevo; }
        }
    }
}
