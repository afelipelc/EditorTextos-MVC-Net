using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ModeloDominio
{
    public class Archivo
    {
        //Clase Archivo
        /*******************
         * Archivo
         * -----------------
         * + Contenido
         * + RutaArchivo
         * + CambiosRealizados
         * -----------------
         * Archivo()
         * -----------------
         */
        //la clase Archivo, sera el modelo, ya que es la clase principal con la cual trabajara este programa

        //campos que utilizara la clase
        string rutaarchivo;
        //bool abiertolectura;      
        bool cambiosrealizados;
        string contenido;

        //campos auxiliares para almacenar los streams: Writer y Reader
        StreamReader sr;
        StreamWriter sw;

        //crear el contructor que pida la ruta del archivo
        public Archivo(string RutaDelArchivo)
        {
            this.rutaarchivo = RutaDelArchivo;
        }

         //propiedades
        public string Contenido //contenido del archivo
        {
            get { return this.contenido; }
            set { this.contenido = value; }
        }
        //propiedad que almacena y devuelve un valor bool si se le han hecho cambios al contenido del archivo
        public bool CambiosRealizados
        {
            get { return this.cambiosrealizados; }
            set { this.cambiosrealizados = value; }
        }

        public string RutaArchivo //proporcionar la ruta del archivo
        {
            get { return this.rutaarchivo; }
        }
    }
}
