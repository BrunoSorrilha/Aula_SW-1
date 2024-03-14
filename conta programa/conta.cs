namespace conta
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANCO ETEC MCM");

            Conta conta = new Conta();
            Console.WriteLine("Seu saldo inicial é de: R$ " + conta.consulta_saldo());

            conta.deposito(500);

            Console.WriteLine("Seu saldo inicial é de: R$" + conta.consulta_saldo());

        }
    }
}