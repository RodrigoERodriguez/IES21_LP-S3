using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace pryRodriguezLP_Clase10_04
{
    class Medicos
    {
        private string Cadena = "";
        private OleDbConnection Conector;
        private OleDbCommand Comando; //Envia el comando a la base de datos
        private OleDbDataAdapter Adaptador; //Da la orden de hacer las acciones del
        private DataTable Tabla;

        public Medicos()
        {
            Cadena = "provider=microsoft.jet.oledb.4.0;data source=CLINICA.mdb";
            Conector = new OleDbConnection(Cadena);
            Comando = new OleDbCommand();

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Medicos";

            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);
        }
        public DataTable getAll()
        {
            return Tabla;
        }
    }
}
