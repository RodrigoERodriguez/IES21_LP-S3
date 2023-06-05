using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezED_EstructuraDeDatos
{
    public partial class frmListasDobles : Form
    {
        public frmListasDobles()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        clsListaDoble ListaDoble= new clsListaDoble();

        //==============================================================================================================

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigoNE.Text);
            objNodo.Nombre = txtNombreNE.Text;
            objNodo.Tramite = txtTramiteNE.Text;

            ListaDoble.Agregar(objNodo);
            ListaDoble.Recorrer(dgvGrilla);
            ListaDoble.Recorrer(lstListado);
            ListaDoble.Recorrer(lstCodigo);
            txtCodigoNE.Focus();
            Limpiar();
        }

        //==============================================================================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDoble.Primero != null)
            {

                Int32 Codigo = Convert.ToInt32(lstCodigo.Text);

                ListaDoble.Eliminar(Codigo);
                ListaDoble.Recorrer(dgvGrilla);
                ListaDoble.Recorrer(lstListado);
                ListaDoble.Recorrer(lstCodigo);
                txtCodigoNE.Focus();
            }
            else
            {
                MessageBox.Show("No se encontraron datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                txtCodigoNE.Focus();
            }
        }

        //==============================================================================================================

        private void frmListasDobles_Load(object sender, EventArgs e)
        {
            lstCodigo.SelectionStart = 0;
        }

        //==============================================================================================================

        private void Limpiar()
        {
            txtCodigoNE.Text = "";
            txtNombreNE.Text = "";
            txtTramiteNE.Text = "";
            lstCodigo.SelectionStart = 0;
        }

        //==============================================================================================================
        private void Check()
        {
            if (txtCodigoNE.Text != "" & txtNombreNE.Text != "" & txtTramiteNE.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void CheckEliminar()
        {
            if (lstCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        //==============================================================================================================

        private void txtCodigoNE_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtNombreNE_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtTramiteNE_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)//Consultar
        {
            CheckEliminar();
        }

        //==============================================================================================================

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.Recorrer(dgvGrilla);
            ListaDoble.Recorrer(lstListado);
            ListaDoble.Recorrer(lstCodigo);
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.RecorrerDes(dgvGrilla);
            ListaDoble.RecorrerDes(lstListado);
            ListaDoble.RecorrerDes(lstCodigo);
        }

        //==============================================================================================================

        //Permite que solamente se ingresen numeros
        //en caso de que ingresen LETRAS muestra una alerta
        private void txtCodigoNE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombreNE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTramiteNE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
