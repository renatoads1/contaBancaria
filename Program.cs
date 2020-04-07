using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o nímero da conta");
            int NumConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da conta");
            string Titular = Console.ReadLine();
            Console.Write("Havera deposito inicial? (S/N) ");
            char resp = char.Parse(Console.ReadLine());
            if ((resp == 'S') || (resp == 's'))
            {
                Console.Write("Digite o valor de deposito inicial");
                float saldo = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(NumConta, Titular, saldo, saldo);
            }
            else
            {
                conta = new ContaBancaria(NumConta, Titular);
            }

            Console.WriteLine("conta aberta");
            Console.WriteLine(conta);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Para deposito digite 1 Para saque digite 2");
            string escolha = Console.ReadLine();
            if (escolha == "1")
            {

                Console.WriteLine("Digite o valor a ser depositado");
                float valor = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                string resultado = conta.Depositar(valor).ToString();
                Console.Clear();
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Digite o valor a ser sacado");
                float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                string resultado = conta.Sacar(valor).ToString();
                Console.Clear();
                Console.WriteLine(conta);
            }

        }
    }
}
