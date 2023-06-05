namespace pryRodriguezLP3_TrabajoPracticoEncuestas
{
    partial class frmPantallaInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaInicio));
            this.tHoraYFecha = new System.Windows.Forms.Timer(this.components);
            this.tpResultados = new System.Windows.Forms.TabPage();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.dgvEncuestas = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbProfesion = new System.Windows.Forms.ComboBox();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.gbLocalidad = new System.Windows.Forms.GroupBox();
            this.lblIDLocalidad = new System.Windows.Forms.Label();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.txtIDLocalidad = new System.Windows.Forms.TextBox();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.gbProfesion = new System.Windows.Forms.GroupBox();
            this.lblIDProfesion = new System.Windows.Forms.Label();
            this.lblNombreProfesion = new System.Windows.Forms.Label();
            this.txtIDProfesion = new System.Windows.Forms.TextBox();
            this.txtNombreProfesion = new System.Windows.Forms.TextBox();
            this.btnAgregarProfesion = new System.Windows.Forms.Button();
            this.tcPestañasControl = new System.Windows.Forms.TabControl();
            this.tpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).BeginInit();
            this.tpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tpRegistro.SuspendLayout();
            this.gbLocalidad.SuspendLayout();
            this.gbProfesion.SuspendLayout();
            this.tcPestañasControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tHoraYFecha
            // 
            this.tHoraYFecha.Tick += new System.EventHandler(this.tHoraYFecha_Tick);
            // 
            // tpResultados
            // 
            this.tpResultados.Controls.Add(this.btnRefrescar);
            this.tpResultados.Controls.Add(this.dgvEncuestas);
            this.tpResultados.Controls.Add(this.lblLeyenda);
            this.tpResultados.Location = new System.Drawing.Point(4, 29);
            this.tpResultados.Name = "tpResultados";
            this.tpResultados.Padding = new System.Windows.Forms.Padding(3);
            this.tpResultados.Size = new System.Drawing.Size(792, 417);
            this.tpResultados.TabIndex = 2;
            this.tpResultados.Text = "Resultados";
            this.tpResultados.UseVisualStyleBackColor = true;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(234, 35);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(289, 20);
            this.lblLeyenda.TabIndex = 5;
            this.lblLeyenda.Text = "Encuesta provincial de profesiones";
            // 
            // dgvEncuestas
            // 
            this.dgvEncuestas.AllowUserToAddRows = false;
            this.dgvEncuestas.AllowUserToDeleteRows = false;
            this.dgvEncuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncuestas.Location = new System.Drawing.Point(84, 96);
            this.dgvEncuestas.Name = "dgvEncuestas";
            this.dgvEncuestas.ReadOnly = true;
            this.dgvEncuestas.Size = new System.Drawing.Size(598, 234);
            this.dgvEncuestas.TabIndex = 4;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(592, 353);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(90, 29);
            this.btnRefrescar.TabIndex = 18;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // tpAgregar
            // 
            this.tpAgregar.Controls.Add(this.cbProfesion);
            this.tpAgregar.Controls.Add(this.cbLocalidad);
            this.tpAgregar.Controls.Add(this.lblHora);
            this.tpAgregar.Controls.Add(this.lblFecha);
            this.tpAgregar.Controls.Add(this.pbLogo);
            this.tpAgregar.Controls.Add(this.txtCantidad);
            this.tpAgregar.Controls.Add(this.btnAgregar);
            this.tpAgregar.Controls.Add(this.lblCantidad);
            this.tpAgregar.Controls.Add(this.lblProfesion);
            this.tpAgregar.Controls.Add(this.lblLocalidad);
            this.tpAgregar.Location = new System.Drawing.Point(4, 29);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregar.Size = new System.Drawing.Size(792, 417);
            this.tpAgregar.TabIndex = 1;
            this.tpAgregar.Text = "Agregar";
            this.tpAgregar.UseVisualStyleBackColor = true;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(71, 135);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(81, 16);
            this.lblLocalidad.TabIndex = 10;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesion.Location = new System.Drawing.Point(71, 176);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(78, 16);
            this.lblProfesion.TabIndex = 11;
            this.lblProfesion.Text = "Profesion:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(71, 213);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 16);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(166, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 29);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(166, 209);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 15;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(437, 135);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(230, 202);
            this.pbLogo.TabIndex = 17;
            this.pbLogo.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(389, 99);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 31);
            this.lblFecha.TabIndex = 18;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHora.Location = new System.Drawing.Point(383, 28);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 69);
            this.lblHora.TabIndex = 19;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(166, 134);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cbLocalidad.TabIndex = 20;
            this.cbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cbLocalidad_SelectedIndexChanged);
            // 
            // cbProfesion
            // 
            this.cbProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesion.FormattingEnabled = true;
            this.cbProfesion.Location = new System.Drawing.Point(166, 171);
            this.cbProfesion.Name = "cbProfesion";
            this.cbProfesion.Size = new System.Drawing.Size(121, 21);
            this.cbProfesion.TabIndex = 21;
            this.cbProfesion.SelectedIndexChanged += new System.EventHandler(this.cbProfesion_SelectedIndexChanged);
            // 
            // tpRegistro
            // 
            this.tpRegistro.Controls.Add(this.gbProfesion);
            this.tpRegistro.Controls.Add(this.gbLocalidad);
            this.tpRegistro.Location = new System.Drawing.Point(4, 29);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistro.Size = new System.Drawing.Size(792, 417);
            this.tpRegistro.TabIndex = 0;
            this.tpRegistro.Text = "Registro";
            this.tpRegistro.UseVisualStyleBackColor = true;
            // 
            // gbLocalidad
            // 
            this.gbLocalidad.Controls.Add(this.txtNombreLocalidad);
            this.gbLocalidad.Controls.Add(this.txtIDLocalidad);
            this.gbLocalidad.Controls.Add(this.btnAgregarLocalidad);
            this.gbLocalidad.Controls.Add(this.lblNombreLocalidad);
            this.gbLocalidad.Controls.Add(this.lblIDLocalidad);
            this.gbLocalidad.Location = new System.Drawing.Point(90, 77);
            this.gbLocalidad.Name = "gbLocalidad";
            this.gbLocalidad.Size = new System.Drawing.Size(234, 260);
            this.gbLocalidad.TabIndex = 0;
            this.gbLocalidad.TabStop = false;
            this.gbLocalidad.Text = "Registro Localidad";
            // 
            // lblIDLocalidad
            // 
            this.lblIDLocalidad.AutoSize = true;
            this.lblIDLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLocalidad.Location = new System.Drawing.Point(24, 40);
            this.lblIDLocalidad.Name = "lblIDLocalidad";
            this.lblIDLocalidad.Size = new System.Drawing.Size(100, 16);
            this.lblIDLocalidad.TabIndex = 11;
            this.lblIDLocalidad.Text = "ID Localidad:";
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidad.Location = new System.Drawing.Point(24, 127);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(140, 16);
            this.lblNombreLocalidad.TabIndex = 12;
            this.lblNombreLocalidad.Text = "Nombre Localidad:";
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.Enabled = false;
            this.btnAgregarLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(73, 211);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(90, 29);
            this.btnAgregarLocalidad.TabIndex = 14;
            this.btnAgregarLocalidad.Text = "Agregar";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = true;
            this.btnAgregarLocalidad.Click += new System.EventHandler(this.btnAgregarLocalidad_Click);
            // 
            // txtIDLocalidad
            // 
            this.txtIDLocalidad.Location = new System.Drawing.Point(27, 70);
            this.txtIDLocalidad.Name = "txtIDLocalidad";
            this.txtIDLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtIDLocalidad.TabIndex = 15;
            this.txtIDLocalidad.TextChanged += new System.EventHandler(this.txtIDLocalidad_TextChanged);
            this.txtIDLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDLocalidad_KeyPress);
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(27, 160);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLocalidad.TabIndex = 16;
            this.txtNombreLocalidad.TextChanged += new System.EventHandler(this.txtNombreLocalidad_TextChanged);
            this.txtNombreLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLocalidad_KeyPress);
            // 
            // gbProfesion
            // 
            this.gbProfesion.Controls.Add(this.btnAgregarProfesion);
            this.gbProfesion.Controls.Add(this.txtNombreProfesion);
            this.gbProfesion.Controls.Add(this.txtIDProfesion);
            this.gbProfesion.Controls.Add(this.lblNombreProfesion);
            this.gbProfesion.Controls.Add(this.lblIDProfesion);
            this.gbProfesion.Location = new System.Drawing.Point(457, 77);
            this.gbProfesion.Name = "gbProfesion";
            this.gbProfesion.Size = new System.Drawing.Size(234, 260);
            this.gbProfesion.TabIndex = 1;
            this.gbProfesion.TabStop = false;
            this.gbProfesion.Text = "Registro Profesion";
            // 
            // lblIDProfesion
            // 
            this.lblIDProfesion.AutoSize = true;
            this.lblIDProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProfesion.Location = new System.Drawing.Point(30, 40);
            this.lblIDProfesion.Name = "lblIDProfesion";
            this.lblIDProfesion.Size = new System.Drawing.Size(97, 16);
            this.lblIDProfesion.TabIndex = 17;
            this.lblIDProfesion.Text = "ID Profesion:";
            // 
            // lblNombreProfesion
            // 
            this.lblNombreProfesion.AutoSize = true;
            this.lblNombreProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesion.Location = new System.Drawing.Point(30, 127);
            this.lblNombreProfesion.Name = "lblNombreProfesion";
            this.lblNombreProfesion.Size = new System.Drawing.Size(137, 16);
            this.lblNombreProfesion.TabIndex = 18;
            this.lblNombreProfesion.Text = "Nombre Profesion:";
            // 
            // txtIDProfesion
            // 
            this.txtIDProfesion.Location = new System.Drawing.Point(33, 70);
            this.txtIDProfesion.Name = "txtIDProfesion";
            this.txtIDProfesion.Size = new System.Drawing.Size(100, 20);
            this.txtIDProfesion.TabIndex = 19;
            this.txtIDProfesion.TextChanged += new System.EventHandler(this.txtIDProfesion_TextChanged);
            this.txtIDProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProfesion_KeyPress);
            // 
            // txtNombreProfesion
            // 
            this.txtNombreProfesion.Location = new System.Drawing.Point(33, 160);
            this.txtNombreProfesion.Name = "txtNombreProfesion";
            this.txtNombreProfesion.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProfesion.TabIndex = 20;
            this.txtNombreProfesion.TextChanged += new System.EventHandler(this.txtNombreProfesion_TextChanged);
            this.txtNombreProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProfesion_KeyPress);
            // 
            // btnAgregarProfesion
            // 
            this.btnAgregarProfesion.Enabled = false;
            this.btnAgregarProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProfesion.Location = new System.Drawing.Point(76, 211);
            this.btnAgregarProfesion.Name = "btnAgregarProfesion";
            this.btnAgregarProfesion.Size = new System.Drawing.Size(90, 29);
            this.btnAgregarProfesion.TabIndex = 17;
            this.btnAgregarProfesion.Text = "Agregar";
            this.btnAgregarProfesion.UseVisualStyleBackColor = true;
            this.btnAgregarProfesion.Click += new System.EventHandler(this.btnAgregarProfesion_Click);
            // 
            // tcPestañasControl
            // 
            this.tcPestañasControl.Controls.Add(this.tpRegistro);
            this.tcPestañasControl.Controls.Add(this.tpAgregar);
            this.tcPestañasControl.Controls.Add(this.tpResultados);
            this.tcPestañasControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPestañasControl.ItemSize = new System.Drawing.Size(150, 25);
            this.tcPestañasControl.Location = new System.Drawing.Point(0, 0);
            this.tcPestañasControl.Name = "tcPestañasControl";
            this.tcPestañasControl.SelectedIndex = 0;
            this.tcPestañasControl.Size = new System.Drawing.Size(800, 450);
            this.tcPestañasControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPestañasControl.TabIndex = 3;
            // 
            // frmPantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcPestañasControl);
            this.Name = "frmPantallaInicio";
            this.Text = "Direccion de Profesiones";
            this.Load += new System.EventHandler(this.frmPantallaInicio_Load);
            this.tpResultados.ResumeLayout(false);
            this.tpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).EndInit();
            this.tpAgregar.ResumeLayout(false);
            this.tpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tpRegistro.ResumeLayout(false);
            this.gbLocalidad.ResumeLayout(false);
            this.gbLocalidad.PerformLayout();
            this.gbProfesion.ResumeLayout(false);
            this.gbProfesion.PerformLayout();
            this.tcPestañasControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tHoraYFecha;
        private System.Windows.Forms.TabPage tpResultados;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dgvEncuestas;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.TabPage tpAgregar;
        private System.Windows.Forms.ComboBox cbProfesion;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.GroupBox gbProfesion;
        private System.Windows.Forms.Button btnAgregarProfesion;
        private System.Windows.Forms.TextBox txtNombreProfesion;
        private System.Windows.Forms.TextBox txtIDProfesion;
        private System.Windows.Forms.Label lblNombreProfesion;
        private System.Windows.Forms.Label lblIDProfesion;
        private System.Windows.Forms.GroupBox gbLocalidad;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.TextBox txtIDLocalidad;
        private System.Windows.Forms.Button btnAgregarLocalidad;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblIDLocalidad;
        private System.Windows.Forms.TabControl tcPestañasControl;
    }
}

