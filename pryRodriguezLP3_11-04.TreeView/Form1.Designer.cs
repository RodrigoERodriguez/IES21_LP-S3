namespace pryRodriguezLP_Clase11_04
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TView = new System.Windows.Forms.TreeView();
            this.ILAbuelo = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TView
            // 
            this.TView.ImageIndex = 0;
            this.TView.ImageList = this.ILAbuelo;
            this.TView.Location = new System.Drawing.Point(12, 28);
            this.TView.Name = "TView";
            this.TView.SelectedImageIndex = 0;
            this.TView.Size = new System.Drawing.Size(603, 391);
            this.TView.TabIndex = 0;
            this.TView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TView_NodeMouseClick);
            // 
            // ILAbuelo
            // 
            this.ILAbuelo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILAbuelo.ImageStream")));
            this.ILAbuelo.TransparentColor = System.Drawing.Color.Transparent;
            this.ILAbuelo.Images.SetKeyName(0, "f1.png");
            this.ILAbuelo.Images.SetKeyName(1, "ff1.png");
            this.ILAbuelo.Images.SetKeyName(2, "images (2).png");
            this.ILAbuelo.Images.SetKeyName(3, "has.png");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 115);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TView;
        private System.Windows.Forms.ImageList ILAbuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

