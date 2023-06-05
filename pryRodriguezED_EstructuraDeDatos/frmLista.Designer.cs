namespace pryRodriguezED_EstructuraDeDatos
{
    partial class frmLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLista));
            this.PCentral = new System.Windows.Forms.Panel();
            this.PLateral = new System.Windows.Forms.Panel();
            this.btnListaDoble = new System.Windows.Forms.Button();
            this.btnListaSimple = new System.Windows.Forms.Button();
            this.btnLineales = new System.Windows.Forms.Button();
            this.PLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCentral
            // 
            this.PCentral.BackColor = System.Drawing.Color.White;
            this.PCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCentral.Location = new System.Drawing.Point(204, 0);
            this.PCentral.Name = "PCentral";
            this.PCentral.Size = new System.Drawing.Size(833, 543);
            this.PCentral.TabIndex = 31;
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.PLateral.Controls.Add(this.btnListaDoble);
            this.PLateral.Controls.Add(this.btnListaSimple);
            this.PLateral.Controls.Add(this.btnLineales);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(204, 543);
            this.PLateral.TabIndex = 30;
            // 
            // btnListaDoble
            // 
            this.btnListaDoble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaDoble.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaDoble.FlatAppearance.BorderSize = 0;
            this.btnListaDoble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaDoble.ForeColor = System.Drawing.Color.White;
            this.btnListaDoble.Location = new System.Drawing.Point(0, 107);
            this.btnListaDoble.Name = "btnListaDoble";
            this.btnListaDoble.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListaDoble.Size = new System.Drawing.Size(204, 62);
            this.btnListaDoble.TabIndex = 6;
            this.btnListaDoble.Text = "Dobles";
            this.btnListaDoble.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaDoble.UseVisualStyleBackColor = true;
            this.btnListaDoble.Click += new System.EventHandler(this.btnListaDoble_Click);
            // 
            // btnListaSimple
            // 
            this.btnListaSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaSimple.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaSimple.FlatAppearance.BorderSize = 0;
            this.btnListaSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaSimple.ForeColor = System.Drawing.Color.White;
            this.btnListaSimple.Location = new System.Drawing.Point(0, 45);
            this.btnListaSimple.Name = "btnListaSimple";
            this.btnListaSimple.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListaSimple.Size = new System.Drawing.Size(204, 62);
            this.btnListaSimple.TabIndex = 5;
            this.btnListaSimple.Text = "Simples";
            this.btnListaSimple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaSimple.UseVisualStyleBackColor = true;
            this.btnListaSimple.Click += new System.EventHandler(this.btnListaSimple_Click);
            // 
            // btnLineales
            // 
            this.btnLineales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.btnLineales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLineales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineales.ForeColor = System.Drawing.Color.White;
            this.btnLineales.Location = new System.Drawing.Point(0, 0);
            this.btnLineales.Name = "btnLineales";
            this.btnLineales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLineales.Size = new System.Drawing.Size(204, 45);
            this.btnLineales.TabIndex = 4;
            this.btnLineales.Text = "LISTA";
            this.btnLineales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLineales.UseVisualStyleBackColor = false;
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 543);
            this.Controls.Add(this.PCentral);
            this.Controls.Add(this.PLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLista_Load);
            this.PLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PCentral;
        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Button btnListaDoble;
        private System.Windows.Forms.Button btnListaSimple;
        private System.Windows.Forms.Button btnLineales;
    }
}