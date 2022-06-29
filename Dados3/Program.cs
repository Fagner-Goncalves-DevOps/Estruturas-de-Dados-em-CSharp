using System;

namespace Dados3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              Tipos complexos obtidos através dos tipos primitivos do C#,

               //------------------------------------ Cadeia de Caracteres
               STRING: string s;
               // ------------------------------------Agregados Homogêneos
               VETOR E MATRIZ: int[] vetor; int[][] matriz;

               //------------------------------------Classe
               CLASSE: public class nomeClasse { }


              // String(Cadeia de Caracteres)
              // permite que uma variavel tenha um conjunto de characters

               declaração e inicialização:
               string r = “123.45”;
               string s = “abc”;
               string t = "Pelotas";

               Vetor e Matriz(Agregados Homogêneos)

               dados que permite que uma variavel possua um conjunto de elementos do mesmo tipo, todos alocados na memoria ao mesmo tipo

               // ------------------------------------------ constante tipada inteira
               const int numElementos = 10;
               float[] vetor = new float[numElementos];
               vetor[0] até vetor[9]
               const int numLinhas = 3;
               const int numColunas = 2;
               double[,] matriz = new double[numLinhas, numColunas];

               Exemplos de inicialização:
               int[] vetor = { 10, 20, 30, 40, 50 };
               int[,] matriz = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

             */

            int i, j;
            int[] vetor = { 10, 20, 30, 40, 50 };

            for (i=0; i<vetor.Length; i++) 
            {
                Console.WriteLine(i + ":" + vetor[i]);
            }

            const int numeroLinhas = 3;
            const int numeroColunas = 2;

            int[,] matriz = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for (i=0; i<numeroLinhas;i++) 
            {
                for (j = 0; j < numeroColunas; j++) 
                {
                    Console.WriteLine(i + ":" + j + ":" + matriz[i, j]);
                }
            }



        }
    }
}
