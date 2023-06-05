using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezED_EstructuraDeDatos
{
    internal class clsPila
    {
        //==============================================================================================================
        //En el procedimiento PILA se borra el ultimo en llegar a nuestro sistema
        //==============================================================================================================

        public clsNodo Primero;

        //==============================================================================================================
        //Procedimiento AGREGAR
        //==============================================================================================================

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)//Verifica si primero es nulo, en caso 
                                //de serlo, le asigna el valor ingresado
            {
                Primero = Nuevo;
            }
            else//Si ya existe un valor, hacemos que Nuevo.Siguiente tome el valor
                //de primero, y primero tome el valor ingresado
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }

        //==============================================================================================================
        //Procedimiento ELIMINAR
        //==============================================================================================================

        public void Eliminar()
        {
            if (Primero != null)//Verifica que primero sea diferente de nulo
                                //y lo borra
            {
                Primero = Primero.Siguiente;//Primero toma el valor del siguiente
                                            //es decir primero.siguiente
            }
        }

        //==============================================================================================================
        //Estos procedimientos permiten que se me cargue la informacion en una grilla
        //un combo y una listbox
        //==============================================================================================================

        public void Recorrer(DataGridView DataGrid)
        {
            clsNodo Aux = Primero;//Utilizo un puntero para definir el primero
            DataGrid.Rows.Clear();//Limpiamos las columnas

            while (Aux != null)
            {
                DataGrid.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo Aux = Primero;//Utilizo un puntero para definir el primero
            Lista.Items.Clear();//Limpiamos los items del list
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + " , " + Aux.Nombre + " , " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;//Utilizo un puntero para definir el primero
            Combo.Items.Clear();//Limpiamos los items del combo

            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
    }
}
