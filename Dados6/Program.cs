using System;

namespace Dados6
{
    class Program
    {
       public static void Main(string[] args)
        {
            const int m = 7;
            int[] v = new int[m];
            int valor;
            int erro = 0;

            criaLista(v);
            do {
                Console.Write("Elemento: ");
                string s = Console.ReadLine();
                valor = Convert.ToInt32(s);

                if (valor != 0) erro = incluiFim(m,v,valor);
                if (erro == LISTA_CHEIA) {
                    Console.WriteLine("Erro: Lista Cheia", "Atenção!");
                    exibeLista(v);
                    return;
                }
            } while (valor != 0);
            exibeLista(v);
        }



        //demonstra a construção de uma lista de m elementos,
        //onde o número de elementos é armazenado na posição zero do vetor, ou seja, n = v[0].

        const int SUCESSO = 0;
        const int LISTA_CHEIA = 1;
        const int LISTA_VAZIA = 2;

        // -------------------------------------------------- criaLista
        static void criaLista(int[] v)
        {
            v[0] = 0;
        }
        // -------------------------------------------------- incluiFim
        static int incluiFim(int m, int[] v, int valor)
        {
            int n = v[0];
            if (n < m - 1)
            {
                v[0]++;
                v[v[0]] = valor;
                return (SUCESSO);
            }
            else
                return (LISTA_CHEIA);
        }
        // -------------------------------------------------- exibeLista
        static void exibeLista(int[] v)
        {
            string s = "";
            int n = v[0];

            if (n == 0) Console.WriteLine();
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    s = s + v[i] + "";
                    Console.WriteLine("Lista: " + s);
                }
            }
        }



    }
}
