using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezED_EstructuraDeDatos
{
    internal class clsListaSimple
    {
        //==============================================================================================================
        //En el procedimiento LISTA SIMPLE se borra el valor que el usuario desee
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
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)//Si el valor nuevo es menor que el primero
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;//Puntero Guia
                    clsNodo Ant = Primero;//Toma el valor anterior del puntero AUX

                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        Ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }

                    Ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }
        }

        //==============================================================================================================
        //Procedimiento ELIMINAR
        //==============================================================================================================

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo aux = Primero;//Puntero Guia
                clsNodo Ant = Primero;//Toma el valor anterior del puntero AUX

                while (aux.Codigo != Codigo)
                {
                    Ant = aux;
                    aux = aux.Siguiente;

                    if (aux == null)
                    {
                        break;
                    }
                }

                Ant.Siguiente = aux.Siguiente;//
            }
        }

        //==============================================================================================================
        //Estos procedimientos permiten que se me cargue la informacion en una grilla
        //un combo y una listbox
        //==============================================================================================================

        public void Recorrer(DataGridView DataGrid)
        {
            clsNodo Aux = Primero;
            DataGrid.Rows.Clear();

            while (Aux != null)
            {
                DataGrid.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + " , " + Aux.Nombre + " , " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;
            Combo.Items.Clear();
            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
    }
}
