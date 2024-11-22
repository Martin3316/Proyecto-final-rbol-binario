using Proyecto_Arbol;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool regresar = true;
            while (regresar)
            {
                bool regresar_al_menu_principal = true;

                Console.WriteLine("Proyecto Final\n" +
                               "______________________\n" +
                               "1-Listas\n" +
                               $"2-Pilas\n" +
                               "3-Colas\n" +
                               "4-Arboles\n" +
                               "5-Salir\n" +
                               "______________________");
                Console.Write("Seleccionar Opcion: ");

                int opcion = int.Parse(Console.ReadLine());

                Console.Clear();

              switch (opcion)
              {
                case 1:
                        lista milista = new lista();
                        while (regresar_al_menu_principal)
                        {
                            Console.WriteLine("Menu Listas " +
                            "\n__________________________" +
                            "\n1.- Insertar Nodo" +
                            "\n2.- Imprimir Tamaño" +
                            "\n3.- Buscar Nodo" +
                            "\n4.- Borrar Nodo" +
                            "\n5.- Modificar Nodo" +
                            "\n6.- Buscar Valor" +
                            "\n7.- Imprimir Lista" +
                            "\n8.- Regresar" +
                            "\n__________________________");
                            Console.Write("Seleciona una opcion: ");

                            opcion = int.Parse(Console.ReadLine());

                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("__________________________");
                                    Console.Write("Ingresa el valor del nodo: ");
                                    int valor = int.Parse(Console.ReadLine());
                                    milista.Agregar(valor);
                                    Console.WriteLine("!!PRESIONAR ENTER!!");
                                    Console.ReadKey();

                                    break;

                                case 2:
                                    Console.WriteLine("__________________________");
                                    milista.Contar();
                                    Console.WriteLine("!!PRESIONAR ENTER!!");
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.WriteLine("__________________________");
                                    Console.Write("Dime cual es la posicion del nodo que quieres saber su valor: ");
                                    int valor_posicion = int.Parse(Console.ReadLine());
                                    milista.Encontrar(valor_posicion);
                                    Console.WriteLine("!!PRESIONAR ENTER!!");
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.WriteLine("__________________________");
                                    Console.Write("Dime la posicion del nodo que quieres borrar: ");
                                    int nodo_borrar = int.Parse(Console.ReadLine());
                                    milista.Borrar(nodo_borrar);
                                    Console.WriteLine("!!PRESIONAR ENTER!!");
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.WriteLine("__________________________");
                                    Console.WriteLine("Dime la posicion del nodo que quieres modificar");
                                    int posicion_nodo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingresa el nuevo valor del nodo.");
                                    int valor_nodo = int.Parse(Console.ReadLine());
                                    milista.Cambiar(posicion_nodo, valor_nodo);
                                    Console.WriteLine("!!PRESIONAR ENTER!!");
                                    Console.ReadKey();
                                    break;

                                case 6:
                                    Console.WriteLine("__________________________");
                                    Console.Write("Ingresa el valor a buscar: ");
                                    int valor_buscar = int.Parse(Console.ReadLine());
                                    milista.EncontrarValor(valor_buscar);
                                    Console.WriteLine("!!PRESIONAR ENTER!!");
                                    Console.ReadKey();
                                    break;

                                case 7:
                                    Console.WriteLine("__________________________");
                                    milista.Imprimir();
                                    Console.WriteLine("\n__________________________");
                                    Console.WriteLine("\n!!PRESIONAR ENTER!!");
                                    Console.ReadKey();
                                    break;

                                case 8:
                                    Console.WriteLine("__________________________");
                                    Console.WriteLine("!!Regresando al menu principal!!");
                                    regresar_al_menu_principal = false;
                                    Console.ReadKey();
                                    break;

                            }
                            Console.Clear();
                        }
                        break;

                case 2:
                        pila Mi_pila = null;
                        
                        while (regresar_al_menu_principal)
                        {
                            Console.WriteLine("Menu pilas\n" +
                            "______________________\n" +
                            "1-Establecer tamaño\n" +
                            $"2-Push\n" +
                            "3-Pop\n" +
                            "4-Imprimir\n" +
                            "5-Regresar\n" +
                            "______________________");
                            Console.Write("Seleccionar Opcion: ");
                            opcion = int.Parse(Console.ReadLine());
                            Console.WriteLine("______________________");
                            switch (opcion)
                            {
                                case 1:
                                    Console.Write("Dime cual sera el tamaño de la pila: ");
                                    int tamaño_pila = int.Parse(Console.ReadLine());
                                    Mi_pila = new pila(tamaño_pila);
                                    break;
                                case 2:
                                    if (Mi_pila != null)
                                    {
                                        Console.Write("Ingresa el numero que quieres agregar: ");

                                        int numero = int.Parse(Console.ReadLine());
                                        Console.WriteLine("______________________");
                                        Mi_pila.Push(numero);
                                        Console.Write("!!PRESIONA ENTER!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se ha ingresado el tamaño de la pila ");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    if (Mi_pila != null)
                                    {
                                        Mi_pila.Pop();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se ha ingresado el tamaño de la pila ");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    if (Mi_pila != null)
                                    {
                                        Mi_pila.PrintStack();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se ha ingresado el tamaño de la pila ");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine("!!Regresando al menu principal!!");
                                    regresar_al_menu_principal = false;
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                        }
                 break;

                    case 3:

                        cola mi_cola = null;

                        while (regresar_al_menu_principal)
                        {
                            Console.WriteLine("Menu colas\n" +
                                "______________________\n" +
                                "1-Establecer tamaño\n" +
                                $"2-insert\n" +
                                "3-Extract\n" +
                                "4-Imprimir\n" +
                                "5-Count\n" +
                                "6-Regresar\n" +
                                "______________________");
                            Console.Write("Seleccionar Opcion: ");
                            opcion = int.Parse(Console.ReadLine());
                            Console.WriteLine("______________________");

                            switch (opcion)
                            {
                                case 1:
                                    Console.Write("Dime cual sera el tamaño de la cola: ");
                                    int tamaño_cola = int.Parse(Console.ReadLine());
                                    mi_cola = new cola(tamaño_cola);
                                    break;
                                case 2:

                                    if (mi_cola != null)
                                    {
                                        Console.Write("Ingresa el numero que quieres agregar: ");
                                        int numero = int.Parse(Console.ReadLine());
                                        Console.WriteLine("______________________");
                                        mi_cola.Insert(numero);
                                        Console.Write("!!PRESIONA ENTER!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se ha ingresado el tamaño de la cola ");
                                    }
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    if (mi_cola != null)
                                    {
                                        mi_cola.Extract();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se ha ingresado el tamaño de la cola ");
                                    }
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    if (mi_cola != null)
                                    {
                                        mi_cola.Print();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se ha ingresado el tamaño de la cola ");
                                    }
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    if (mi_cola != null)
                                    {
                                        mi_cola.Count();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se ha ingresado el tamaño de la cola ");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.WriteLine("!!Regresando al menu principal!!");
                                    regresar_al_menu_principal = false;
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();                           
                        }
                        break;

                    case 4:
                        arbol mi_arbol = new arbol();

                        while (regresar_al_menu_principal)
                        {

                           Console.WriteLine("Menu Arboles\n" +
                                  "______________________\n" +
                                  "1-Insertar nodo\n" +
                                  $"2-Tamaño\n" +
                                  "3-Altura\n" +
                                  "4-LRP\n" +
                                  "5-Recorrido\n" +
                                  "6-Regresar\n" +
                               "______________________");
                           Console.Write("Seleccionar Opcion: ");
                           opcion = int.Parse(Console.ReadLine());
                           Console.WriteLine("______________________");

                            switch(opcion)
                            {
                                case 1:

                                break;

                                case 2:

                                break;

                                case 3:

                                break;

                                case 4:

                                break;

                                case 5:

                                break;

                                case 6:

                                break;


                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("!!ADIOS!!");
                        return;
              }
                Console.Clear();
            }
        }
    }      
}

