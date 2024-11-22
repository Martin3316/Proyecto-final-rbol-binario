using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol
{
    internal class nodo_lista_pila_cola
    {
        private int valor;
        private nodo_lista_pila_cola sig;
        public nodo_lista_pila_cola(int valor)
        {
            this.Valor = valor;
            Sig = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal nodo_lista_pila_cola Sig { get => sig; set => sig = value; }
    }
}
