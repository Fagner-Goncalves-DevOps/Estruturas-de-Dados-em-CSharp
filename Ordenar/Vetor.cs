using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    public class Vetor
    {
        private int n, u, max; // atributos da classe
        private int[] vet;    // ''

        // --------------------------------------------- construtor
        public Vetor(int numerosElementos) 
        {
            vet = new int[numerosElementos];
            n = 0;
            u = -1;
            max = numerosElementos;
        }

        // --------------------------------------------- Metodo verificaPosicao
        public void verificaPosicao(int elemento)
        {
            int pos = 0;

            for (int i = 0; i < u; i++) {
                if (elemento > vet[i]) {
                    pos = i + 1;
                }
            }
            if (pos == 0)
            {
                insereInicio(elemento);
            }
            else {
                if (pos == u + 1)
                {
                    insereFim(elemento);
                }
                else {
                    inserePosicao(elemento, pos);
                }
            }
        }

        // --------------------------------------------- insereFim
        private void insereFim(int elemento) 
        {
            if (n < max)
            {
                u++;
                vet[u] = elemento;
                n++;
            }
            else {
                Console.WriteLine("ERRO: Vetor Lotado");
                Environment.Exit(0);
            }
        }
        // --------------------------------------------- insereInicio
        private void insereInicio(int elemento)
        {
            if (n < max)
            {
                if (n != 0)
                {
                    for (int i = u + 1; i >= 1; i--)
                    {
                        vet[i] = vet[i - 1];
                    }
                }
                u++;
                vet[0] = elemento;
                n++;
            }
            else {
                Console.WriteLine("ERRO: Vetor Lotado");
                Environment.Exit(0);
            }
        }
        // --------------------------------------------- inserePosicao
        private void inserePosicao(int elemento, int pos) 
        {
            if (n < max)
            {
                if (n != 0)
                {
                    for (int i = u + 1; i > pos; i--)
                    {
                        vet[i] = vet[i - 1];
                    }
                }
                u++;
                vet[pos] = elemento;
                n++;
            }
            else {
                Console.WriteLine("ERRO: Vetor Lotado");
                Environment.Exit(0);
            }
        }
        // --------------------------------------------- exibeVetor
        public void exibeVetor() 
        {
            Console.Write("Vetor:[");  //abriu
            for (int i = 0; i < u; i++) {
                Console.Write(vet[i] + ",");
            }
            Console.WriteLine(vet[u] + "]"); //fechou
        }
    }
}
