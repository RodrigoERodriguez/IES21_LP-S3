using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryRodriguezLP3_TrabajoPracticoEncuestas
{
    internal class clsLocalidades
    {
        //======================================================================================================
        //Establezco los elementos a utilizar
        //======================================================================================================

        private OleDbConnection Conector;
        private OleDbCommand Comando;
        private OleDbDataAdapter Adaptador;
        private DataTable Tabla;

        //======================================================================================================
        //Declaro las variables
        //======================================================================================================

        private string NombreDeLocalidad;
        private int IDLocalidad;

        public string Localidad
        {
            get { return NombreDeLocalidad; }
            set { NombreDeLocalidad = value; }
        }

        public Int32 IDLoc
        {
            get { return IDLocalidad; }
            set { IDLocalidad = value; }
        }

        //======================================================================================================
        //Creo un construcctor y establezco los elementos a usar
        //======================================================================================================

        public clsLocalidades()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=TP.mdb";
            Conector = new OleDbConnection(cadena);
            Comando = new OleDbCommand();

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Localidades";

            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = Tabla.Columns["localidad"];
            Tabla.PrimaryKey = dc;
        }

        //======================================================================================================
        //Realizamos la busqueda de la localidad
        //======================================================================================================

        public string BuscarLocalidad(int Localidad)
        {
            DataRow Buscador = Tabla.Rows.Find(Localidad);

            if (Buscador != null)
            {
                NombreDeLocalidad = Buscador[1].ToString();
            }
            else
            {
                NombreDeLocalidad = "";
            }

            return NombreDeLocalidad;
        }

        //======================================================================================================
        //Retornamos la tabla virtual
        //======================================================================================================

        public DataTable getAll()
        {
            return Tabla;
        }

        //======================================================================================================
        //Envio los elementos de la tabla al combobox
        //======================================================================================================

        public void ListarLocalidades(System.Windows.Forms.ComboBox CB)
        {
            CB.DisplayMember = "nombre";
            CB.ValueMember = "localidad";
            CB.DataSource = Tabla;
        }

        //======================================================================================================
        //Realizamos el registro de una nueva localidad
        //======================================================================================================

        public void RegistroDeLocalidad()
        {
            DataRow BuscarFila = Tabla.Rows.Find(IDLocalidad);

            if (BuscarFila == null)
            {
                DataRow Fila = Tabla.NewRow();
                Fila["localidad"] = IDLocalidad;
                Fila["nombre"] = NombreDeLocalidad;
                Tabla.Rows.Add(Fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(Adaptador);
                Adaptador.Update(Tabla);
            }
            else
            {
                IDLocalidad = 0;
                NombreDeLocalidad = "";
            }
        }

        public void Buscar(Int32 IDLocalidadBuscada)
        {
            try
            {
                Conector.Open();
                OleDbDataReader Lector = Comando.ExecuteReader();

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == IDLocalidadBuscada)
                        {
                            IDLocalidad = Lector.GetInt32(0);
                        }
                    }
                }
                Conector.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}

