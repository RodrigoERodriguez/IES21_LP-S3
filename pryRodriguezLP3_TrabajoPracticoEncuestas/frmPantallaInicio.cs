using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryRodriguezLP3_TrabajoPracticoEncuestas
{
    public partial class frmPantallaInicio : Form
    {
        //======================================================================================================
        clsEncuestas Encuestas;
        clsLocalidades Localidades;
        clsProfesiones Profesiones;
        //======================================================================================================

        public frmPantallaInicio()
        {
            InitializeComponent();
        }

        //===========================================================================================
        //Corresponden al TabPage RESULTADOS
        //===========================================================================================

        private void frmPantallaInicio_Load(object sender, EventArgs e)
        {
            try
            {
                tHoraYFecha.Enabled = true;

                dgvEncuestas.Columns.Add("Localidades", "Localidades");

                Localidades = new clsLocalidades();
                Profesiones = new clsProfesiones();
                Encuestas = new clsEncuestas();

                DataTable tablaProfesiones = Profesiones.getAll();
                DataTable tablaLocalidades = Localidades.getAll();
                DataTable tablaEncuestas = Encuestas.getAll();

                foreach (DataRow dr in tablaProfesiones.Rows)
                {
                    dgvEncuestas.Columns.Add("Profesion", dr.ItemArray[1].ToString());
                }
                foreach (DataRow dr in tablaLocalidades.Rows)
                {
                    dgvEncuestas.Rows.Add(dr.ItemArray[1].ToString());
                }

                foreach (DataRow dr in tablaEncuestas.Rows)
                {
                    string varLocalidad = Localidades.BuscarLocalidad(Convert.ToInt32(dr.ItemArray[0]));
                    string varProfesion = Profesiones.BuscarProfesion(Convert.ToInt32(dr.ItemArray[1]));

                    foreach (DataGridViewTextBoxColumn dcGrilla in dgvEncuestas.Columns)
                    {
                        if (varProfesion == dcGrilla.HeaderText)
                        {
                            int posicionColumna = dcGrilla.Index;

                            foreach (DataGridViewRow drGrilla in dgvEncuestas.Rows)
                            {
                                if (varLocalidad == drGrilla.Cells[0].Value.ToString())
                                {
                                    int posicionFila = drGrilla.Index;
                                    dgvEncuestas.Rows[posicionFila].Cells[posicionColumna].Value = dr["cantidad"];
                                }
                            }
                        }
                    }

                    dgvEncuestas.AutoResizeColumns();
                    dgvEncuestas.AutoResizeRows();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            Profesiones.ListarProfesiones(cbProfesion);
            Localidades.ListarLocalidades(cbLocalidad);

            cbProfesion.SelectedIndex = -1;
            cbLocalidad.SelectedIndex = -1;
        }

        //======================================================================================================
        //Corresponden al tabpage de Registro
        //======================================================================================================

        private void btnAgregarLocalidad_Click(object sender, EventArgs e)
        {
            try
            {
                Localidades = new clsLocalidades();
                Int32 IDLocalidadBuscada = Convert.ToInt32(txtIDLocalidad.Text);

                Localidades.Buscar(IDLocalidadBuscada);

                if (Localidades.IDLoc == IDLocalidadBuscada)
                {
                    MessageBox.Show("El ID ingresado ya existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Localidades.Localidad = txtNombreLocalidad.Text;
                    Localidades.IDLoc = Convert.ToInt32(txtIDLocalidad.Text);
                    Localidades.RegistroDeLocalidad();
                    
                    Localidades.ListarLocalidades(cbLocalidad);
                    cbLocalidad.SelectedIndex = -1;//Si no pongo esto se selecciona un item luego de cargar la info

                    txtNombreLocalidad.Text = "";
                    txtIDLocalidad.Text = "";
                    txtIDLocalidad.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregarProfesion_Click(object sender, EventArgs e)
        {
            try
            {
                Profesiones = new clsProfesiones();
                Int32 IDProfesionBuscada = Convert.ToInt32(txtIDProfesion.Text);
                Profesiones.Buscar(IDProfesionBuscada);

                Profesiones.Buscar(IDProfesionBuscada);
                if (Profesiones.IdProf == IDProfesionBuscada)
                {
                    MessageBox.Show("El ID ingresado ya existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Profesiones.Profesion = txtNombreProfesion.Text;
                    Profesiones.IdProf = Convert.ToInt32(txtIDProfesion.Text);
                    Profesiones.RegistroProfesion();

                    Profesiones.ListarProfesiones(cbProfesion);
                    cbProfesion.SelectedIndex = -1;//Si no pongo esto se selecciona un item luego de cargar la info

                    txtNombreProfesion.Text = "";
                    txtIDProfesion.Text = "";
                    txtIDProfesion.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CheckProfesiones()
        {
            if (txtNombreProfesion.Text != "" && txtIDProfesion.Text != "")
            {
                btnAgregarProfesion.Enabled = true;
            }
            else
            {
                btnAgregarProfesion.Enabled = false;
            }
        }

        private void CheckLocalidades()
        {
            if (txtNombreLocalidad.Text != "" && txtIDLocalidad.Text != "")
            {
                btnAgregarLocalidad.Enabled = true;
            }
            else
            {
                btnAgregarLocalidad.Enabled = false;
            }
        }

        private void txtIDLocalidad_TextChanged(object sender, EventArgs e)
        {
            CheckLocalidades();
        }

        private void txtNombreLocalidad_TextChanged(object sender, EventArgs e)
        {
            CheckLocalidades();
        }

        private void txtIDProfesion_TextChanged(object sender, EventArgs e)
        {
            CheckProfesiones();
        }

        private void txtNombreProfesion_TextChanged(object sender, EventArgs e)
        {
            CheckProfesiones();
        }

        private void txtIDLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombreLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres alfabeticos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtIDProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombreProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres alfabeticos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //======================================================================================================
        //Corresponden al tabpage de AGREGAR
        //======================================================================================================

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Encuestas = new clsEncuestas();

                bool valor = Encuestas.Registrar((int)cbLocalidad.SelectedValue, (int)cbProfesion.SelectedValue, Convert.ToInt32(txtCantidad.Text));

                if (valor == true)
                {
                    txtCantidad.Text = "";
                    cbProfesion.SelectedIndex = -1;
                    cbLocalidad.SelectedIndex = -1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CheckCargaEncuestas()
        {
            if (txtCantidad.Text != "" && cbLocalidad.SelectedIndex > -1 && cbProfesion.SelectedIndex > -1)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void cbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCargaEncuestas();
        }

        private void cbProfesion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCargaEncuestas();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CheckCargaEncuestas();
        }

        private void tHoraYFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        //======================================================================================================
        //Corresponden al tabpage de RESULTADOS
        //======================================================================================================

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEncuestas.Rows.Clear();
                dgvEncuestas.Columns.Clear();

                dgvEncuestas.Columns.Add("Localidades", "Localidades");

                Localidades = new clsLocalidades();
                Profesiones = new clsProfesiones();
                Encuestas = new clsEncuestas();

                DataTable tablaProfesiones = Profesiones.getAll();
                DataTable tablaLocalidades = Localidades.getAll();
                DataTable tablaEncuestas = Encuestas.getAll();


                foreach (DataRow dr in tablaProfesiones.Rows)
                {
                    dgvEncuestas.Columns.Add("Profesion", dr.ItemArray[1].ToString());
                }
                foreach (DataRow dr in tablaLocalidades.Rows)
                {
                    dgvEncuestas.Rows.Add(dr.ItemArray[1].ToString());
                }

                foreach (DataRow dr in tablaEncuestas.Rows)
                {
                    string varLocalidad = Localidades.BuscarLocalidad(Convert.ToInt32(dr.ItemArray[0]));
                    string varProfesion = Profesiones.BuscarProfesion(Convert.ToInt32(dr.ItemArray[1]));

                    foreach (DataGridViewTextBoxColumn dcGrilla in dgvEncuestas.Columns)
                    {
                        if (varProfesion == dcGrilla.HeaderText)
                        {
                            int posicionColumna = dcGrilla.Index;

                            foreach (DataGridViewRow drGrilla in dgvEncuestas.Rows)
                            {
                                if (varLocalidad == drGrilla.Cells[0].Value.ToString())
                                {
                                    int posicionFila = drGrilla.Index;
                                    dgvEncuestas.Rows[posicionFila].Cells[posicionColumna].Value = dr["cantidad"];
                                }
                            }
                        }
                    }

                    dgvEncuestas.AutoResizeColumns();
                    dgvEncuestas.AutoResizeRows();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
