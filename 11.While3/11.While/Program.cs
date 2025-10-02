namespace _11.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero;

            Console.WriteLine("Ingrese números enteros positivos para sumar.");
            Console.WriteLine("Para terminar, ingrese un número negativo.");

            while (true)
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {                    
                    break;
                }

                suma += numero; 
            }

            Console.WriteLine($"La suma total de los números ingresados es: {suma}");
        }
    }
}
