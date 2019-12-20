using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Funcionarios
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionarios, string senha)
        {
            bool usuarioAutenticado = funcionarios.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
                    
            }
        }
    }
}
