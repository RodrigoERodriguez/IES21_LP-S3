using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezLP_Clase11_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode Abuelo;
            TreeNode Padre;
            TreeNode Hijo;

            Abuelo = TView.Nodes.Add("ALIMENTOS", "ALIMENTOS", 0);

            Padre = Abuelo.Nodes.Add("FRUTAS", "FRUTAS" , 1,3);
            Hijo = Padre.Nodes.Add("UVA", "UVA" , 2,3);
            Hijo.Tag = "300";
            Hijo = Padre.Nodes.Add("PERA" , "PERA", 2,3);
            Hijo.Tag = "400";
            Hijo = Padre.Nodes.Add("NARANJA" , "NARANJA" , 2,3);
            Hijo.Tag = "500";


            Padre = Abuelo.Nodes.Add("VERDURAS" , "VERDURAS" , 1,3);
            Hijo = Padre.Nodes.Add("ACELGA" , "ACELGA", 2,3);
            Hijo.Tag = "350";
            Hijo = Padre.Nodes.Add("REPOLLO" , "REPOLLO", 2,3);
            Hijo.Tag = "450";
            Hijo = Padre.Nodes.Add("TOMATE" , "TOMATE", 2,3);
            Hijo.Tag = "550";


            label1.Text = DateTime.Now.ToString();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void TView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level ==2)
            {
                MessageBox.Show("El kilo vale $" + e.Node.Tag.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
