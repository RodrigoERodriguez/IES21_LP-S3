using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezLP_Clase03_04
{
    public partial class Form1 : Form
    {
        Paises P = new Paises();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P.pais = Convert.ToInt32(txtNumero.Text);
            P.nombre = txtNombre.Text;
            P.capital = txtCapital.Text;
            P.Grabar();

            if (P.pais == 0)
            {
                MessageBox.Show("Pais repetido");
            }
            else
            {
                txtNumero.Text = "";
                txtNombre.Text = "";
                txtCapital.Text = "";
                txtNumero.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                P.pais = Convert.ToInt32(txtNumero.Text);
                P.Buscar();
                if (P.pais == 0)
                {
                    MessageBox.Show("El pais no se encuentra en la base de datos");
                }
                else
                {
                    txtNombre.Text = P.nombre;
                    txtCapital.Text = P.capital;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = P.getAll();
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P.pais = Convert.ToInt32(txtNumero.Text);
            P.Eliminar();
            txtNumero.Text = "";
            txtNombre.Text = "";
            txtCapital.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                P.pais = Convert.ToInt32(txtNumero.Text);
                P.Modificar();

                if (P.pais == 0)
                {
                    MessageBox.Show("Pais no se encuentra");
                }
                else
                {
                    P.nombre = txtNombre.Text;
                    P.capital = txtCapital.Text;
                    txtNumero.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero", "Error");
            }
            //Siempre se va a ejecutar
            finally
            {
                MessageBox.Show("Nose que hace esto");
            }
        }
    }
}
