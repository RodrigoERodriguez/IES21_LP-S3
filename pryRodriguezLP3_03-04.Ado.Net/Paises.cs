using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace pryRodriguezLP_Clase03_04
{
    internal class Paises
    {
        //
        private string Cadena = "provider=microsoft.jet.oledb.4.0;data source=MUNDO.mdb";
        private OleDbConnection Conector;
        private OleDbCommand Comando; //Envia el comando a la base de datos
        private OleDbDataAdapter Adaptador; //Da la orden de hacer las acciones del comando
        private DataTable Tabla;



        //
        private Int32 Pais;
        private string Nombre;
        private string Capital;

        public Int32 pais
        {
            get { return Pais; }
            set { Pais = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string capital
        {
            get { return Capital; }
            set { Capital = value; }
        }

        //Realizo el constructor
        public Paises()
        {
            Cadena = "provider=microsoft.jet.oledb.4.0;data source=MUNDO.mdb";
            Conector = new OleDbConnection(Cadena);
            Comando = new OleDbCommand();
            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;         
            Comando.CommandText = "Paises";
            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);

            //Cual es la clave principal de la tabla
            DataColumn[] Vector = new DataColumn[1];
            Vector[0] = Tabla.Columns["Pais"];
            Tabla.PrimaryKey = Vector;
        }

        public void Grabar()
        {
            DataRow filabusca = Tabla.Rows.Find(pais);
            if (filabusca is null)
            {
                DataRow fila = Tabla.NewRow();
                fila["Pais"] = pais;
                fila["Capital"] = capital;
                fila["Nombre"] = nombre;
                Tabla.Rows.Add(fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(Adaptador);
                Adaptador.Update(Tabla);
            }
            else
            {
                Pais = 0;
                Nombre = "";
                Capital = "";
            }
        }

        public void Buscar()
        {
            DataRow fila = Tabla.Rows.Find(Pais);
            if (fila is null)
            {
                Pais = 0;
                Nombre = "";
                Capital = "";
            }
            else
            {
                Pais = Convert.ToInt32(fila["Pais"]);
                Nombre = fila["Nombre"].ToString();
                Capital = fila["Capital"].ToString();

            }
        }

        public void Modificar()
        {
            DataRow filabuscar = Tabla.Rows.Find(pais);
            filabuscar.BeginEdit();
            filabuscar["Capital"] = nombre;

            filabuscar.EndEdit();
            OleDbCommandBuilder cb = new OleDbCommandBuilder(Adaptador);
            Adaptador.Update(Tabla);
        }

        public void Eliminar()
        {
            DataRow fila = Tabla.Rows.Find(pais);
            fila.Delete();
            OleDbCommandBuilder cb = new OleDbCommandBuilder(Adaptador);
            Adaptador.Update(Tabla);
        }

        public DataTable getAll()
        {
            return Tabla;
        }
    }
}
