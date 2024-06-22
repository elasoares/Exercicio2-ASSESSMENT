namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new ContaCorrente();
            int operacao;

            while (true)
            {
                Console.WriteLine("Escolha uma opção:  ");
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Apresentar o saldo");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("4 - Sair");
                operacao = int.Parse(Console.ReadLine());
                int valor;

                if (operacao == 1)
                {
                    Console.WriteLine("Digite o valor que deseja sacar: ");
                    valor = int.Parse(Console.ReadLine());
                    conta.Sacar(valor);
                }
                else if (operacao == 2)
                {
                    conta.ApresentarSaldo();
                }
                else if (operacao == 3)
                {
                    Console.WriteLine("Digite o valor que deseja depositar: ");
                    valor = int.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                }
                else if (operacao == 4)
                {
                    Console.WriteLine("Operação finalizada!");
                    break;
                }
                else
                {
                    Console.WriteLine("Erro: informação inválida!");
                }
            }
        }
    }
}
