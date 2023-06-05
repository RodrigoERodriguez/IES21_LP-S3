using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRodriguezLP_Clase18_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Archivo = saveFileDialog1.FileName;
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            MessageBox.Show("Archivo guardado de manera correcta");

            //Defino donde lo guardo
            StreamWriter sw = new StreamWriter(Archivo);
            sw.WriteLine(txtReceta.Text);
            sw.Close();
            sw.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListView frmListView = new frmListView();
            frmListView.ShowDialog();
        }
    }
}
