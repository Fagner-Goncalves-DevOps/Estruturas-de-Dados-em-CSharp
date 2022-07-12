using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionarios funcionarios = new Funcionarios();

            string aux1 = "Gerente";

            Console.WriteLine("-----------");
            Console.WriteLine("Resultado: ");
            Console.WriteLine("Valor do Salario para {0}, é -> {1}", aux1, funcionarios.calculaSalario(aux1));
            Console.WriteLine("-----------");

            HerdaFuncionarios herdaFuncionarios = new HerdaFuncionarios();

            string aux2 = "Gerente";

            Console.WriteLine("-----------");
            Console.WriteLine("Resultado: ");
            Console.WriteLine("Valor do Salario para {0}, é -> {1}", aux2, herdaFuncionarios.calculaSalario(aux2));

        }
    }
}
