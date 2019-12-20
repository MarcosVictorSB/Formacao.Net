using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionarios
    {

        public static int TotalDeFuncionarios { get; private set; }
        
        public string Nome { get; set; }
        private string CPF { get; set; }
        public double Salario { get; protected set; }


        public Funcionarios(double salario, string cpf)
        {
            Console.WriteLine("Criando um Funcionario");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();


        public abstract double GetBonificacao();
    }
}
