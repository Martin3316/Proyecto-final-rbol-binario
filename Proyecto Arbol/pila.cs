using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol
{
    internal class pila
    {
        private int MAX;
        private int tope = 0;
        private nodo_pila_cola inicio;

        public pila(int max)
        {
            MAX = max;
            inicio = null;
        }

        public bool Empty()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Full()
        {
            if (tope == MAX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void PrintStack()
        {
            //Imprime la pila
            if (Empty())
            {
                Console.WriteLine("La pila esta vacia");
                Console.WriteLine("_________________________");
            }
            else
            {
                nodo_pila_cola act = inicio;

                while (act != null)
                {
                    Console.WriteLine($"{act.Valor}");
                    act = act.Sig;
                }

            }
        }


        public bool Push(int num)
        {
            //regresa true si la insercion es exitosa
            //regresa false si la pila esta llena y no se inserto

            if (Full())
            {
                Console.WriteLine("La pila esta llena");
                return false;
            }
            else
            {
                nodo_pila_cola nuevo = new nodo_pila_cola(num);

                nuevo.Sig = inicio;

                inicio = nuevo;

                tope++;

                return true;

            }


        }


        public int Pop()
        {
            //regresa el numero sacado de la pila
            //si la pila esta vacia regresa -1

            if (Empty())
            {
                Console.WriteLine("La pila esta vacia");
                return -1;
            }

            nodo_pila_cola actual = inicio;
            int valor_guardado = actual.Valor;
            inicio = inicio.Sig;
            Console.WriteLine($"Salio el {actual.Valor}");
            actual.Sig = null;
            actual = null;
            tope--;

            return valor_guardado;
        }
    }
}
