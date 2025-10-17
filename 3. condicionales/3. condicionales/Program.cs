namespace _3._condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noches = 0;
            double precionoche = 0;
            double subtotal = 0;
            double total = 0;
            double descuento = 0;

            Console.WriteLine("Ingrese la cantidad de noches que se hospedara:");
            noches = int.Parse(Console.ReadLine());

            subtotal = precionoche * noches;

            if (noches > 3)
            {
                descuento = subtotal * 0.17;
            }
            else
            {
                descuento = subtotal * 0.02;
            }

            total = subtotal - descuento;

            Console.WriteLine($"subtotal: {subtotal}");
            Console.WriteLine($"Descuento aplicado: {descuento}");
            Console.WriteLine($"Monto total a pagar: {total}");
        }

    }
}
