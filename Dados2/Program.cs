using System;

namespace Dados2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados do tipo string via teclado e saida na tela

            Console.Write("Digite seu Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Número de Caracteres: {0}", nome.Length);
        }
    }
}
