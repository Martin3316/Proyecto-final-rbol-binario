using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol
{
    internal class cola
    {
        private nodo_lista_pila_cola inicio;
        private int count = 0;
        private int MAX;

        public cola(int MAX)
        {
            this.MAX = MAX;
            inicio = null;
        }

        private bool underflow()
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

        private bool overflow()
        {
            if (count == MAX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (underflow())
            {
                Console.WriteLine("La cola esta vacia");
                Console.WriteLine("_________________________");
            }
            else
            {
                nodo_lista_pila_cola actual = inicio;

                while (actual != null)
                {
                    Console.WriteLine(actual.Valor);
                    actual = actual.Sig;
                }
            }

        }
        public int Count()
        {
            Console.WriteLine($"El tamaño de la cola es: {count}");
            return count;
        }

        public bool Insert(int num)
        {
            //regresa true al insertar exitosamente
            //regresa false si la cola esta llena y no se pudo insertar
            if (overflow())
            {
                Console.WriteLine("La cola esta llena");
                Console.WriteLine("_________________________");
                return false;
            }

            nodo_lista_pila_cola nuevo = new nodo_lista_pila_cola(num);

            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                nodo_lista_pila_cola act = inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
            }

            count++;

            return true;
        }

        public int Extract()
        {
            //regresa el valor extraido de la cola
            //si la cola esta vacia regresa -1 porque no puedo extraerla
            if (underflow())
            {
                Console.WriteLine("La cola esta vacia");
                Console.WriteLine("_________________________");
                return -1;
            }

            nodo_lista_pila_cola actual = inicio;
            int valor_guardado = actual.Valor;
            inicio = inicio.Sig;
            Console.WriteLine($"Se elimino el {actual.Valor}");
            actual.Sig = null;
            actual = null;

            count--;

            return valor_guardado;

        }

    }
}
