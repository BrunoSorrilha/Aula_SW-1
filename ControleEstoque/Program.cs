namespace ControleEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(20, "Sukuna_fingers", 0, 20000);
            p.imprimir();
            p.entrada(20);
            p.imprimir();
            p.venda(5);
            p.imprimir();
        }
    }
}
