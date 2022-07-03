using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //lê matriz A  (12x13) dividir os elementos de cada uma das 12 linhas de A pelo maior valor daquela linha.
            //considerar que a matriz armazena apenas elementos inteiros.

            const int numeroslinhas = 12, numeroColunas = 13;
            float[,] a = {
                            { 1,1,1,1,1,1,1,1,1,1,1,1,1}, //colunas 13
                            { 2,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 3,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 4,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 5,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 6,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 7,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 8,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 9,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 10,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 11,1,1,1,1,1,1,1,1,1,1,1,1},
                            { 12,1,1,1,1,1,1,1,1,1,1,1,1}
                            //12 linhas
                        };
            float[] maior = new float[numeroslinhas];

            //gerar maior
            for (int l = 0; l < numeroslinhas; l++) {
                for (int c = 0; c < numeroColunas; c++) {
                    if (a[l, c] > maior[l]) {
                        maior[l] = a[l, c];
                    }
                }
            }
            //divisão
            for (int l = 0; l < numeroslinhas; l++) {
                for (int c = 0; c < numeroColunas; c++) {
                    a[l, c] = a[l, c] / maior[l];
                }
            }

            //mostrar na tela
            for (int l = 0; l < numeroslinhas; l++) {
                string outFormat = string.Format("{0:00.0}", maior[l]);   //formatando a saida para tela
                Console.Write(outFormat + "->");

                for (int c = 0; c < numeroColunas; c++) {
                    outFormat = string.Format("{0:0.00}", a[l, c]);
                    Console.Write(outFormat+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
