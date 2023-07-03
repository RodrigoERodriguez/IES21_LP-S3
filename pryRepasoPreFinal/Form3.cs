using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryRepasoPreFinal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDatos d = new clsDatos();
            chart1.Series.Clear();
            chart1.Titles.Clear();
            Series Series = chart1.Series.Add("Ventas");
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
                Series.Points.AddXY(filaVendedor["nombre"], Total.ToString());
            }
        }
    }
}
