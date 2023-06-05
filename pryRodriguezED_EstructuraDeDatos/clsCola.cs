using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezED_EstructuraDeDatos
{
    internal class clsCola
    {
        //==============================================================================================================
        //En el procedimiento COLA se borra el primero en llegar a nuestro sistema
        //==============================================================================================================

        public clsNodo Primero;
        public clsNodo Ultimo;

        //==============================================================================================================
        //Procedimiento AGREGAR
        //==============================================================================================================

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)//Verifica si primero es nulo, en caso 
                                //de serlo, le asigna el valor ingresado a ambos
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else//Si ya existe un valor, hacemos que Ultimo.Siguiente tome el valor de nuevo
                //y Ultimo tome el valor del nuevo valor
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        //==============================================================================================================
        //Procedimiento ELIMINAR
        //==============================================================================================================

        public void Eliminar()
        {
            if (Primero == Ultimo)//Si el primero es igual a ultimo le 
                                  //asignamos valor nulo a ambos
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;//Primero va a tomar el valor del
                                            //proximo numero en eliminarse
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
