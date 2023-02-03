namespace SistemaBancario
{
    public class SistemaBancaro
    {
        public static void Main(string[]args)
        {
            var conta = new Conta();
            conta.NomeConta = " Conta Teste";
            conta.NumeroConta = 1000;
            conta.Agencia = 001;
            conta.Saldo = 1000;

            conta.Titular = new Titular()
            {
                CPF = "00364555879",
                RG = "54696457",
                Endereco = "Rua Centro",
                Nome = "Luiza",
            };

            Console.WriteLine($"O saldo atual é de : { conta.VerSaldo()}");

            conta.Depositar(150);

            Console.WriteLine($"O saldo atual, após o depósito é : {conta.VerSaldo()}");

            conta.Sacar(900);

            Console.WriteLine($"O saldo atual, após o saque é : {conta.VerSaldo()} ");

            conta.Sacar(2000);
            Console.WriteLine("Seu saldo é indisponivel para saque");
        }
    }
}