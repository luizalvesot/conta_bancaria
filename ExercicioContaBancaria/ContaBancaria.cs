using System.Globalization;

namespace ExercicioContaBancaria {
    internal class ContaBancaria {

        public double Saldo { get; private set; }
        public int Numero { get; private set; }
        public string Titular { get; set; }

        public ContaBancaria(int Numero, string Titular) {
            this.Numero= Numero;
            this.Titular = Titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int Numero, string Titular, double depositoInicial) : this(Numero, Titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.00;
        }

        public override string ToString() {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
