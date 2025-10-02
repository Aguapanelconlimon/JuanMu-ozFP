using System.Runtime.ConstrainedExecution;

namespace _28._Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
            int positivo = 0;
            int negativo = 0;
            int cero = 0;

            Console.WriteLine("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("Ingrese los números para cada posición de la matriz: ");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    // 3. Contar según el valor
                    if (matriz[i, j] > 0)
                        positivo++;
                    else if (matriz[i, j] < 0)
                        negativo++;
                    else
                        cero++;
                }
            }

            Console.WriteLine("Resultados:");
            Console.WriteLine($"Cantidad de números positivos: {positivo}");
            Console.WriteLine($"Cantidad de números negativos: {negativo}");
            Console.WriteLine($"Cantidad de ceros: {cero}");
        }
    }
}
