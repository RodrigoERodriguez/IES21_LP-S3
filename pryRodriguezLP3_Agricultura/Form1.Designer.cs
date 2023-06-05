namespace pryRodriguezLP3_Agricultura
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TCAgricultura = new System.Windows.Forms.TabControl();
            this.TPAdministracion = new System.Windows.Forms.TabPage();
            this.txtToneladasA = new System.Windows.Forms.TextBox();
            this.CBCultivoA = new System.Windows.Forms.ComboBox();
            this.CBLocalidadA = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblToneladasA = new System.Windows.Forms.Label();
            this.lblCultivoA = new System.Windows.Forms.Label();
            this.lblLocalidadA = new System.Windows.Forms.Label();
            this.TPGraficos = new System.Windows.Forms.TabPage();
            this.LBLocalidad = new System.Windows.Forms.ListBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.CGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TCAgricultura.SuspendLayout();
            this.TPAdministracion.SuspendLayout();
            this.TPGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // TCAgricultura
            // 
            this.TCAgricultura.Controls.Add(this.TPAdministracion);
            this.TCAgricultura.Controls.Add(this.TPGraficos);
            this.TCAgricultura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCAgricultura.ItemSize = new System.Drawing.Size(200, 25);
            this.TCAgricultura.Location = new System.Drawing.Point(0, 0);
            this.TCAgricultura.Name = "TCAgricultura";
            this.TCAgricultura.SelectedIndex = 0;
            this.TCAgricultura.Size = new System.Drawing.Size(676, 486);
            this.TCAgricultura.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TCAgricultura.TabIndex = 0;
            // 
            // TPAdministracion
            // 
            this.TPAdministracion.Controls.Add(this.txtToneladasA);
            this.TPAdministracion.Controls.Add(this.CBCultivoA);
            this.TPAdministracion.Controls.Add(this.CBLocalidadA);
            this.TPAdministracion.Controls.Add(this.btnActualizar);
            this.TPAdministracion.Controls.Add(this.lblToneladasA);
            this.TPAdministracion.Controls.Add(this.lblCultivoA);
            this.TPAdministracion.Controls.Add(this.lblLocalidadA);
            this.TPAdministracion.Location = new System.Drawing.Point(4, 29);
            this.TPAdministracion.Name = "TPAdministracion";
            this.TPAdministracion.Padding = new System.Windows.Forms.Padding(3);
            this.TPAdministracion.Size = new System.Drawing.Size(668, 453);
            this.TPAdministracion.TabIndex = 0;
            this.TPAdministracion.Text = "Administrar";
            this.TPAdministracion.UseVisualStyleBackColor = true;
            // 
            // txtToneladasA
            // 
            this.txtToneladasA.Location = new System.Drawing.Point(40, 205);
            this.txtToneladasA.Name = "txtToneladasA";
            this.txtToneladasA.Size = new System.Drawing.Size(121, 20);
            this.txtToneladasA.TabIndex = 6;
            // 
            // CBCultivoA
            // 
            this.CBCultivoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCultivoA.FormattingEnabled = true;
            this.CBCultivoA.Location = new System.Drawing.Point(40, 120);
            this.CBCultivoA.Name = "CBCultivoA";
            this.CBCultivoA.Size = new System.Drawing.Size(121, 21);
            this.CBCultivoA.TabIndex = 5;
            // 
            // CBLocalidadA
            // 
            this.CBLocalidadA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLocalidadA.FormattingEnabled = true;
            this.CBLocalidadA.Location = new System.Drawing.Point(40, 52);
            this.CBLocalidadA.Name = "CBLocalidadA";
            this.CBLocalidadA.Size = new System.Drawing.Size(121, 21);
            this.CBLocalidadA.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(40, 259);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblToneladasA
            // 
            this.lblToneladasA.AutoSize = true;
            this.lblToneladasA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToneladasA.Location = new System.Drawing.Point(35, 186);
            this.lblToneladasA.Name = "lblToneladasA";
            this.lblToneladasA.Size = new System.Drawing.Size(87, 16);
            this.lblToneladasA.TabIndex = 2;
            this.lblToneladasA.Text = "Toneladas:";
            // 
            // lblCultivoA
            // 
            this.lblCultivoA.AutoSize = true;
            this.lblCultivoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivoA.Location = new System.Drawing.Point(37, 104);
            this.lblCultivoA.Name = "lblCultivoA";
            this.lblCultivoA.Size = new System.Drawing.Size(59, 16);
            this.lblCultivoA.TabIndex = 1;
            this.lblCultivoA.Text = "Cultivo:";
            // 
            // lblLocalidadA
            // 
            this.lblLocalidadA.AutoSize = true;
            this.lblLocalidadA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadA.Location = new System.Drawing.Point(37, 36);
            this.lblLocalidadA.Name = "lblLocalidadA";
            this.lblLocalidadA.Size = new System.Drawing.Size(81, 16);
            this.lblLocalidadA.TabIndex = 0;
            this.lblLocalidadA.Text = "Localidad:";
            // 
            // TPGraficos
            // 
            this.TPGraficos.Controls.Add(this.LBLocalidad);
            this.TPGraficos.Controls.Add(this.lblLocalidad);
            this.TPGraficos.Controls.Add(this.btnGraficar);
            this.TPGraficos.Controls.Add(this.CGrafico);
            this.TPGraficos.Location = new System.Drawing.Point(4, 29);
            this.TPGraficos.Name = "TPGraficos";
            this.TPGraficos.Padding = new System.Windows.Forms.Padding(3);
            this.TPGraficos.Size = new System.Drawing.Size(668, 453);
            this.TPGraficos.TabIndex = 1;
            this.TPGraficos.Text = "Graficar";
            this.TPGraficos.UseVisualStyleBackColor = true;
            this.TPGraficos.Click += new System.EventHandler(this.TPGraficos_Click);
            // 
            // LBLocalidad
            // 
            this.LBLocalidad.FormattingEnabled = true;
            this.LBLocalidad.Location = new System.Drawing.Point(47, 88);
            this.LBLocalidad.Name = "LBLocalidad";
            this.LBLocalidad.Size = new System.Drawing.Size(148, 277);
            this.LBLocalidad.TabIndex = 6;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(44, 54);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 16);
            this.lblLocalidad.TabIndex = 5;
            this.lblLocalidad.Text = "Localidad";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(47, 391);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 4;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // CGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.CGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CGrafico.Legends.Add(legend1);
            this.CGrafico.Location = new System.Drawing.Point(234, 74);
            this.CGrafico.Name = "CGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CGrafico.Series.Add(series1);
            this.CGrafico.Size = new System.Drawing.Size(400, 300);
            this.CGrafico.TabIndex = 0;
            this.CGrafico.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 486);
            this.Controls.Add(this.TCAgricultura);
            this.Name = "Form1";
            this.Text = "Agricultura IES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TCAgricultura.ResumeLayout(false);
            this.TPAdministracion.ResumeLayout(false);
            this.TPAdministracion.PerformLayout();
            this.TPGraficos.ResumeLayout(false);
            this.TPGraficos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCAgricultura;
        private System.Windows.Forms.TabPage TPAdministracion;
        private System.Windows.Forms.TabPage TPGraficos;
        private System.Windows.Forms.ComboBox CBLocalidadA;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblToneladasA;
        private System.Windows.Forms.Label lblCultivoA;
        private System.Windows.Forms.Label lblLocalidadA;
        private System.Windows.Forms.TextBox txtToneladasA;
        private System.Windows.Forms.ComboBox CBCultivoA;
        private System.Windows.Forms.ListBox LBLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataVisualization.Charting.Chart CGrafico;
    }
}

