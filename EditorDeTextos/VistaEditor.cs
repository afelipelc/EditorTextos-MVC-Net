using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//agregar la referencia al proyecto controlador
using ControladorEditorTextos;

namespace EditorDeTextos
{
    public partial class VistaEditor : Form, IVistaEditor
    {
        //La clase VistaEditor, es la Vista del programa
        //solo realiza las operaciones que tienen que ver con la vista
        //e interaccion con el usuario

        //implementa los eventos de los controles (operaciones disponibles para el usuario)
        //Abrir, Nuevo, Guardar, Cerrar

        //Representacion de la clase
        /**********************
         * Clase VistaEditor
         * --------------------
         * + Contenido
         * + Info
         * --------------------
         * + AplicarControlador(): void
         * + Limpiar(): void
         * - Abrir(): void
         * - Guardar(): void
         * - Nuevo(): void
         * - Cerrar(): void
         * - DialogoGuardarCambios(): void
         * - DialogoGuardarComo(): void
         * - DialogoAbrir(): void
         */

        /*
  * Ejemplo de editor de textos basico desarrollado en la materia de Desarrollo de Aplicaciones II
  * Desarrollado por Alfonso Felipe Lima Cortes -- afelipelc@gmail.com
  * 
  * Si este codigo es usado como ejemplo, no olvides citar quien lo creo.
  * Gracias!
  */
        public VistaEditor()
        {
            InitializeComponent();
        }
        //crear instancia del controlador
        ControladorEditor _Controlador;
        bool cerrar = true;
        #region Eventos de la vista
        private void AbrirBtn_Click(object sender, EventArgs e)
        {
            if (_Controlador.ArchivoCargado && _Controlador.CambiosAGuardar)
            {
                //Si hay cambios pendientes, preguntar al usuario
                DialogoGuardarCambios();                
                MostrarDialogoAbrir();
            }
            else
            {
                //si no hay cambios pendientes, procede a abrir otro archivo
                MostrarDialogoAbrir();
            }

          }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            if (_Controlador.ArchivoCargado && _Controlador.CambiosAGuardar)
            {
                //Si hay cambios pendientes, preguntar al usuario
                DialogoGuardarCambios();
                _Controlador.Nuevo();
                this.TextoTxt.Focus();
            }
            else
            {
                //si no hay cambios pendientes, procede a abrir otro archivo
                _Controlador.Nuevo();
                this.TextoTxt.Focus();
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            //comprobar si es un archivo nuevo
            if (_Controlador.ArchivoNuevo) MostrarDialogoGuardar();
            else
                _Controlador.Guardar();//sino solo guardar
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
           //comprobar si hay cambios pendientes por guardar
            if (_Controlador.ArchivoCargado && _Controlador.CambiosAGuardar)
            {
                DialogoGuardarCambios();               
            }

            if(cerrar)
                this.Close();
        }

        private void TextoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Controlador.CambiosAGuardar = true;
        }

        //implementa metodos privados, relacionados con la inteaccion con el usuario
        // DialogoGuardarcambios, DialogoAbrir, DialogoGuardarPorPrimeraVez

        //metodo que comprueba si hay cambios, si los hay, sugiere al usuario
        void DialogoGuardarCambios()
        {
            DialogResult resultado = MessageBox.Show("Deseas guardar los cambios realizados?", "Cambios realizados", MessageBoxButtons.YesNoCancel);
            //si el usuario quiere guardar los cambios
            if (resultado == DialogResult.Yes)
            {
                //guardar los cambios
                //comprobar si es archivo nuevo o fue abierto
                if (_Controlador.ArchivoNuevo) MostrarDialogoGuardar();

                else
                    _Controlador.Guardar();
            }

            if (resultado == DialogResult.No)
            {
                //Si elige no guardar
                cerrar = true;
            }

            if (resultado == DialogResult.Cancel)
            {
                //no proceder, cancelar la accion
                cerrar = false;
            }
        }

        //metodo que cargara el cuadro de dialogo Abrir archivo
        void MostrarDialogoAbrir()
        {
            this.AbrirArchivoDlg.Filter = "Archivos de texto .txt | *.txt";
            this.AbrirArchivoDlg.ShowDialog();
            string ruta;
            if (this.AbrirArchivoDlg.FileName != "")
            {
                //ruta = System.IO.Path.GetFileName(this.AbrirArchivoDlg.FileName);
                ruta = this.AbrirArchivoDlg.FileName;
                this.InfoLbl.Text = ruta;
                //abrir el archivo
                _Controlador.Abrir(ruta);
            }
        }

        //metodo que cargara el cuadro de dialogo Abrir archivo
        void MostrarDialogoGuardar()
        {
            this.GuardarArchivoDlg.Filter = "Archivos de texto .txt | *.txt";
            this.GuardarArchivoDlg.ShowDialog();
            string ruta;
            if (this.GuardarArchivoDlg.FileName != "")
            {
                //ruta = System.IO.Path.GetFileName(this.GuardarArchivoDlg.FileName);
                ruta = this.GuardarArchivoDlg.FileName;
                this.InfoLbl.Text = ruta;
                //abrir el archivo
                _Controlador.GuardarArchivo(ruta);
                MessageBox.Show("El archivo ha sido guardado correctamente", "Editor de textos", MessageBoxButtons.OK);
            }


            //string cont = this.TextoTxt.Text;
            //this.TextoTxt.Text = "Todo lo que quiera";
            //intanciaObjeto.AbrirArchivo();
            //InstanciaARchivo.Contenido = "Lo que sea";
        }

        #endregion

        #region Implementacion de la interfaz IVista
        public void AplicarControlador(ControladorEditor controlador)
        {
            //Crear la asociacion con el controlador
            _Controlador = controlador;
        }

        public void Limpiar()
        {
            this.TextoTxt.Text = "";
            this.InfoLbl.Text = "";
        }

        //propiedades
        public string Contenido
        {
            get { return this.TextoTxt.Text; }
            set { this.TextoTxt.Text = value; }
        }

        public string Info //Propiedad para mostrar la informacion del archivo
        {
            get { return this.InfoLbl.Text; }
            set { this.InfoLbl.Text = value; }
        }
        #endregion               
    }
}
