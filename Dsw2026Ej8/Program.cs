namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var helper = new ProductHelper();
            string resultado = helper.ObtenerEtiquetaProducto(2570, "Coca-Cola", 300);
            Console.WriteLine(resultado);
            var problema = new Problema2();
            string resultado2 = problema.CrearResumenVenta(223, "Chupetin", 2, 100);
            Console.WriteLine(resultado2);
            var problema2 = new Problema4();
            double resultado4 = problema2.CalcularPromedio(10, 4, 7);
            Console.WriteLine(resultado4);

        }
    }
}
