using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class HerdaFuncionarios : Funcionarios //herança aqui
    {

        public override int calculaSalario(string cargo)
        {
            switch (cargo)
            {
                case "Gerente":
                    return 3000;
                case "Diretor":
                    return 4000;
                case "Funcionarios":
                    return 2000;
                default:
                    return 1000;
            }
        }
    }
}
