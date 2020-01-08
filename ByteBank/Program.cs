using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CarregarContas();
            }
            catch (Exception)
            {

                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {

            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }















            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    if(leitor != null)
            //        leitor.Fechar();
            //}


        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(15, 54545);
                ContaCorrente conta2 = new ContaCorrente(15, 54545);

                conta1.Transferir(10000, conta2);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna): ");
                //    Console.WriteLine(e.InnerException.Message);
                //    Console.WriteLine(e.InnerException.StackTrace);
                //
            }

        }
            
    }
}
