using System;

namespace MultMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lê duas MATRIZES A e B e gera uma matriz C que é a multiplcação da matriz A com a matrix B
            //ex:
            // A e B = vai gerar a C é a multiplicação da a*b
            // A * B = C

            int ma, na, mb, nb;

            //matriz A, linha coluna
            Console.Write("Numero de linhas da matriz A (mA): "); //vai pedir para digitar
            string s = Console.ReadLine(); //vai pegar o que for digitado e vai inserir na variavel S
            ma = Convert.ToInt32(s);  //convertemos para manter o padrão e jogamos na ma
            Console.Write("Numero de colunas da matriz A (nA): ");
             s = Console.ReadLine();
            na = Convert.ToInt32(s);

            //matriz B, linha coluna
            Console.Write("Numero de linhas da matriz B (mB): ");
            s = Console.ReadLine();
            mb = Convert.ToInt32(s);
            Console.Write("Numero de colunas da matriz B (nB): ");
            s = Console.ReadLine();
            nb = Convert.ToInt32(s);


            if (na != mb) {
                Console.WriteLine("Erro Fatal: Multiplicação Impossivel!");
                Console.WriteLine("Numero de Colunas de A tem que ser igual numero de linhas de B!");
                Environment.Exit(0);
            }

            int[,] a = new int[ma,na];
            int[,] b = new int[mb, nb];
            int[,] c = new int[ma,nb];

            Console.WriteLine("Matriz A");
            for (int lin = 0; lin < ma; lin++) {
                for (int col = 0; col < na; col++) {
                    Console.Write("A["+ (lin + 1) + "," + (col + 1) +"]:");
                    s = Console.ReadLine();
                    a[lin, col] = Convert.ToInt32(s);
                }
            }

            Console.WriteLine("Matriz B");
            for (int lin = 0; lin < mb; lin++) {
                for (int col = 0; col < nb; col++) {
                    Console.Write("B[" + (lin + 1) + "," + (col + 1) + "]:");
                    s = Console.ReadLine();
                    b[lin, col] = Convert.ToInt32(s);
                }
            }

            Console.WriteLine("Matriz C = A*B");
            for (int lin = 0; lin < ma; lin++) {
                for (int col = 0; col < nb; col++) {
                    c[lin, col] = 0;
                    for (int k = 0; k < na; k++) {
                        c[lin, col] = c[lin, col] + a[lin, k] * b[k, col];
                    }
                }
            }
            for (int lin = 0; lin < ma; lin++) {
                for (int col = 0; col < nb; col++) {
                    Console.WriteLine("C[" + (lin + 1) + "," + (col + 1) + "]:"+c[lin,col]);
                }
            }
        }
    }
}
