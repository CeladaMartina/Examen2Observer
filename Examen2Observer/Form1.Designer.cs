
namespace Examen2Observer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.listNotificaciones = new System.Windows.Forms.ListBox();
            this.btnSuscribir = new System.Windows.Forms.Button();
            this.btnDesuscribir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsuarios
            // 
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.ItemHeight = 16;
            this.listUsuarios.Location = new System.Drawing.Point(12, 26);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(236, 324);
            this.listUsuarios.TabIndex = 0;
            // 
            // listNotificaciones
            // 
            this.listNotificaciones.FormattingEnabled = true;
            this.listNotificaciones.ItemHeight = 16;
            this.listNotificaciones.Location = new System.Drawing.Point(556, 26);
            this.listNotificaciones.Name = "listNotificaciones";
            this.listNotificaciones.Size = new System.Drawing.Size(279, 324);
            this.listNotificaciones.TabIndex = 1;
            // 
            // btnSuscribir
            // 
            this.btnSuscribir.Location = new System.Drawing.Point(347, 110);
            this.btnSuscribir.Name = "btnSuscribir";
            this.btnSuscribir.Size = new System.Drawing.Size(128, 56);
            this.btnSuscribir.TabIndex = 2;
            this.btnSuscribir.Text = "Suscribir";
            this.btnSuscribir.UseVisualStyleBackColor = true;
            this.btnSuscribir.Click += new System.EventHandler(this.btnSuscribir_Click);
            // 
            // btnDesuscribir
            // 
            this.btnDesuscribir.Location = new System.Drawing.Point(347, 191);
            this.btnDesuscribir.Name = "btnDesuscribir";
            this.btnDesuscribir.Size = new System.Drawing.Size(128, 56);
            this.btnDesuscribir.TabIndex = 3;
            this.btnDesuscribir.Text = "Desuscribir";
            this.btnDesuscribir.UseVisualStyleBackColor = true;
            this.btnDesuscribir.Click += new System.EventHandler(this.btnDesuscribir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Precio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDesuscribir);
            this.Controls.Add(this.btnSuscribir);
            this.Controls.Add(this.listNotificaciones);
            this.Controls.Add(this.listUsuarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listUsuarios;
        private System.Windows.Forms.ListBox listNotificaciones;
        private System.Windows.Forms.Button btnSuscribir;
        private System.Windows.Forms.Button btnDesuscribir;
        private System.Windows.Forms.Button button1;
    }
}

