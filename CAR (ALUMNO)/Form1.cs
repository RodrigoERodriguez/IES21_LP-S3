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

namespace CAR
{
    public partial class Form1 : Form
    {
        clsVendedores objVendedores;
        clsVentas objVentas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objVendedores = new clsVendedores();
                DataTable vendedores = objVendedores.getAll();
                foreach (DataRow filaVendedores in vendedores.Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = filaVendedores["nombre"].ToString();
                    item.Tag = filaVendedores["vendedor"];
                    listView1.Items.Add(item);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("error en la base de datos");
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int Desde = Convert.ToInt32(textBox1.Text);
                int Hasta = Convert.ToInt32(textBox2.Text);
                objVentas = new clsVentas();
                DataTable tablaVentas = objVentas.getAll();
                Series series = new Series();
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Cantidad autos vendidos");
                int suma = 0;
                int sumatotal = 0;


                for (int d = Desde; d <= Hasta; d++)
                {
                    series = chart1.Series.Add(d.ToString());
                    foreach (ListViewItem a in listView1.CheckedItems)
                    {
                        foreach (DataRow filaVentas in tablaVentas.Rows)
                        {
                            if (Convert.ToInt32(a.Tag) == Convert.ToInt32(filaVentas["vendedor"]) && d == Convert.ToInt32(filaVentas["aa"]))
                            {
                                suma = suma + Convert.ToInt32(filaVentas["cantidad"]);
                                sumatotal = sumatotal + Convert.ToInt32(filaVentas["cantidad"]);
                            }
                        }
                        series.Points.AddXY(a.Text, suma);
                        suma = 0;
                    }
                }
                toolStripStatusLabel1.Text = "Cantidad de autos vendidos: " + sumatotal;
            }
            else
            {
                MessageBox.Show("ingrese todos los datos");
            }
            
            
            
        }
    }
}
