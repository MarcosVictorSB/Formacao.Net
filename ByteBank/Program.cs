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
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionarios pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionarios roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Robera";

            Funcionarios igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionarios camila = new GerenteDeConta("3226.985.628-89");
            camila.Nome = "Camila";

            Funcionarios guilherme = new Desenvolvedor("456.175.468-95");
            guilherme.Nome = "guilherme";


            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificação do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
