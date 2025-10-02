namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            /* int filas = 10;
             int columnas = 20;
             int[,] matriz = new int[filas, columnas];
             Random random = new Random();

             for (int i =0; i < filas; i++)
             {
                 for (int j =0; j < columnas; j++)
                 {
                     matriz[i, j] = random.Next(1, 5);
                 }
             }

             Console.WriteLine("Matriz Generada:");
             for (int i = 0; i < filas; i++)
             {
                 for (int j = 0; j < columnas; j++)
                 {
                     Console.Write($"{matriz[i, j],4}");
                 }
                 Console.WriteLine();
             }

             Console.WriteLine("Suma de los elementos de cada columna: ");
             for (int j = 0; j < columnas; j++)
             {
                 int sumaColumna = 0;
                 for (int i = 0; i < filas; i++)
                 {
                     sumaColumna += matriz[i, j];
                 }
                 Console.WriteLine($"Columna {j + 1}: {sumaColumna}");*/


            //2. 

            /*int n = 0;
            int m = 0;


            Console.Write("Ingrese el número de filas (n): ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas (m): ");
            m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];
            char[,] matrizOriginal = new char[n, m];

            Console.WriteLine("Ingrese los caracteres para llenar la matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                    Console.WriteLine($"[{i},{j}]");
                    matrizOriginal[i, j] = matriz[i, j];
                }
            }

            Console.WriteLine($"Matriz Original:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrizOriginal[i, j],4}");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = temp;
            }
            

            Console.WriteLine($"Matriz con filas intercambiadas:");
            for (int i = 0; i < n;i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriz[i, j],4}");
                }
                Console.WriteLine();
            }*/

            //3.

            /*int filas = 5;
            int columnas = 5;
            int[,] matriz = new int[filas, columnas];
            int[] frecuencias = new int[10];
            Random random = new Random();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = random.Next(1, 11);
                    
                }
            }

            Console.WriteLine("Matriz Generada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j],4}");
                    
                }
                Console.WriteLine();
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int numero = matriz[i, j];
                    frecuencias[numero - 1]++;
                }
            }

            Console.WriteLine("Frecuencia de los números del 1 al 10:");
            for (int i = 0; i < frecuencias.Length; i++)
            {
                Console.WriteLine($"Número {i + 1}: {frecuencias[i]} veces");
            }*/

            //4.

            /*int filas = 5;
            int columnas = 5;
            char[,] tablero = new char[filas, columnas];
            Random random = new Random();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tablero[i, j] = '-';
                }
            }

            int xColocadas = 0;
            while (xColocadas < 3)
            {
                int fila = random.Next(0, filas);
                int columna = random.Next(0, columnas);

                if (tablero[fila, columna] != 'X')
                {
                    tablero[fila, columna] = 'X';
                    xColocadas++;
                }
            }

            Console.WriteLine("¡Bienvenido al juego de Buscaminas!");
            Console.WriteLine("Intenta adivinar donde estan las minas (X)");

            Console.WriteLine("Ingrese la fila (0 a 4): ");
            int filaUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la columna (0 a 4): ");
            int columnaUsuario = int.Parse(Console.ReadLine());

            if (tablero[filaUsuario, columnaUsuario] == 'X')
            {
                Console.WriteLine("Felicidades ¡Has encontrado una mina! !");
            }
            else
            {
                Console.WriteLine("Lo siento. No has encontrado una mina. ¡Sigue intentando!");
            }

            Console.WriteLine("Tablero con las (X) reveladas:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{tablero[i, j],4}");
                }
                Console.WriteLine();
            }*/


            //5.
            /*int filas = 0;
            int columnas = 0;

            Console.WriteLine("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] matrizNueva = new int[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizNueva[j, i] = matriz[i, j];
                }
            }

            Console.WriteLine("\nMatriz transpuesta:");
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.Write(matrizNueva[i, j] + "\t");
                }
                Console.WriteLine();
            }*/

            //6.

            int filas = 0;
            int columnas = 0;
            int numero = 0;
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;
            Random random = new Random();

            Console.WriteLine("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    numero = random.Next(0, 4);
                    matriz[i, j] = numero;

                    if (numero == 1) contador1++;
                    else if (numero == 2) contador2++;
                    else if (numero == 3) contador3++;
                }

            }

            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nEl número 1 aparece {contador1} veces.");
            Console.WriteLine($"El número 2 aparece {contador2} veces.");
            Console.WriteLine($"El número 3 aparece {contador3} veces.");

            Console.Write("El número más repetido es: ");

            if (contador1 > contador2 && contador1 > contador3)
            {
                Console.WriteLine("1");
            }
            else if (contador2 > contador1 && contador2 > contador3)
            {
                Console.WriteLine("2");
            }
            else if (contador3 > contador1 && contador3 > contador2)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.Write("Empate entre: ");
                if (contador1 == contador2 && contador1 > contador3)
                {
                    Console.WriteLine("1 y 2");
                }
                else if (contador1 == contador3 && contador1 > contador2)
                {
                    Console.WriteLine("1 y 3");
                }
                else if (contador2 == contador3 && contador2 > contador1)
                {
                    Console.WriteLine("2 y 3");
                }
                else if (contador1 == contador2 && contador1 == contador3)
                {
                    Console.WriteLine("1, 2 y 3");
                }

            }
        }
    }
}
