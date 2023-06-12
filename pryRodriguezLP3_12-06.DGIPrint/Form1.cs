using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezLP3_12_06.DGIPrint
{
    public partial class Form1 : Form
    {
        clsGente G;
        DataTable Tabla;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PPD.ShowDialog();
        }

        private void PD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Se genera cuando quiero escribir en una hoja
            //e.Graphics.FillEllipse(Brushes.Blue, 40, 40, 250, 250);
            Font f1 = new Font("Courier new", 30);
            int i = 0;
            int y = 40;
            int x = 40;
            while (i<10)
            {
                e.Graphics.DrawString("Vamos maTador", f1, Brushes.Black, 40, 40);
                y = y + f1.Height;
                i++;
            }
            //Genera hojas nuevas en estado true
            //NO genera hojas nuevas en estado false
            //e.HasMorePages
        }

        private void PD_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Se ejecuta una vez cuando comienza la impresion
            
        }

        private void PD_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Se ejecuta una vez cuando termina la impresion
        }

        private void PD_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {

        }
    }
}
