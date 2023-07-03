using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRepasoPreFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDatos d = new clsDatos();
            dataGridView1.DataSource = d.getData("SELECT * FROM Vendedores");
            dataGridView2.DataSource = d.getData("SELECT * FROM Ventas");
        }
    }
}
