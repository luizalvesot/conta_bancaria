using System;

namespace ExercicioContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria cb;    

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                cb = new ContaBancaria(numero, titular, depositoInicial);
            } else{
                cb = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta: \n" + cb);

            Console.Write("\n\n Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            cb.Deposito(quantia);
            Console.WriteLine("\nDados da conta atualizados: \n" + cb);

            Console.Write("\n\n Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            cb.Saque(quantia);
            Console.WriteLine("\nDados da conta atualizados: \n" + cb);
        }
    }
}