using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezLP_Clase10_04
{
    public partial class frmPantallaPrincipal : Form
    {
        Especialidades Especialidades;
        Medicos Medicos;
        DataTable Tabla;

        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void lstEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEspecialidades.SelectedIndex > -1)
            {
                btnVer.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnVer.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            //El primero quiero que tenga el nombre de titulo
            //El segundo hago referencia a lo que programo
            dgvMedicos.Columns.Add("Matricula", "Matricula");
            dgvMedicos.Columns.Add("Nombre", "Nombre");
            dgvMedicos.Columns.Add("Celular", "Celular");

            try
            {
                Especialidades = new Especialidades();
                //Hace que me muestre el nombre de la especialidad
                lstEspecialidades.DisplayMember = "nombre";
                //Hace que retorne el valor nominal de la especialidad
                lstEspecialidades.ValueMember = "especialidad";
                lstEspecialidades.DataSource = Especialidades.getAll();

                Medicos = new Medicos();
                Tabla = Medicos.getAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos");
                this.Close();
            } 
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dgvMedicos.Rows.Clear();
            int Especialidad = Convert.ToInt32(lstEspecialidades.SelectedValue);

            foreach (DataRow fila in Tabla.Rows)
            {
                if (Convert.ToInt32(fila["especialidad"]) == Especialidad)
                {
                    dgvMedicos.Rows.Add(fila["matricula"], fila["nombre"], fila["celular"]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMedico f2 = new frmMedico();
            f2.ShowDialog();
        }
    }
}
