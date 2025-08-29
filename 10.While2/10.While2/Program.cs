namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crear un algoritmo que permita calcular la factoeial de un número dado por el usuario. (5! = 1*2*3*4*5)

            int num = 0;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Ingrese un número para calcular su factorial");
            num= int.Parse(Console.ReadLine());

            while (contador <= num)
            {
                acumulador = acumulador * contador;
                Console.WriteLine($"C:{contador} - F:{acumulador}");
                contador++;
            }
            Console.WriteLine($"La factoria del número {num} es: {acumulador}");
        }
    }
}
