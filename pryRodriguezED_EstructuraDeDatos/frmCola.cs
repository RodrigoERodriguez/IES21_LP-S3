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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        clsCola Cola = new clsCola();

        //==============================================================================================================

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();

            Nodo.Codigo = Convert.ToInt32(txtCodigoNE.Text);
            Nodo.Nombre = txtNombreNE.Text;
            Nodo.Tramite = txtTramiteNE.Text;

            Cola.Agregar(Nodo);
            Cola.Recorrer(dgvGrilla);
            Cola.Recorrer(lstListado);
            txtCodigoNE.Focus();
            Limpiar();
        }

        //==============================================================================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Cola.Primero != null)
            {

                lblCodigoInfo.Text = Cola.Primero.Codigo.ToString();
                lblNombreInfo.Text = Cola.Primero.Nombre;
                lblTramiteInfo.Text = Cola.Primero.Tramite;

                Cola.Eliminar();
                Cola.Recorrer(dgvGrilla);
                Cola.Recorrer(lstListado);

                txtCodigoNE.Focus();
            }
            else
            {
                MessageBox.Show("No se encontraron datos" , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                txtCodigoNE.Focus();
            }
        }

        //==============================================================================================================

        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        //==============================================================================================================

        private void Limpiar()
        {
            txtCodigoNE.Text = "";
            txtNombreNE.Text = "";
            txtTramiteNE.Text = "";
            lblCodigoInfo.Text = "";
            lblNombreInfo.Text = "";
            lblTramiteInfo.Text = "";
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
            }            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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
