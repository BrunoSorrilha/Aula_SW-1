namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐INSTANCIA DE UM OBJETO⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐
            Lampada lampada1 = new Lampada();

            //chamando o metodo para ligar lamp1
            lampada1.ligar();
            lampada1.Colores();
            lampada1.aopotencia();

            //Chamando o metodo para verificar se lamp1 está ligada
            Console.WriteLine("A lampada está ligada?" + lampada1.estaLigada());
            Console.WriteLine("A cor da lampada é:" + lampada1.qualCor());
            Console.WriteLine("A potencia é" + lampada1.QualPotencia());
 
        }
    }
}