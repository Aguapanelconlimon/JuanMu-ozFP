namespace _15._While7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes = 1;
            double AhorroMensual = 0;
            double AhorroTotal = 0;

            Console.WriteLine("software para calcular los ahorros del año");

            while (mes <12)
            {
                Console.WriteLine($"Ingrese el ahorro del mes #{mes}");
                string entrada = Console.ReadLine();    

                AhorroMensual =double.Parse(entrada);
                AhorroTotal += AhorroMensual;
                Console.WriteLine($"Ahorro acumulado hasta el {mes}: {AhorroTotal}");
                mes++;
            }
            Console.WriteLine($"El ahorro total al finalizar el año es : {AhorroTotal}");
        }
    }
}
