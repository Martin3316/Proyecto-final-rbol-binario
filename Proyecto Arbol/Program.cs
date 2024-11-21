using Proyecto_Arbol;
using System;
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
                               "1-Arbol\n" +
                               $"2-Pila\n" +
                               "3-Cola\n" +
                               "4-Salir\n" +
                               "______________________");
                Console.Write("Seleccionar Opcion: ");

                int opcion = int.Parse(Console.ReadLine());

                Console.Clear();

              switch (opcion)
              {
                case 1:
                        /*
                        arbol miarbol = new arbol();

                        miarbol.insertar(15);
                        miarbol.insertar(8);
                        miarbol.insertar(23);
                        miarbol.insertar(2);
                        miarbol.insertar(25);
                        miarbol.insertar(12);

                        miarbol.Recorrido(miarbol.raiz);
                        Console.ReadLine();*/

                        break;

                case 2:
                        pila Mi_pila = null;
                        
                        while (regresar_al_menu_principal)
                        {
                            Console.WriteLine("Proyecto Pilas\n" +
                            "______________________\n" +
                            "1-Establecer tamaño\n" +
                            $"2-Push\n" +
                            "3-Pop\n" +
                            "4-Imprimir\n" +
                            "5-Salir\n" +
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
                                    Console.WriteLine("!!ADIOS!!");
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
                            Console.WriteLine("Proyecto colas\n" +
                                "______________________\n" +
                                "1-Establecer tamaño\n" +
                                $"2-insert\n" +
                                "3-Extract\n" +
                                "4-Imprimir\n" +
                                "5-Count\n" +
                                "6-Salir\n" +
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
                                    Console.WriteLine("!!ADIOS!!");
                                    regresar_al_menu_principal = false;
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();                           
                        }
                        break;

                    case 4:
                        Console.WriteLine("!!ADIOS!!");
                        return;
              }
                Console.Clear();
            }
        }
    }      
}

