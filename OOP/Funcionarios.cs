using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Funcionarios
    {

        public virtual int calculaSalario(string cargo) 
        {
            switch (cargo) 
            {
                case "Gerente":
                    return 3000;
                case "Diretor":
                    return 4500;
                case "Funcionario":
                    return 1500;
                default:
                    return 2000;
            }
        }
    }
}
