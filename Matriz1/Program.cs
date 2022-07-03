using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {

            //ler matriz A (3x4), criar 2 vetores SL e SC de 3 e 4 elementos que contenham a somadas linhas SL e SC

            const int numeroLinhas = 3, numeroColunas = 4;

            int[,] a = new int[numeroLinhas, numeroColunas];
            int[] sl = new int[numeroLinhas];
            int[] sc = new int[numeroColunas];

            for (int l = 0; l < numeroLinhas; l++) {
                for (int c = 0; c < numeroColunas; c++) {
                    Console.Write("a [" + (l + 1) + "," + (c + 1) + "]: ");
                    string s = Console.ReadLine();
                    a[l,c] = Convert.ToInt32(s);
                }
            }

            int k = 0;
            for (int l = 0; l < numeroLinhas; l++) {
                for (int c = 0; c < numeroColunas; c++) {
                    sl[k] = sl[k] + a[l, c];
                }
                k++;
            }
            Console.WriteLine();
            for (k = 0; k < numeroLinhas; k++) {
                Console.WriteLine("sl [" + (k + 1) + "]:" + sl[k]);
            }

            k = 0;
            for (int c = 0; c < numeroColunas; c++) {
                for (int l= 0; l < numeroLinhas; l++) {
                    sc[k] = sc[k] + a[l, c];
                }
                k++;
            }
            Console.WriteLine();
            for (k = 0; k < numeroColunas; k++) {
                Console.WriteLine("sc [" + (k + 1) + "]:" + sc[k]);
            }
            Console.WriteLine();
        }
    }
}
