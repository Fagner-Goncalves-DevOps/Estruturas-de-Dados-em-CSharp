using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados5
{
    public class Aluno
    {
        // -------------------------------------------- atributos da classe "entidades"

        private string Nome;
        private int Matricula;
        private char Sexo;

        // ------------------------------------------- construtor

        public Aluno(string nome, int matricula, char sexo)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Sexo = sexo;
        }
        // ------------------------------------------- Metodos exibeAtributos

        public void exibeAtributos()
        {
            Console.WriteLine("Nome:" + Nome);
            Console.WriteLine("Matricula:" + Matricula);
            if (Sexo == 'M' || Sexo == 'm')
            {
                Console.WriteLine("Sexo: Masculino");
            }
            else {
                Console.WriteLine("Sexo: Feminino");
            }
        }
        // ------------------------------------------- toString

        public string toString() 
        {
            return (Nome + "..." + Matricula + "..." + Sexo);
        }
    }
}
