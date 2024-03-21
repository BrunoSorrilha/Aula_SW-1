namespace avião
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AVIÃO DA ETEC MCM");
            Aviao aviao = new Aviao();

            Console.WriteLine("A altura do avião é de: " + aviao.Altura_Atual() + " Metros de altura");
            Console.WriteLine("A velocidade do avião é de: " + aviao.Velocidade_Atual() + "Km/h");

            aviao.Vrumm(500);
            aviao.Ziumm(500);
            Console.WriteLine("A altura do avião é de: " + aviao.Altura_Atual() + " Metros de altura");
            Console.WriteLine("A velocidade do avião é de: " + aviao.Velocidade_Atual() + "Km/h");

        }
    }
}