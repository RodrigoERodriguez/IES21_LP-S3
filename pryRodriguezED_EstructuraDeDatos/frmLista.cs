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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        void abrirFormulario(Form form)//Llamo un formulario al panel central del programa
        {
            while (PCentral.Controls.Count > 0)//Va a borrar lo que este en el panel central
                                               //permitiendo asi que se abra otro formulario mas
            {
                PCentral.Controls.RemoveAt(index: 0);
            }
            Form formhijo = form;
            formhijo.TopLevel = false; //TopLevel es una propiedad nativa de los formularios
                                       //La cual deshabilitaremos
            formhijo.FormBorderStyle = FormBorderStyle.None; //Con esto saco el borde del formulario que llamo
            formhijo.Dock = DockStyle.Fill; //Ocupa todo el lugar del panel central

            PCentral.Controls.Add(formhijo);
            formhijo.Show();
        }

        //==============================================================================================================

        private void btnListaSimple_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListaSimple());
        }

        private void btnListaDoble_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListasDobles());
        }

        //==============================================================================================================

        private void frmLista_Load(object sender, EventArgs e)
        {

        }
    }
}
