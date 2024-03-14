namespace ContaBancaria
{
    public class Conta
    {
        private string? Num_conta { get; set; }
        private float Saldo { get; set; }
        private float Limite { get; set; }

        public float consulta_saldo()
        { 
            return Saldo; 
        }

        public void deposito(float valor_deposito)
        {
            Saldo += valor_deposito;
            Console.WriteLine("agora seu saldo é de R$ " + consulta_saldo())
        }
}
    