using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados6a
{
    public class Lista
    {
        const int SUCESSO = 0;
        const int LISTA_CHEIA = 1;
        const int LISTA_VAZIA = 2;
        private int[] v;


        // -------------------------------------------------- criaLista
        public Lista(int numElementos)
        {
            v = new int[numElementos];
            v[0] = 0;
        }

        // -------------------------------------------------- incluiFim
        public int incluiFim(int valor)
        {
            int m = v.Length;
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
        public void exibeLista()
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
