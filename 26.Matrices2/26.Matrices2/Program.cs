namespace _26.Matrices2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 3];
            int[,] matrix2 = new int[2, 3];
            int[,] matrixSuma = new int[2, 3];

            Console.WriteLine($"Ingrese los elementos de la primera matriz: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Ingrese los elementos de la segunda matriz: ");
            for(int i = 0;i < 2; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]");
                    matrix2[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0;i<2;i++)
            {
                for (int j=0;j<3;j++)
                {
                    matrixSuma[i,j] = matrix[i,j] + matrix2[i,j];
                }
            }
            Console.WriteLine($"La matriz resultante de la suma de las dos matrices es: ");
            for ( int i = 0; i<2; i++)
            {
                for( int j = 0;j<3; j++)
                {
                    Console.Write($"{matrixSuma[i,j]}   |");
                }
            }
            Console.WriteLine();
        }
    }
}
