using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezLP3_Agricultura
{
    public partial class Form1 : Form
    {
        Localidades objLocalidades;
        Cultivos objCultivos;
        Produccion objProduccion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objProduccion = new Produccion();
                CBCultivoA.SelectedValue = "";
                CBLocalidadA.SelectedValue = "";
                objLocalidades = new Localidades();
                objLocalidades.Mostrar(CBLocalidadA);
                objLocalidades.MostrarList(LBLocalidad);
                objCultivos = new Cultivos();
                objCultivos.Mostrar(CBCultivoA);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la bse de datos");
                this.Close();
            }
        }

        private void TPGraficos_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {      
            bool valor = objProduccion.Actualizar((int)CBLocalidadA.SelectedValue, (int)CBCultivoA.SelectedValue, Convert.ToInt32(txtToneladasA.Text));

            if (valor == true)
            {
                txtToneladasA.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
