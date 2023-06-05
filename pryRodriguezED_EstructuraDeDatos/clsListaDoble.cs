using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezED_EstructuraDeDatos
{
    internal class clsListaDoble
    {
        //==============================================================================================================
        //En el procedimiento LISTA SIMPLE se borra el valor que el usuario desee
        //==============================================================================================================

        public clsNodo PPrimero;
        public clsNodo PUltimo;

        //
        public clsNodo Primero
        {
            get { return PPrimero; }
            set { PPrimero = value; }
        }

        public clsNodo Ultimo
        {
            get { return PUltimo; }
            set { PUltimo = value; }
        }

        //==============================================================================================================
        //Procedimiento AGREGAR
        //==============================================================================================================

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)//Verifica si primero es nulo, en caso de serlo, 
                                //le asigna el valor ingresado a Primero y Ultimo
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)//
                {
                    Nuevo.Siguiente = Primero;//
                    Primero.Anterior = Nuevo;//
                    Primero = Nuevo;//
                }
                else
                {
                    if (Nuevo.Codigo >= Ultimo.Codigo)//
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        //Utilizo dos punteros para posicionarme y
                        //poder ingresar un dato intermedio
                        clsNodo Auxiliar = Primero;//Puntero Guia
                        clsNodo Anterior = Primero;//Toma el valor anterior del puntero AUX

                        while (Auxiliar.Codigo <= Nuevo.Codigo)
                        {
                            Anterior = Auxiliar;
                            Anterior = Auxiliar.Siguiente;

                            if (Auxiliar == null)
                            {
                                break;
                            }
                        }
                        Anterior.Siguiente = Nuevo;//
                        Nuevo.Siguiente = Auxiliar;//
                        Auxiliar.Anterior = Nuevo;//
                        Nuevo.Anterior = Anterior;//
                    }
                }
            }
        }

        //==============================================================================================================
        //Procedimiento ELIMINAR
        //==============================================================================================================

        public void Eliminar(Int32 Codigo)
        {            
            if (Primero.Codigo == Codigo && Ultimo == Primero)//Pregunta si hay un solo dato
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)//Si el codigo que selecciono es el primero
                {
                    Primero = Primero.Siguiente;//Primero toma el valor del siguiente
                    Primero.Anterior = null;//Rompe la cadena dandole valor nulo al anterior
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)//Si el codigo que selecciono es el ultimo
                    {
                        Ultimo = Ultimo.Anterior;//Ultimo toma el valor anterior
                        Ultimo.Siguiente = null;//Rompe la cadena dandole valor nulo al siguiente
                    }
                    else
                    {
                        clsNodo Auxiliar = Primero;//Toma el valor en el cual se encuentre
                        clsNodo Anterior = Primero;//Toma el valor anterior al puntero AUX

                        while (Auxiliar.Codigo != Codigo)
                        {
                            Anterior = Auxiliar;
                            Auxiliar = Auxiliar.Siguiente;
                        }
                        Auxiliar = Auxiliar.Siguiente;//Separo el auxiliar 1 posicion
                        Anterior.Siguiente = Auxiliar;//Anterior se une con la posicion del auxiliar
                        Auxiliar.Anterior = Anterior; //Auxiliar se une con la posicion del anterior
                    }
                }
            }
        }

        //==============================================================================================================
        //Estos procedimientos permiten que se me cargue la informacion en una grilla
        //un combo y una listbox de forma ASCENDENTE
        //==============================================================================================================

        public void Recorrer(DataGridView DataGrid)
        {
            clsNodo Auxiliar = Primero;
            DataGrid.Rows.Clear();

            while (Auxiliar != null)
            {
                DataGrid.Rows.Add(Auxiliar.Codigo, Auxiliar.Nombre, Auxiliar.Tramite);
                Auxiliar = Auxiliar.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo Auxiliar = Primero;
            Lista.Items.Clear();
            while (Auxiliar != null)
            {
                Lista.Items.Add(Auxiliar.Codigo + " , " + Auxiliar.Nombre + " , " + Auxiliar.Tramite);
                Auxiliar = Auxiliar.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Auxiliar = Primero;
            Combo.Items.Clear();
            while (Auxiliar != null)
            {
                Combo.Items.Add(Auxiliar.Nombre);
                Auxiliar = Auxiliar.Siguiente;
            }
        }

        //==============================================================================================================
        //Estos procedimientos permiten que se me cargue la informacion en una grilla
        //un combo y una listbox de forma DESCENDENTE
        //==============================================================================================================

        public void RecorrerDes(DataGridView DataGrid)
        {
            clsNodo Auxiliar = Ultimo;
            DataGrid.Rows.Clear();

            while (Auxiliar != null)
            {
                DataGrid.Rows.Add(Auxiliar.Codigo, Auxiliar.Nombre, Auxiliar.Tramite);
                Auxiliar = Auxiliar.Anterior;
            }
        }

        public void RecorrerDes(ListBox Lista)
        {
            clsNodo Auxiliar = Ultimo;
            Lista.Items.Clear();
            while (Auxiliar != null)
            {
                Lista.Items.Add(Auxiliar.Codigo + " , " + Auxiliar.Nombre + " , " + Auxiliar.Tramite);
                Auxiliar = Auxiliar.Anterior;
            }
        }

        public void RecorrerDes(ComboBox Combo)
        {
            clsNodo Auxiliar = Ultimo;
            Combo.Items.Clear();
            while (Auxiliar != null)
            {
                Combo.Items.Add(Auxiliar.Nombre);
                Auxiliar = Auxiliar.Anterior;
            }
        }
    }
}
