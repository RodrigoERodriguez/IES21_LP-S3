using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Design;
using System.Collections;


namespace pryRodriguezED_EstructuraDeDatos
{
    internal class clsArbolBinario
    {
        private clsNodo Inicio;

        //==============================================================================================================

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        //==============================================================================================================

        //Procedimiento AGREGAR
        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;//No tiene datos en Izquierdo
            Nvo.Derecho = null;//No tiene datos en Derecho

            if (Raiz == null)//Si no tengo nada en la raiz
                             //le asigno un nuevo valor
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;//Nodo padre = De donde se ramifican los numeros mayores y menores
                clsNodo Aux = Raiz;

                while (Aux != null)//Mientras la Raiz tenga un valor dentro
                                   //dependiendo del valor ingresado se ramifica
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo <= Aux.Codigo)//Si es menor a la raiz, va a la Izq
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else//Sino va a la Der
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nvo.Codigo <= NodoPadre.Codigo)//Afuera del while (Consultar el porque)
                {
                    NodoPadre.Izquierdo = Nvo;//Enlaza el anterior con el nuevo
                }
                else
                {
                    NodoPadre.Derecho = Nvo;//Enlaza el anterior con el nuevo
                }
            }
        }

        //==============================================================================================================
        //Estos procedimientos permiten que se me cargue la informacion en una grilla
        //un combo,una listbox, en treeview y que me cargue los datos en un .CSV
        //==============================================================================================================

        //ListBox
        public void RecorrerInOrdenAsc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void RecorrerInOrdenDesc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDesc(Lista, Raiz);
        }

        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }

        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }

        //ComboBox
        public void RecorrerInOrdenAsc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void RecorrerInOrdenDesc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDesc(Combo, Raiz);
        }

        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }

        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }

        //GridView
        public void RecorrerInOrdenAsc(DataGridView DataGrid)
        {
            DataGrid.Rows.Clear();
            InOrdenAsc(DataGrid, Raiz);
        }

        public void RecorrerInOrdenDesc(DataGridView DataGrid)
        {
            DataGrid.Rows.Clear();
            InOrdenDesc(DataGrid, Raiz);
        }

        public void RecorrerPreOrden(DataGridView DataGrid)
        {
            DataGrid.Rows.Clear();
            PreOrden(DataGrid, Raiz);
        }

        public void RecorrerPostOrden(DataGridView DataGrid)
        {
            DataGrid.Rows.Clear();
            PostOrden(DataGrid, Raiz);
        }

        //.CSV
        public void RecorrerInOrdenAsc(String NomArchivo)
        {
            StreamWriter Ad = new StreamWriter(NomArchivo, false);
            Ad.Write("Listado del arbol - InOrden Descendente\n");
            Ad.Write("Codigo ; Nombre ; Tramite\n");
            Ad.Close();
            GrabarInOrdenAsc(NomArchivo, Raiz);
        }

        public void RecorrerInOrdenDesc(String NomArchivo)
        {
            StreamWriter Ad = new StreamWriter(NomArchivo, false);
            Ad.Write("Listado del arbol - InOrden Ascendente\n");
            Ad.Write("Codigo ; Nombre ; Tramite\n");
            Ad.Close();
            GrabarInOrdenDesc(NomArchivo, Raiz);
        }

        public void RecorrerPreOrden(String NomArchivo)
        {
            StreamWriter Ad = new StreamWriter(NomArchivo, false);
            Ad.Write("Listado del arbol - PreOrden\n");
            Ad.Write("Codigo ; Nombre ; Tramite\n");
            Ad.Close();
            GrabarIPreOrden(NomArchivo, Raiz);
        }

        public void RecorrerPostOrden(String NomArchivo)
        {
            StreamWriter Ad = new StreamWriter(NomArchivo, false);
            Ad.Write("Listado del arbol - PostOrden\n");
            Ad.Write("Codigo ; Nombre ; Tramite\n");
            Ad.Close();
            GrabarIPostOrden(NomArchivo, Raiz);
        }

        //TreeView
        public void RecorrerTreeView(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            TreeviewInOrdenAsc(TreeView.Nodes, Raiz);
        }

        //==============================================================================================================
        //LISTBOXS
        //==============================================================================================================

        //InOrden
        public void InOrdenAsc(ListBox Lista, clsNodo Raiz)//Ascendente
        {
            if (Raiz.Izquierdo != null) InOrdenAsc(Lista, Raiz.Izquierdo);//I
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);//R
            if (Raiz.Derecho != null) InOrdenAsc(Lista, Raiz.Derecho);//D
        }


        public void InOrdenDesc(ListBox Lista, clsNodo Raiz)//Descendente
        {
            if (Raiz.Derecho != null) InOrdenDesc(Lista, Raiz.Derecho);//D
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);//R
            if (Raiz.Izquierdo != null) InOrdenDesc(Lista, Raiz.Izquierdo);//I
        }

        //PreOrden
        public void PreOrden(ListBox Lista, clsNodo Raiz)
        {
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);//R
            if (Raiz.Izquierdo != null) PreOrden(Lista, Raiz.Izquierdo);//I
            if (Raiz.Derecho != null) PreOrden(Lista, Raiz.Derecho);//D
        }

        //PostOrden 
        public void PostOrden(ListBox Lista, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) PostOrden(Lista, Raiz.Izquierdo);//I
            if (Raiz.Derecho != null) PostOrden(Lista, Raiz.Derecho);//D
            Lista.Items.Add(Raiz.Codigo + " " + Raiz.Nombre + " " + Raiz.Tramite);//R
        }

        //==============================================================================================================
        //COMBOBOX
        //==============================================================================================================

        //InOrden
        public void InOrdenAsc(ComboBox Combo, clsNodo Raiz)//Ascendente
        {
            if (Raiz.Izquierdo != null) InOrdenAsc(Combo, Raiz.Izquierdo);//I
            Combo.Items.Add(Raiz.Codigo);//R
            if (Raiz.Derecho != null) InOrdenAsc(Combo, Raiz.Derecho);//D
        }

        public void InOrdenDesc(ComboBox Combo, clsNodo Raiz)//Descendente
        {
            if (Raiz.Derecho != null) InOrdenDesc(Combo, Raiz.Derecho);//D
            Combo.Items.Add(Raiz.Codigo);//R
            if (Raiz.Izquierdo != null) InOrdenDesc(Combo, Raiz.Izquierdo);//I
        }

        //PreOrden
        public void PreOrden(ComboBox Combo, clsNodo Raiz)
        {
            Combo.Items.Add(Raiz.Codigo);//R
            if (Raiz.Izquierdo != null) PreOrden(Combo, Raiz.Izquierdo);//I
            if (Raiz.Derecho != null) PreOrden(Combo, Raiz.Derecho);//D
        }

        //PostOrden
        public void PostOrden(ComboBox Combo, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) PostOrden(Combo, Raiz.Izquierdo);//I
            if (Raiz.Derecho != null) PostOrden(Combo, Raiz.Derecho);//D
            Combo.Items.Add(Raiz.Codigo);//R
        }

        //==============================================================================================================
        ////DATAGRIDVIEW
        //==============================================================================================================

        //InOrden
        public void InOrdenAsc(DataGridView DataGrid, clsNodo Raiz)//Ascendente
        {
            if (Raiz.Izquierdo != null) InOrdenAsc(DataGrid, Raiz.Izquierdo);//I
            DataGrid.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);//R
            if (Raiz.Derecho != null) InOrdenAsc(DataGrid, Raiz.Derecho);//D
        }

        public void InOrdenDesc(DataGridView DataGrid, clsNodo Raiz)//Descendente
        {
            if (Raiz.Derecho != null) InOrdenDesc(DataGrid, Raiz.Derecho);//D
            DataGrid.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);//R
            if (Raiz.Izquierdo != null) InOrdenDesc(DataGrid, Raiz.Izquierdo);//I
        }

        //PreOrden
        public void PreOrden(DataGridView DataGrid, clsNodo Raiz)
        {
            DataGrid.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);//R
            if (Raiz.Izquierdo != null) PreOrden(DataGrid, Raiz.Izquierdo);//I
            if (Raiz.Derecho != null) PreOrden(DataGrid, Raiz.Derecho);//D
        }

        //PostOrden
        public void PostOrden(DataGridView DataGrid, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) PostOrden(DataGrid, Raiz.Izquierdo);//I
            if (Raiz.Derecho != null) PostOrden(DataGrid, Raiz.Derecho);//D
            DataGrid.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);//R
        }

        //==============================================================================================================
        //ARCHIVO .CSV
        //==============================================================================================================
        public void GrabarInOrdenAsc(String NomArchivo, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) GrabarInOrdenAsc(NomArchivo, Raiz.Izquierdo);
            StreamWriter ad = new StreamWriter(NomArchivo, true);
            ad.Write(Raiz.Codigo);
            ad.Write(" ; " + "");
            ad.Write(Raiz.Nombre);
            ad.Write(" ; " + "");
            ad.Write(Raiz.Tramite);
            ad.Write("\n");
            ad.Close();
            if (Raiz.Derecho != null) GrabarInOrdenAsc(NomArchivo, Raiz.Derecho);
        }

        public void GrabarInOrdenDesc(String NomArchivo, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) GrabarInOrdenAsc(NomArchivo, Raiz.Derecho);
            StreamWriter ad = new StreamWriter(NomArchivo, true);
            ad.Write(Raiz.Codigo);
            ad.Write(" ; " + "");
            ad.Write(Raiz.Nombre);
            ad.Write(" ; " + "");
            ad.Write(Raiz.Tramite);
            ad.Write("\n");
            ad.Close();
            if (Raiz.Derecho != null) GrabarInOrdenAsc(NomArchivo, Raiz.Izquierdo);
        }

        public void GrabarIPreOrden(String NomArchivo, clsNodo Raiz)
        {
            StreamWriter ad = new StreamWriter(NomArchivo, true);
            ad.Write(Raiz.Codigo);
            ad.Write(" ; " + "");
            ad.Write(Raiz.Nombre);
            ad.Write(" ; " + "");
            ad.Write(Raiz.Tramite);
            ad.Write("\n");
            ad.Close();
            if (Raiz.Derecho != null) GrabarInOrdenAsc(NomArchivo, Raiz.Izquierdo);
            if (Raiz.Izquierdo != null) GrabarInOrdenAsc(NomArchivo, Raiz.Derecho);
        }

        public void GrabarIPostOrden(String NomArchivo, clsNodo Raiz)
        {
            if (Raiz.Derecho != null) GrabarInOrdenAsc(NomArchivo, Raiz.Izquierdo);
            if (Raiz.Izquierdo != null) GrabarInOrdenAsc(NomArchivo, Raiz.Derecho);
            StreamWriter ad = new StreamWriter(NomArchivo, true);
            ad.Write(Raiz.Codigo);
            ad.Write(" ; " + "");
            ad.Write(Raiz.Nombre);
            ad.Write(" ; " + "");
            ad.Write(Raiz.Tramite);
            ad.Write("\n");
            ad.Close();
        }

        //==============================================================================================================
        //AGREGAR ARBOL
        //==============================================================================================================

        private void TreeviewInOrdenAsc(TreeNodeCollection NodoPadre, clsNodo Raiz)
        {
            if (Raiz != null)
            {
                TreeNode NodoNuevo = NodoPadre.Add(Raiz.Codigo.ToString());
                if (Raiz.Izquierdo != null) TreeviewInOrdenAsc(NodoNuevo.Nodes, Raiz.Izquierdo);
                if (Raiz.Derecho != null) TreeviewInOrdenAsc(NodoNuevo.Nodes, Raiz.Derecho);
            }
        }

        //==============================================================================================================
        //FUNCION EQUILIBRAR
        //==============================================================================================================

        public clsNodo[] Nodos = new clsNodo[100];//Creo un vector para almacenar el contenido de mi arbol
                                                   //Hacerlo DINAMICO

        public Int32 i = 0;//Declaro un indice para recorrer el vector

        public void Equilibrar()//
        {
            i = 0;
            CargarVectorInOrden(Raiz);//
            Raiz = null;
            EquilibrarArbol(0, i - 1);//
        }

        public void CargarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrden(NodoPadre.Izquierdo);//
            }
            Nodos[i] = NodoPadre;
            i++;
            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrden(NodoPadre.Derecho);//
            }
        }

        public void EquilibrarArbol(Int32 Inicio, Int32 Fin)
        {
            Int32 Medio = (Inicio + Fin) / 2;//Declaro una variable para poder encontrar el medio del vector

            if (Inicio <= Fin)
            {
                Agregar(Nodos[Medio]);//
                EquilibrarArbol(Inicio, Medio - 1);//
                EquilibrarArbol(Medio + 1, Fin);//
            }
        }

        //==============================================================================================================
        //ELIMINACION NODO
        //==============================================================================================================

        public void Eliminar(int Nodo)//
        {
            clsNodo NodoEliminar = Raiz;
            i = 0;
            CargarVectorEliminar(NodoEliminar, Nodo);//
            Raiz = null;
            if (i > 0)
            {
                EquilibrarArbol(0, i - 1);//
            }
        }

        public void CargarVectorEliminar(clsNodo NodoPadre, int Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorEliminar(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Nodos[i] = NodoPadre;
                i++;
            }
            if (NodoPadre.Derecho != null)
            {
                CargarVectorEliminar(NodoPadre.Derecho, Codigo);
            }

        }

        //==============================================================================================================
        //BUSQUEDA NODO
        //==============================================================================================================

        public void Buscar(Int32 Codigo)
        {
            clsNodo aux = Raiz;
            while (aux != null && aux.Codigo != Codigo)
            {
                if (Codigo < aux.Codigo)
                {
                    aux = aux.Izquierdo;
                }
                else
                {
                    aux = aux.Derecho;
                }
            }
        }
    }
}

