using System.Numerics;
using System.Runtime.Intrinsics;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.
             * int[] números = new int[15];
            int maximo = números [0];
            int minimo = números[0];

            Console.WriteLine("Ingrese 15 números enteros: ");

            for (int i = 0; i <números.Length; i++)
            {
                Console.WriteLine($"Número {i + 1}");
                números[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <números.Length; i++)
            {
                if(números[i] > maximo)
                {
                    maximo = números[i];
                }
                if(números [i] < minimo)
                {
                    minimo = números[i];
                }
            }
            Console.WriteLine($"El valor maximo es: {maximo}");
            Console.WriteLine($"El valor minimo es: {minimo}");*/

            /*//2.
            int tamaño = 10; 
            char[] caracteres = new char[tamaño];
            char[] invertido = new char[tamaño];

                 Console.WriteLine($"Ingrese {tamaño} caracteres:");

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Carácter {i + 1}: ");
                caracteres[i] = Console.ReadKey().KeyChar;
                Console.WriteLine(); 
            }
                        
            for (int i = 0; i < tamaño; i++)
            {
                invertido[i] = caracteres[tamaño - 1 - i];
            }
                        
            Console.WriteLine("Vector original:");

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write(caracteres[i] + " ");
            }
                        
            Console.WriteLine("\n\nVector invertido:");

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write(invertido[i] + " ");
            }*/

            //3.

            /*int[] Vector = new int[20];
            Random random = new Random();
            int numeroBuscado = 0;
            int posicion = -1;

            for (int i = 0; i < Vector.Length; i++)
            {
                Vector[i] = random.Next(0, 50);
            }

            Console.WriteLine("Vector generado: ");

            for (int i = 0;i < Vector.Length; i++)
            {
                Console.WriteLine(Vector[i]+"");
            }

            Console.WriteLine("Ingrese un número para buscar en el vector: ");
            numeroBuscado = int.Parse(Console.ReadLine());

            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] > numeroBuscado)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"Número encontrado en la posición: {posicion}");

                Console.WriteLine("Vector con el número resaltado:");

                for (int i = 0; i < Vector.Length; i++)
                {
                    if (Vector[i] == numeroBuscado)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Vector[i] + " ");
                        Console.ResetColor(); 
                    }
                    else
                    {
                        Console.Write(Vector[i] + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("-1 (El número no se encuentra en el vector)");
            }*/

            //4.

            /*int[] vector = new int[9];
            int tamaño = vector.Length;
            int posicionMedia = (tamaño - 1) / 2;
            int numero = 0;
            Random random = new Random();

            Console.WriteLine($"Ingrese número entero:");
            numero = int.Parse(Console.ReadLine());
            vector[posicionMedia] = numero;

            for (int i = 0; i < posicionMedia; i++)
            {
                vector[i] = numero - (random.Next(1, 10));
            }
            for (int i = posicionMedia + 1; i < tamaño; i++)
            {
                vector[i] = numero + (random.Next(1, 10));
            }

            Console.WriteLine("El vector generado es: ");

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write(vector[i] + " ");
            }                     
            */

            //5.

            int rango1 = 0;
            int rango2 = 0;
            int rangoCombinado = 0;
            Random random = new Random();

            Console.WriteLine("Ingrese el tamaño del primer rango:");
            rango1 = int.Parse(Console.ReadLine());
            int[] vector1 = new int[rango1];

            Console.WriteLine("Ingrese el tamaño del segundo rango:");
            rango2 = int.Parse(Console.ReadLine());
            int[] vector2 = new int[rango2];

            for (int i = 0; i < rango1; i++)
            {
                vector1[i] = random.Next(0, rango1 + 1);
            }

            for (int i = 0; i < rango2; i++)
            {
                vector2[i] = random.Next(0, rango2 * 2);
            }

            rangoCombinado = rango1 + rango2;
            int[] vectorCombinado = new int[rangoCombinado];

            for (int i = 0; i < rango1; i++)
            {
                vectorCombinado[i] = vector1[i];
            }
            for (int i = 0; i < rango2; i++)
            {
                vectorCombinado[rango1 + i] = vector2[i];
            }

            Console.WriteLine("Los vector combinados y generados son: ");

            Console.WriteLine("Vector 1: ");
            for (int i = 0; i < rango1; i++)
            {
                Console.Write(vector1[i] + " ");
            }

            Console.WriteLine("\nVector 2: ");
            for (int i = 0; i < rango2; i++)
            {
                Console.Write(vector2[i] + " ");
            }

            Console.WriteLine("\nVector Combinado: ");
            for (int i = 0; i < rangoCombinado; i++)
            {
                Console.Write(vectorCombinado[i] + " ");
            }

        }


    }
}
