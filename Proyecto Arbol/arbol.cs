﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol
{
    internal class arbol
    {
        public nodo raiz;
        private nodo obs;

        public int contador = 0;

        public void insertar(int v)
        {
            nodo nuevo, psave;
            Boolean Found = false;
            psave = obs;
            Found = FindKey(v);
            if (Found)
            {
                Console.WriteLine("El nodo ya existe");
                obs = psave;
            }
            else
            {
                nuevo = new nodo(v);
                if (raiz == null)
                {
                    raiz = nuevo;
                    obs = nuevo;
                }
                else
                {
                    if (v < obs.valor)
                        obs.izq = nuevo;
                    else
                        obs.der = nuevo;
                    obs = nuevo;
                }
                contador++;
            }
        }

        private bool FindKey(int v)
        {
            Boolean Found = false;
            nodo q;
            q = raiz;
            while (!Found && q != null)
            {
                if (v == q.valor)
                {
                    obs = q;
                    Found = true;
                }
                else
                {
                    if (v < q.valor)
                    {
                        if (q.izq == null)
                            obs = q;
                        q = q.izq;
                    }
                    else
                    {
                        if (q.der == null)
                            obs = q;
                        q = q.der;
                    }
                }
            }
            return Found;
        }

        public void Recorrido(nodo q)
        {
            if (q != null)
            {
                Console.Write($"{q.valor},");
                Recorrido(q.izq);
                Console.Write($"{q.valor},");
                Recorrido(q.der);
                Console.Write($"{q.valor},");

            }
        }

        public void tamaño()
        {
            Console.WriteLine($"El tamaño del arbol es: {contador}");
        }

        public int Altura(nodo q)
        {
            if (q == null)
                return 0;

            int alturaIzq = Altura(q.izq);
            int alturaDer = Altura(q.der);

            if (alturaIzq > alturaDer)
                return 1 + alturaIzq;
            else
                return 1 + alturaDer;
        }

        private void LR(nodo q, int distAct, ref int sumDist, ref int totNodos)
        {
            if (q != null)
            {
                sumDist += distAct;
                totNodos++;

                LR(q.izq, distAct + 1, ref sumDist, ref totNodos);
                LR(q.der, distAct + 1, ref sumDist, ref totNodos);
            }
        }

        public double LRP()
        {
            int sumDist = 0;
            int totNodos = 0;

            LR(raiz, 1, ref sumDist, ref totNodos);

            if (totNodos == 0) return 0;
            return (double)sumDist / totNodos;
        }
    }
}
