namespace _23._Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
            }
            for (int i = 0;i < numeros.Length; i++)
            {
                Console.WriteLine($"Elemento {i+1}:{numeros[i]}");
            }
        }
    }
}
