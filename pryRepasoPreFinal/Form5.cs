using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRepasoPreFinal
{
    public partial class Form5 : Form
    {
        Graphics Grafiquito;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string[] sectores = { "Bebidas", "Papitas", "Verduras", "Fideos" };
            Grafiquito = pictureBox1.CreateGraphics();
            foreach (string sector in sectores)
            {
                comboBox1.Items.Add(sector);
            }
        }

        private void Form5_Activated(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x, y = 0;
            int sector = 0;
            Font fuente = new Font("Verdana", 12);
            for (y = 0; y < pictureBox1.Height; y = y + 200)
            {
                for (x = 0; x < pictureBox1.Width; x = x + 200)
                {
                    sector++;
                    Grafiquito.DrawRectangle(Pens.Black, x, y, 180, 180);
                    Grafiquito.DrawString(sector.ToString(), fuente, Brushes.Black, x + 50, y + 50);
                }
            }

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Grafiquito.FillRectangle(Brushes.Red, 0, 0, 180, 180);
                    Grafiquito.DrawString(sector.ToString(), fuente, Brushes.Black,50,50);
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}
