using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876, 86712540);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(876, 8674820);
            ContaCorrente contaDoMarcos = new ContaCorrente(876, 8674820);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();            

        }
    }
}
