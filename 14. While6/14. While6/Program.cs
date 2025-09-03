namespace _14._While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0;
            int CantidadNúmeros = 0;
            int Número = 0;
            int Positivos= 0;
            int Negativo = 0;
            int Ceros = 0;


            Console.WriteLine("Cuantos numeros deseas ingresar: ");
            CantidadNúmeros = int.Parse(Console.ReadLine());

            while (Contador < CantidadNúmeros) 
            {
                Console.WriteLine($"Ingrese el número # {Contador + 1}:");
                Número = int.Parse(Console.ReadLine());

                if (Número >0)
                {
                    Positivos++;
                }
                else if (Número < 0)
                {
                    Negativo++; 
                }
                else
                {
                    Ceros++;
                }
                Contador++;
            }
            Console.WriteLine($"cantidad de números mayores que 0: {Positivos}");
            Console.WriteLine($"Cantidad de números menores que 0: {Negativo}");
            Console.WriteLine($"Cantidad de números iguales a 0: {Ceros}");

        }
    }
}
