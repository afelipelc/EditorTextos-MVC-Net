namespace EditorDeTextos
{
    partial class VistaEditor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextoTxt = new System.Windows.Forms.TextBox();
            this.AbrirBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.NuevoBtn = new System.Windows.Forms.Button();
            this.AbrirArchivoDlg = new System.Windows.Forms.OpenFileDialog();
            this.GuardarArchivoDlg = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // TextoTxt
            // 
            this.TextoTxt.Location = new System.Drawing.Point(3, 4);
            this.TextoTxt.Multiline = true;
            this.TextoTxt.Name = "TextoTxt";
            this.TextoTxt.Size = new System.Drawing.Size(414, 181);
            this.TextoTxt.TabIndex = 0;
            this.TextoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoTxt_KeyPress);
            // 
            // AbrirBtn
            // 
            this.AbrirBtn.Location = new System.Drawing.Point(189, 191);
            this.AbrirBtn.Name = "AbrirBtn";
            this.AbrirBtn.Size = new System.Drawing.Size(49, 28);
            this.AbrirBtn.TabIndex = 1;
            this.AbrirBtn.Text = "Abrir";
            this.AbrirBtn.UseVisualStyleBackColor = true;
            this.AbrirBtn.Click += new System.EventHandler(this.AbrirBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(299, 191);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(56, 28);
            this.GuardarBtn.TabIndex = 1;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(361, 191);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(56, 28);
            this.CerrarBtn.TabIndex = 1;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // InfoLbl
            // 
            this.InfoLbl.Location = new System.Drawing.Point(5, 191);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(167, 28);
            this.InfoLbl.TabIndex = 2;
            this.InfoLbl.Text = "Archivo: ";
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.Location = new System.Drawing.Point(244, 191);
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Size = new System.Drawing.Size(49, 28);
            this.NuevoBtn.TabIndex = 1;
            this.NuevoBtn.Text = "Nuevo";
            this.NuevoBtn.UseVisualStyleBackColor = true;
            this.NuevoBtn.Click += new System.EventHandler(this.NuevoBtn_Click);
            // 
            // VistaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 225);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.NuevoBtn);
            this.Controls.Add(this.AbrirBtn);
            this.Controls.Add(this.TextoTxt);
            this.Name = "VistaEditor";
            this.Text = "Mi Editor de Textos - afelipelc@gmail.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextoTxt;
        private System.Windows.Forms.Button AbrirBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Button NuevoBtn;
        private System.Windows.Forms.OpenFileDialog AbrirArchivoDlg;
        private System.Windows.Forms.SaveFileDialog GuardarArchivoDlg;
    }
}

