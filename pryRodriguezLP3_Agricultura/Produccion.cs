using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace pryRodriguezLP3_Agricultura
{
    internal class Produccion
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        public Produccion()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Produccion";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[2];
            dc[0] = tabla.Columns["localidad"];
            dc[1] = tabla.Columns["cultivo"];
            tabla.PrimaryKey = dc;
        }

        public Boolean Actualizar(int Localidad, int Cultivo, int Toneladas)
        {
            bool valor = true;
            object[] clave = new object[2];
            clave[0] = Localidad;
            clave[1] = Cultivo;
            DataRow FilaBuscada = tabla.Rows.Find(clave);

            if (FilaBuscada == null)
            {
                DataRow fila = tabla.NewRow();
                fila["localidad"] = Localidad;
                fila["cultivo"] = Cultivo;
                fila["toneladas"] = Toneladas;

                tabla.Rows.Add(fila);
                OleDbCommandBuilder OCB = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else
            {
                valor = false;
            }

             return valor; 
        }

        public void graficar(int Localidad, Chart Chart)
        {
            Cultivos Cultivo = new Cultivos();
            DataTable tl = Cultivo.GetTabla();

            Chart.Series.Clear();
            Series serie = Chart.Series.Add("Produccion");

            foreach (DataRow fl in tl.Rows)
            {
                object[] clave = new object[2];
                clave[0] = Localidad;
                clave[1] = fl["Cultivo"].ToString();

                int Toneladas = 0;
                DataRow fp = tabla.Rows.Find(clave);

                if (fp != null) Toneladas = (int)fp["toneladas"];

                serie.Points.AddXY(fl["nombre"], Toneladas);
            }
        }
    }
}
