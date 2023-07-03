using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace pryRepasoPreFinal
{
    internal class clsDatos
    {
        public DataTable getData(string sql)
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, Properties.Settings.Default.CADENA);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
    }
}
