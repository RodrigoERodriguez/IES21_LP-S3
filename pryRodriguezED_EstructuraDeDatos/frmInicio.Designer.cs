namespace pryRodriguezED_EstructuraDeDatos
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.PCentral = new System.Windows.Forms.Panel();
            this.PInferior = new System.Windows.Forms.Panel();
            this.PLateral = new System.Windows.Forms.Panel();
            this.PSubMenuMas = new System.Windows.Forms.Panel();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.PSubMenuNoLineales = new System.Windows.Forms.Panel();
            this.btnBaseDeDatos = new System.Windows.Forms.Button();
            this.btnArbolBinario = new System.Windows.Forms.Button();
            this.btnNoLineales = new System.Windows.Forms.Button();
            this.PSubMenuLineales = new System.Windows.Forms.Panel();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnPila = new System.Windows.Forms.Button();
            this.btnLineales = new System.Windows.Forms.Button();
            this.PLogo = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.PLateral.SuspendLayout();
            this.PSubMenuMas.SuspendLayout();
            this.PSubMenuNoLineales.SuspendLayout();
            this.PSubMenuLineales.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(200, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(931, 586);
            this.PCentral.TabIndex = 23;
            // 
            // PInferior
            // 
            this.PInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PInferior.Location = new System.Drawing.Point(200, 586);
            this.PInferior.Name = "PInferior";
            this.PInferior.Size = new System.Drawing.Size(931, 66);
            this.PInferior.TabIndex = 22;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.PSubMenuMas);
            this.PLateral.Controls.Add(this.btnMas);
            this.PLateral.Controls.Add(this.PSubMenuNoLineales);
            this.PLateral.Controls.Add(this.btnNoLineales);
            this.PLateral.Controls.Add(this.PSubMenuLineales);
            this.PLateral.Controls.Add(this.btnLineales);
            this.PLateral.Controls.Add(this.PLogo);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(200, 652);
            this.PLateral.TabIndex = 21;
            // 
            // PSubMenuMas
            // 
            this.PSubMenuMas.Controls.Add(this.btnSistema);
            this.PSubMenuMas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSubMenuMas.Location = new System.Drawing.Point(0, 553);
            this.PSubMenuMas.Name = "PSubMenuMas";
            this.PSubMenuMas.Size = new System.Drawing.Size(200, 100);
            this.PSubMenuMas.TabIndex = 9;
            // 
            // btnSistema
            // 
            this.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSistema.FlatAppearance.BorderSize = 0;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.ForeColor = System.Drawing.Color.White;
            this.btnSistema.Location = new System.Drawing.Point(0, 0);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSistema.Size = new System.Drawing.Size(200, 62);
            this.btnSistema.TabIndex = 5;
            this.btnSistema.Text = "Sistema";
            this.btnSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.btnMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.Color.White;
            this.btnMas.Location = new System.Drawing.Point(0, 508);
            this.btnMas.Name = "btnMas";
            this.btnMas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMas.Size = new System.Drawing.Size(200, 45);
            this.btnMas.TabIndex = 8;
            this.btnMas.Text = "Mas";
            this.btnMas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // PSubMenuNoLineales
            // 
            this.PSubMenuNoLineales.Controls.Add(this.btnBaseDeDatos);
            this.PSubMenuNoLineales.Controls.Add(this.btnArbolBinario);
            this.PSubMenuNoLineales.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSubMenuNoLineales.Location = new System.Drawing.Point(0, 387);
            this.PSubMenuNoLineales.Name = "PSubMenuNoLineales";
            this.PSubMenuNoLineales.Size = new System.Drawing.Size(200, 121);
            this.PSubMenuNoLineales.TabIndex = 6;
            // 
            // btnBaseDeDatos
            // 
            this.btnBaseDeDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseDeDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaseDeDatos.FlatAppearance.BorderSize = 0;
            this.btnBaseDeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaseDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseDeDatos.ForeColor = System.Drawing.Color.White;
            this.btnBaseDeDatos.Location = new System.Drawing.Point(0, 62);
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBaseDeDatos.Size = new System.Drawing.Size(200, 62);
            this.btnBaseDeDatos.TabIndex = 4;
            this.btnBaseDeDatos.Text = "Base de datos";
            this.btnBaseDeDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaseDeDatos.UseVisualStyleBackColor = true;
            this.btnBaseDeDatos.Click += new System.EventHandler(this.btnBaseDeDatos_Click);
            // 
            // btnArbolBinario
            // 
            this.btnArbolBinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArbolBinario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArbolBinario.FlatAppearance.BorderSize = 0;
            this.btnArbolBinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArbolBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArbolBinario.ForeColor = System.Drawing.Color.White;
            this.btnArbolBinario.Location = new System.Drawing.Point(0, 0);
            this.btnArbolBinario.Name = "btnArbolBinario";
            this.btnArbolBinario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnArbolBinario.Size = new System.Drawing.Size(200, 62);
            this.btnArbolBinario.TabIndex = 3;
            this.btnArbolBinario.Text = "Arbol Binario";
            this.btnArbolBinario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArbolBinario.UseVisualStyleBackColor = true;
            this.btnArbolBinario.Click += new System.EventHandler(this.btnArbolBinario_Click);
            // 
            // btnNoLineales
            // 
            this.btnNoLineales.AccessibleDescription = "";
            this.btnNoLineales.AccessibleName = "";
            this.btnNoLineales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.btnNoLineales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoLineales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoLineales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoLineales.ForeColor = System.Drawing.Color.White;
            this.btnNoLineales.Location = new System.Drawing.Point(0, 342);
            this.btnNoLineales.Name = "btnNoLineales";
            this.btnNoLineales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNoLineales.Size = new System.Drawing.Size(200, 45);
            this.btnNoLineales.TabIndex = 5;
            this.btnNoLineales.Text = "No Lineales";
            this.btnNoLineales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoLineales.UseVisualStyleBackColor = false;
            this.btnNoLineales.Click += new System.EventHandler(this.btnNoLineales_Click);
            // 
            // PSubMenuLineales
            // 
            this.PSubMenuLineales.Controls.Add(this.btnLista);
            this.PSubMenuLineales.Controls.Add(this.btnCola);
            this.PSubMenuLineales.Controls.Add(this.btnPila);
            this.PSubMenuLineales.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSubMenuLineales.Location = new System.Drawing.Point(0, 153);
            this.PSubMenuLineales.Name = "PSubMenuLineales";
            this.PSubMenuLineales.Size = new System.Drawing.Size(200, 189);
            this.PSubMenuLineales.TabIndex = 4;
            // 
            // btnLista
            // 
            this.btnLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.White;
            this.btnLista.Location = new System.Drawing.Point(0, 124);
            this.btnLista.Name = "btnLista";
            this.btnLista.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLista.Size = new System.Drawing.Size(200, 62);
            this.btnLista.TabIndex = 4;
            this.btnLista.Text = "Lista";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnCola
            // 
            this.btnCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCola.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCola.FlatAppearance.BorderSize = 0;
            this.btnCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCola.ForeColor = System.Drawing.Color.White;
            this.btnCola.Location = new System.Drawing.Point(0, 62);
            this.btnCola.Name = "btnCola";
            this.btnCola.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCola.Size = new System.Drawing.Size(200, 62);
            this.btnCola.TabIndex = 3;
            this.btnCola.Text = "Cola";
            this.btnCola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnPila
            // 
            this.btnPila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPila.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPila.FlatAppearance.BorderSize = 0;
            this.btnPila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPila.ForeColor = System.Drawing.Color.White;
            this.btnPila.Location = new System.Drawing.Point(0, 0);
            this.btnPila.Name = "btnPila";
            this.btnPila.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPila.Size = new System.Drawing.Size(200, 62);
            this.btnPila.TabIndex = 2;
            this.btnPila.Text = "Pila";
            this.btnPila.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // btnLineales
            // 
            this.btnLineales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.btnLineales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLineales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLineales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineales.ForeColor = System.Drawing.Color.White;
            this.btnLineales.Location = new System.Drawing.Point(0, 108);
            this.btnLineales.Name = "btnLineales";
            this.btnLineales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLineales.Size = new System.Drawing.Size(200, 45);
            this.btnLineales.TabIndex = 3;
            this.btnLineales.Text = "Lineales";
            this.btnLineales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLineales.UseVisualStyleBackColor = false;
            this.btnLineales.Click += new System.EventHandler(this.btnLineales_Click);
            // 
            // PLogo
            // 
            this.PLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.PLogo.Controls.Add(this.PBLogo);
            this.PLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PLogo.Location = new System.Drawing.Point(0, 0);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(200, 108);
            this.PLogo.TabIndex = 0;
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.White;
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(200, 108);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 2;
            this.PBLogo.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 652);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PInferior);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.PLateral.ResumeLayout(false);
            this.PSubMenuMas.ResumeLayout(false);
            this.PSubMenuNoLineales.ResumeLayout(false);
            this.PSubMenuLineales.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Panel PInferior;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Panel PSubMenuNoLineales;
        private System.Windows.Forms.Button btnBaseDeDatos;
        private System.Windows.Forms.Button btnArbolBinario;
        private System.Windows.Forms.Button btnNoLineales;
        private System.Windows.Forms.Panel PSubMenuLineales;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Button btnLineales;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Panel PSubMenuMas;
        private System.Windows.Forms.Button btnSistema;
    }
}

