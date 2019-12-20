using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenciadorBonificacao
    {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionarios)
        {
            _totalBonificacao += funcionarios.GetBonificacao();
        }

        public virtual double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
