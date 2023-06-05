using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRodriguezLP_Clase17_04
{
    internal class clsConfiguration
    {
        //Al declararlo stactic lo puedo llamar en cualquier otra clase
        public static string GetCadena()
        {
            string Cadena = "provider=microsoft.jet.oledb.4.0;data source=YOUTUBE_MIGUEL.mdb";
            return Cadena;
        }
    }
}
