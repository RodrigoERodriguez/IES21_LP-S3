using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRodriguezED_EstructuraDeDatos
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        string Recorrido;
        bool DireccionAsc;

        //==============================================================================================================

        clsArbolBinario ArbolBinario = new clsArbolBinario();

        //==============================================================================================================

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            Int32 Codigo = Convert.ToInt32(txtCodigoNE.Text);

           
            objNodo.Codigo = Convert.ToInt32(txtCodigoNE.Text);
            objNodo.Nombre = txtNombreNE.Text;
            objNodo.Tramite = txtTramiteNE.Text;

            ArbolBinario.Agregar(objNodo);

            ArbolBinario.RecorrerInOrdenAsc(dgvGrilla);
            ArbolBinario.RecorrerInOrdenAsc(lstListado);
            ArbolBinario.RecorrerInOrdenAsc(lstCodigo);
            ArbolBinario.RecorrerTreeView(TVArbolito);

            Limpiar();
            txtCodigoNE.Focus();
        }

        //==============================================================================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(lstCodigo.Text);
            ArbolBinario.Eliminar(Codigo);

            if (ArbolBinario.Raiz != null)
            {
                ArbolBinario.RecorrerInOrdenAsc(dgvGrilla);
                ArbolBinario.RecorrerInOrdenAsc(lstListado);
                ArbolBinario.RecorrerInOrdenAsc(lstCodigo);

                if (ArbolBinario.Raiz != null)
                {
                    ArbolBinario.Equilibrar();
                }

            }
            else
            {
                MessageBox.Show("No se encontro ningun dato", "Error");
            }

            txtCodigoNE.Focus();
        }

        //==============================================================================================================

        private void frmArbolBinario_Load(object sender, EventArgs e)
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //==============================================================================================================

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked == true)
            {
                mrcOrden.Enabled = true;
            }
            else
            {
                mrcOrden.Enabled = false;
            }
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (ArbolBinario.Raiz != null)
            {
                ArbolBinario.RecorrerPreOrden("./ParcialArbolBinarioPreOrden.CSV");

                ArbolBinario.RecorrerPreOrden(dgvGrilla);
                ArbolBinario.RecorrerPreOrden(lstListado);
                ArbolBinario.RecorrerPreOrden(lstCodigo);
                ArbolBinario.RecorrerTreeView(TVArbolito);

                MessageBox.Show("Archivo creado con exito", "Aviso");
            }
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (ArbolBinario.Raiz != null)
            {
                ArbolBinario.RecorrerPostOrden("./ParcialArbolBinarioPostOrden.CSV");

                ArbolBinario.RecorrerPostOrden(dgvGrilla);
                ArbolBinario.RecorrerPostOrden(lstListado);
                ArbolBinario.RecorrerPostOrden(lstCodigo);
                ArbolBinario.RecorrerTreeView(TVArbolito);
                TVArbolito.ExpandAll();

                MessageBox.Show("Archivo creado con exito", "Aviso");
            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (ArbolBinario.Raiz != null)
            {
                ArbolBinario.RecorrerInOrdenAsc("./ParcialArbolBinarioInOrdenAscendente.CSV");

                ArbolBinario.RecorrerInOrdenAsc(dgvGrilla);
                ArbolBinario.RecorrerInOrdenAsc(lstListado);
                ArbolBinario.RecorrerInOrdenAsc(lstCodigo);
                ArbolBinario.RecorrerTreeView(TVArbolito);
                TVArbolito.ExpandAll();

                MessageBox.Show("Archivo creado con exito", "Aviso");
            }
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (ArbolBinario.Raiz != null)
            {
                ArbolBinario.RecorrerInOrdenDesc("./ParcialArbolBinarioInOrdenDescendente.CSV");

                ArbolBinario.RecorrerInOrdenDesc(dgvGrilla);
                ArbolBinario.RecorrerInOrdenDesc(lstListado);
                ArbolBinario.RecorrerInOrdenDesc(lstCodigo);
                ArbolBinario.RecorrerTreeView(TVArbolito);
                TVArbolito.ExpandAll();

                MessageBox.Show("Archivo creado con exito", "Aviso");
            }
        }

        //==============================================================================================================

        private void TVArbolito_DoubleClick(object sender, EventArgs e)
        {

        }

        private void optAscendente_Click(object sender, EventArgs e)
        {

        }
    }
}
