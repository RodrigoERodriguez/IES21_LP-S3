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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDatos d = new clsDatos();
            DataTable TVendedores = d.getData("SELECT * FROM Vendedores");
            DataTable TVentas = d.getData("SELECT * FROM Ventas");

            foreach (DataRow filaVendedor in TVendedores.Rows)
            {
                int Total = 0;
                foreach (DataRow FilaVentas in TVentas.Rows)
                {
                    if (filaVendedor["Vendedor"].ToString() == FilaVentas["Vendedor"].ToString())
                    {
                        Total = Total + (int)FilaVentas["cantidad"];
                    }
                }
                dataGridView1.Rows.Add(filaVendedor["nombre"], Total.ToString());
            }
        }
    }
}
