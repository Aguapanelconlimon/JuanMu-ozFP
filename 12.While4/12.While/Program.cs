namespace _12.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            
            for (int i = 1; i <= 99; i += 2)
            {
                suma += i;
            }

            Console.WriteLine($"La suma de todos los números impares hasta el 99 es: {suma}");
        }
    }
}
