using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ByteBank.Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionarios carlos = new Funcionarios();

            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);


            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "444.879.157-20";
            roberta.Salario = 5000;

            Funcionarios robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Funcionario: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());


            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificação: " + gerenciador.GetTotalBonificacao());



            Console.ReadLine();

        }
    }
}
