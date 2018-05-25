using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
   class ContaCorrente : Conta, ITributavel
    {
        private static int totalDeContas = 0;

        public ContaCorrente()
        {
                ContaCorrente.totalDeContas++;
        }

        public int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
