using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados29
{
    public class Tabela
    {

        private string[] nome;
        private double[] peso;
        private double[] altura;
        private int n;
        private int[] chave;
        private int max;

        public Tabela(int numElementos) 
        {
            max = numElementos;
            chave = new int[max];
            nome = new string[max];
            peso = new double[max];
            altura = new double[max];
            n = -1;
        }
        // ---------------------------------------------- pesquisaBinaria

        public int pesquisaBinaria(int valor) 
        {
            int indice = -1;
            int inic, fim, metade;

            inic = 0;
            fim = (n - 1) + 1;
            metade = n / 2;

            do {
                if (valor == chave[metade])
                {
                    indice = metade;
                    break;
                }
                else
                {
                    if (valor < chave[metade])
                    {
                        fim = metade - 1;
                        metade = (fim + inic) / 2;
                    }
                }
            } while (indice == -1 && inic <= fim);
            return (indice);
        }
        // ---------------------------------------------- ordenaTabela
        public void ordernaTabela()
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j <= n; j++)
                {
                    if (chave[i] > chave[j])
                    {

                    }
                }

            }
        }









    }
}
