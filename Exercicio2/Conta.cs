using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
   
        internal abstract class Conta
        {
            private double _saldo;
            private double _limite;

            public double Saldo {
            get {  return _saldo; }
            private set { _saldo = value; }
           }

            public double Limite
            {
                get { return _limite; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Erro: Limite informado inválido.");
                    }
                    else
                    {
                        _limite = value;
                    }
                }
            }

            public void AdicionarSaldo(double valor)
            {
                _saldo += valor;
            }

            public void SacarValor(double valor)
            {
                if (valor > Saldo + Limite)
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
                else
                {
                    _saldo -= valor;
                }
            }

            public abstract void Depositar(double valor);
            public abstract void Sacar(double valor);

            public void ApresentarSaldo()
            {
                Console.WriteLine("Saldo: R$" + Saldo);
            }
        }
    }


