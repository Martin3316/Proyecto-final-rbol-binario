using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol
{
    internal class lista
    {
        nodo_lista_pila_cola inicio;

        public lista()
        {
            inicio = null;
        }

        public void Agregar(int num)
        {
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
        }

        public void Imprimir()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia.");
                Console.WriteLine("__________________________");
            }
            else
            {
                nodo_lista_pila_cola act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor} => ");
                    act = act.Sig;
                }
            }
        }


        public int Encontrar(int pos)
        {
            //regresa el valor que esta en la posicion indicada
            //si no encuentra la posicion o la lista esta vacia
            //regresa -1

            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return -1;
            }

            nodo_lista_pila_cola actual = inicio;
            int contador = 0;

            while (actual != null)
            {
                if (contador == pos)
                {
                    Console.WriteLine($"El valor del nodo en la posición {pos} es: {actual.Valor}");
                    return actual.Valor;
                }

                actual = actual.Sig;
                contador++;
            }

            Console.WriteLine("No se encontró la posición en la lista.");
            return -1;

        }


        public int Contar()
        {
            //regresa la cantidad de nodos de la lista
            int contador = 0;
            nodo_lista_pila_cola actual = inicio;

            while (actual != null)
            {
                contador++;
                actual = actual.Sig;
            }
            Console.WriteLine($"La cantidad de nodos es: {contador}");
            return contador;
        }


        public int EncontrarValor(int num)
        {
            //regresa la posicion que tiene el valor indicado
            //si no encuentra la posicion o la lista esta vacia
            //regresa -1
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return -1;
            }

            nodo_lista_pila_cola actual = inicio;
            int posicion = 0;

            while (actual != null)
            {
                if (actual.Valor == num)
                {
                    Console.WriteLine($"El valor {num} se encuentra en la posición {posicion}.");
                    return posicion;
                }

                actual = actual.Sig;
                posicion++;
            }

            Console.WriteLine($"El valor {num} no se encontró en la lista.");
            return -1;

        }


        public bool Cambiar(int pos, int num)
        {
            //asigna el nuevo valor en la posicion indicada
            //si el cambio es exitoso, regresa true
            //si no encuentra el nodo, o la lista esta vacia
            //regresa false
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return false;
            }

            nodo_lista_pila_cola actual = inicio;
            int contador = 0;

            while (actual != null)
            {
                if (contador == pos)
                {
                    actual.Valor = num;
                    Console.WriteLine($"El valor en la posición {pos} ha sido cambiado a {num}.");
                    return true;
                }

                actual = actual.Sig;
                contador++;
            }

            Console.WriteLine("No se encontró la posición en la lista.");
            return false;

        }


        public bool Borrar(int pos)
        {
            //elimina el nodo en la posicion indicada y
            //regresa true si elimino exitosamente
            //sino encuentra la posicion o la lista esta
            //vacia,regresa false ya que no pudo eliminar
            // Elimina el nodo en la posición indicada y regresa true si se eliminó con éxito
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
                return false;
            }

            if (pos == 0)
            {
                inicio = inicio.Sig;
                Console.WriteLine("El nodo fue borrado con éxito");
                return true;
            }

            nodo_lista_pila_cola actual = inicio;
            nodo_lista_pila_cola anterior = null;
            int contador = 0;

            while (inicio != null && contador < pos)
            {
                anterior = actual;
                actual = actual.Sig;
                contador++;
            }

            if (actual != null)
            {
                anterior.Sig = actual.Sig;
                actual.Sig = null;
                actual = null;
                Console.WriteLine("El nodo fue eliminado con éxito");
                return true;
            }

            Console.WriteLine("No se encontró la posición en la lista");
            return false;
        }

    }
}
