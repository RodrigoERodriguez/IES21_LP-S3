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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            PersonalizarBotones();
        }

        //==============================================================================================================

        private void PersonalizarBotones()//Esconde los botones del submenu cuando 
                                          //inicializa el programa.
        {
            PSubMenuLineales.Visible = false;
            PSubMenuNoLineales.Visible = false;
            PSubMenuMas.Visible = false;
        }

        //==============================================================================================================

        private void EsconderSubMenu()//Oculta los Submenus y botones
        {
            if (PSubMenuLineales.Visible == true)
            {
                PSubMenuLineales.Visible = false;
            }

            if (PSubMenuNoLineales.Visible == true)
            {
                PSubMenuNoLineales.Visible = false;
            }

            if (PSubMenuMas.Visible == true)
            {
                PSubMenuMas.Visible = false;
            }
        }

        //==============================================================================================================
       
        private void MostrarSubMenu(Panel SubMenu)//Alternara la visibilidad del submenu
        {
            if (SubMenu.Visible == false)
            {
                EsconderSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
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

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        //==============================================================================================================
        
        //Botones del menu Lineales
        private void btnLineales_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuLineales);
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmPila());
            EsconderSubMenu();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmCola());
            EsconderSubMenu();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmLista());
            EsconderSubMenu();
        }

        //==============================================================================================================

        //Botones del menu NO Lineales
        private void btnNoLineales_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuNoLineales);
        }

        private void btnArbolBinario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmArbolBinario());
            EsconderSubMenu();
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {

        }

        //==============================================================================================================

        //Botones del Mas
        private void btnMas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PSubMenuMas);
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmSistema());
            EsconderSubMenu();
        }

    }
}
