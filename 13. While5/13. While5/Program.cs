namespace _13._While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribir un algoritmo que ceunta cúantos números pares hay en un rango de números del 1 al número n.

            int contador = 1;
            int cantidadPares = 0;
            int n = 0;

            Console.WriteLine("Ingrese el valor de n: ");
            n = int.Parse(Console.ReadLine());
            
            while (contador <= n)
            {
                    cantidadPares++;
                    contador += 2;
                
            }

            Console.WriteLine($"Cantidad de números pares entre 1 y {n} es: {cantidadPares}");
        }

    }
}
