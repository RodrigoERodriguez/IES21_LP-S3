namespace pryRodriguezLP_Clase04_04
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
            this.btnBoton = new System.Windows.Forms.Button();
            this.btnElBoton = new System.Windows.Forms.Button();
            this.btnElBotonMejorado = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.Location = new System.Drawing.Point(22, 94);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(75, 23);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Boton";
            this.btnBoton.UseVisualStyleBackColor = true;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // btnElBoton
            // 
            this.btnElBoton.Location = new System.Drawing.Point(153, 94);
            this.btnElBoton.Name = "btnElBoton";
            this.btnElBoton.Size = new System.Drawing.Size(75, 23);
            this.btnElBoton.TabIndex = 1;
            this.btnElBoton.Text = "El boton";
            this.btnElBoton.UseVisualStyleBackColor = true;
            this.btnElBoton.Click += new System.EventHandler(this.btnElBoton_Click);
            // 
            // btnElBotonMejorado
            // 
            this.btnElBotonMejorado.Location = new System.Drawing.Point(291, 94);
            this.btnElBotonMejorado.Name = "btnElBotonMejorado";
            this.btnElBotonMejorado.Size = new System.Drawing.Size(75, 23);
            this.btnElBotonMejorado.TabIndex = 2;
            this.btnElBotonMejorado.Text = "El boton mejorado";
            this.btnElBotonMejorado.UseVisualStyleBackColor = true;
            this.btnElBotonMejorado.Click += new System.EventHandler(this.btnElBotonMejorado_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(22, 34);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(344, 20);
            this.txtDatos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnElBotonMejorado);
            this.Controls.Add(this.btnElBoton);
            this.Controls.Add(this.btnBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.Button btnElBoton;
        private System.Windows.Forms.Button btnElBotonMejorado;
        private System.Windows.Forms.TextBox txtDatos;
    }
}

