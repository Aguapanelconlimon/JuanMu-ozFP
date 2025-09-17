namespace _24._vector2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int suma = 0;
            double promedio = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
            }
            promedio = suma / numeros.Length;
            Console.WriteLine($"El promedio de los números es: {promedio}");
        }
    }
}
