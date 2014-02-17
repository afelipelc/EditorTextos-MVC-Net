using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//agregar la referencia para usar la clase Archivo
using ModeloDominio;
namespace ControladorEditorTextos
{
    public interface IVistaEditor
    {
        //interfaz que debe implementar la vista
        //es la estructura basica sobre las operaciones que debe realizar y las propiedades
        //que contiene la interfaz grafica

        /*
  * Ejemplo de editor de textos basico desarrollado en la materia de Desarrollo de Aplicaciones II
  * Desarrollado por Alfonso Felipe Lima Cortes -- afelipelc@gmail.com
  * 
  * Si este codigo es usado como ejemplo, no olvides citar quien lo creo.
  * Gracias!
  */

        void AplicarControlador(ControladorEditor cotrolador);       
        void Limpiar();
        string Contenido { get; set; } //para acceder al contenido del TextBox (contenido del archivo)
        string Info { get; set; }
    }
}
