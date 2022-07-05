using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados7a
{
    public class ListaOrdenada
    {
        const int SUCESSO = 0;
        const int LISTA_CHEIA = 1;
        const int LISTA_VAZIA = 2;
        int[] v;

        public ListaOrdenada(int numElementos) 
        {
            v = new int[numElementos];
            v[0] = 0;
        }

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
            else return (LISTA_CHEIA);
        }

        public int incluiInic(int valor) 
        {
            int m = v.Length;
            int n = v[0];

            if (n < m - 1) {
                v[0]++;
                for (int i = n + 1; i >= 2; i--)
                    v[i] = v[i - 1];
                    v[1] = valor;
                     return (SUCESSO);
            }else return (LISTA_CHEIA);
        }

        public int incluiPos(int valor, int pos) 
        {
            int m = v.Length;
            int n = v[0];

            if (n < m - 1)
            {
                v[0]++;
                if (pos == n)
                {
                    v[v[0]] = v[n];
                    v[n] = valor;
                }
                else
                {
                    for (int i = n + 1; i >= pos; i--)
                    {
                        v[i] = v[i - 1];
                    }
                    v[pos] = valor;
                }
                return (SUCESSO);
            }
            else return (LISTA_CHEIA);
        }

        public int tamanhoLista() 
        {
            return (v[0]);
        }
        public int verificaPos(int valor) 
        {
            int i = 1;

            do {
                if (valor < v[i]) {
                    return (incluiPos(valor, i));
                }
                i++;
            } while (i <= v[0]);
            return (incluiFim(valor));
        }

        public void exibeLista() 
        {
            string s = "";
            int n = v[0];
            if (n == 0)
            {
                Console.WriteLine("Erro: Lista Vazia!");
            }
            else {
                for (int i = 1; i <= n; i++) {
                    s = s + v[i] + "";
                }
                Console.WriteLine("Lista:" + s);
            }
        }
    }
}
