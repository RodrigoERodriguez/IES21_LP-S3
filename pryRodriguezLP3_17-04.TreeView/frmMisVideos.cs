using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace pryRodriguezLP_Clase17_04
{
    public partial class frmMisVideos : Form
    {
        clsAutores A;
        clsVideos V;
        string Archivo;

        public frmMisVideos()
        {
            InitializeComponent();
        }

        private void cdmReproducir_Click(object sender, EventArgs e)
        {
            wmpVideo.URL = "Videos/" + Archivo;
        }

        private void frmMisVideos_Load(object sender, EventArgs e)
        {
            Arbolito();
        }

        private void Arbolito()
        {
            wmpVideo.uiMode = "None"; //Deshabilito el UI del WMP
            A = new clsAutores();
            V = new clsVideos();

            TreeNode Abuelo;
            TreeNode Padre;
            TreeNode Hijo;

            Abuelo = tvArbolArtistas.Nodes.Add("AUTORES");

            //Pido los datos y los guardo en las variables 
            DataTable TArtistas = A.GetAutores();
            DataTable TVideos = V.GetVideos();

            foreach(DataRow Art  in TArtistas.Rows)
            {
                Padre = Abuelo.Nodes.Add(Art["nombre"].ToString());
                foreach(DataRow Vid in TVideos.Rows)
                {
                    if (Art["autor"].ToString() ==  Vid["autor"].ToString())
                    {
                        Hijo = Padre.Nodes.Add(Vid["Video"].ToString());
                        Hijo.Tag = Vid["archivo"].ToString();
                    }
                }
            }
        }

        private void tvArbolArtistas_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                //Cuando hagan click en un nodo nivel 2
                //Almacena el video en archivo y luego lo reproduce
                Archivo = e.Node.Tag.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Elemento que le cambia de color al formulario
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Elemento para cambiar las fuentes
            fontDialog1.ShowDialog();
            lblLabel.Font = fontDialog1.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Elemento para guardar archivos
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            //Filta los archivos 
            openFileDialog1.Filter = "Archivos tipo txt |*.txt | Archivos Acrobat |*.pdf";
            //Elemento para abrir archivos
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);
        }
    }
}
