namespace _21._For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for (int i = 1; i <=5; i++)
            {
                acumulador=acumulador+i;
            }
            Console.WriteLine($"La suma de los primeros 5 numeros es {acumulador}");
        }
    }
}
