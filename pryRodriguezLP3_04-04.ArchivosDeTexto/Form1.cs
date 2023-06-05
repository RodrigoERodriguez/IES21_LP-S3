using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRodriguezLP_Clase04_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //False = Un dato por archivo
            //True = Varios dato por archivo
            StreamWriter sw = new StreamWriter("LaDocta.txt", false);
            //WriteLine = hace salto de linea
            //Write = no lo hace
            sw.WriteLine("Hola");
            //Cierra el archivo
            sw.Close();
            //Elimina los objetos en memoria
            sw.Dispose();
        }

        private void btnElBoton_Click(object sender, EventArgs e)
        {
            string[] Frutas = { "Manzana", "Pera", "Naranja", "Banana" };
            StreamWriter sw = new StreamWriter("LaDoctaVerduras.txt", false);
            //Sirve para recorrer una coleccion
            //Coleccion = Vector
            foreach (string fruta in Frutas)
            {
                MessageBox.Show(fruta);
                sw.WriteLine(fruta);
            }

            sw.Close();
            sw.Dispose();
        }

        private void btnElBotonMejorado_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("LaDocta.txt");
            string Linea = "";
            //Dice cuando llega a fin de archivo    
            while (sr.EndOfStream != true)
            {
                Linea = sr.ReadLine();
                MessageBox.Show(Linea);
            }
            sr.Close();
            sr.Dispose();
        }
    }
}
