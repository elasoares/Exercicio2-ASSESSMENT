using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class ContaCorrente : Conta
    {
        public override void Depositar(double valor)
        {
            AdicionarSaldo(valor);
          
        }

        public override void Sacar(double valor)
        {
            SacarValor(valor);
         
        }
    }
}
