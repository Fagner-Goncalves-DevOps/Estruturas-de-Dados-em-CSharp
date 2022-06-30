using System;

namespace Dados5
{
    class Program
    {
        static void Main(string[] args)
        {
            //classes são tipos de dados que permite criar objs, classe pode ter atributos, e tambem metodos
            //atributos conjuntos de variaveis que o obj possui
            //metodos funcoes que manipulan os atributos


            //classe aluno simples

            Aluno aluno = new Aluno("Fagner", 10,'m');

            aluno.exibeAtributos();
            Console.WriteLine(aluno.toString()); //chama metodo aluno 

        }
    }
}
