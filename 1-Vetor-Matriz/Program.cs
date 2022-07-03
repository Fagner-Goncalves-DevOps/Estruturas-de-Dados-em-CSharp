using System;

namespace _1_Vetor_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //conceitos basicos

            //Vetor: (É uma matriz unidimensional)
            const int numElementos = 7;
            int[] vetor = new int[numElementos];

            //Matriz: (Possui mais de uma dimensão)
            const int numLinhas = 3;
            const int numColunas = 4;
            double[,] matriz = new double[numLinhas, numColunas];

            //Índice: constante numerica inteira que referencia cada elemento do vetor ou da matriz
            //ex:
            /* 
             vetor[0]......................................primeiro elemento
             vetor[numeroElementos - 1]....................último elemento
             m[0, 0]....................................... primeiro elemento
             m[numLinhas – 1, numColunas - 1]..............último elemento

            */


            //Entrada de vetor unidimensional
            const int num1Elementos = 7;

            int[] vetor2 = new int [num1Elementos];

            for (int i = 0; i < num1Elementos; i++) {
                Console.WriteLine("Valor:");
                string s = Console.ReadLine();
                vetor[i] = Convert.ToInt32(s);
                
            }

            //Entrada de Matriz Bidimensional:
            const int num1Linhas = 3;
            const int num1Colunas = 4;

            double[,] matriz2 = new double[num1Linhas, num1Colunas];

            for (int i= 0 ; i< num1Linhas; i++) {   
                for (int j = 0; j< num1Colunas; j++) {
                    Console.WriteLine("Valor:");
                    string s = Console.ReadLine();
                    matriz2[i, j] = Convert.ToInt32(s);
                }
            }
        }
    }
}
