namespace pryRodriguezLP_Clase10_04
{
    partial class frmPantallaPrincipal
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
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lstEspecialidades = new System.Windows.Forms.ComboBox();
            this.lblLeyendaTitulo = new System.Windows.Forms.Label();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(30, 101);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(189, 23);
            this.lblLeyenda.TabIndex = 0;
            this.lblLeyenda.Text = "Selecione una especialidad:";
            // 
            // lstEspecialidades
            // 
            this.lstEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEspecialidades.FormattingEnabled = true;
            this.lstEspecialidades.Items.AddRange(new object[] {
            ""});
            this.lstEspecialidades.Location = new System.Drawing.Point(225, 101);
            this.lstEspecialidades.Name = "lstEspecialidades";
            this.lstEspecialidades.Size = new System.Drawing.Size(150, 21);
            this.lstEspecialidades.TabIndex = 1;
            this.lstEspecialidades.SelectedIndexChanged += new System.EventHandler(this.lstEspecialidades_SelectedIndexChanged);
            // 
            // lblLeyendaTitulo
            // 
            this.lblLeyendaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyendaTitulo.Location = new System.Drawing.Point(50, 28);
            this.lblLeyendaTitulo.Name = "lblLeyendaTitulo";
            this.lblLeyendaTitulo.Size = new System.Drawing.Size(353, 44);
            this.lblLeyendaTitulo.TabIndex = 2;
            this.lblLeyendaTitulo.Text = "Bienvenidos a Clinica IES21, para ingresar su turno complete los siguientes datos" +
    ".";
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(33, 198);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(370, 150);
            this.dgvMedicos.TabIndex = 3;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVer.Enabled = false;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(319, 147);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(84, 23);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(381, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.lblLeyendaTitulo);
            this.Controls.Add(this.lstEspecialidades);
            this.Controls.Add(this.lblLeyenda);
            this.Name = "frmPantallaPrincipal";
            this.Text = "Clinica IES21";
            this.Load += new System.EventHandler(this.frmPantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.ComboBox lstEspecialidades;
        private System.Windows.Forms.Label lblLeyendaTitulo;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button button1;
    }
}

