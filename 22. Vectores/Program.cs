namespace _22._Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos unidemensionales
            //Vectores
            int[] numeros = new int[5];

            string[] nombres = new string[4];
            nombres[0] = "Juan";
            nombres[1] = "Ana";
            nombres[2] = "Pedro";



            //Almacen datos
            numeros[0] = 12;
            numeros[1] = 32;
            numeros[2] = 41;
            numeros[3] = 100;
            numeros[4] = 56;
            // numeros[5] = 0; no se uede almacenar el dato porque la posicion con indice 5 no existe

            //Recuperar datos
            Console.WriteLine($"El valor almacenado en la posicion 4, con indice 3 es: " + numeros[3]);

            //Recorrer para almacenar
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el dato para la posicion: {i + 1}, con indice {i} ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //Otras formas de declarar e inicializar un vector
            char[] caracteres = new char[] { 'a', 'b', 'c', 'd', 'e','f', 'g' };
            float[] numeros2 = { 0.3f, 1.5f, 2.5f, 4.5f, 0.0f };    

            //Recorrer para recuperar datos almacenados
            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"La posicion: {i + 1}, con indice {i} es: {caracteres[i]}");
            }
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < numeros2.Length; i++)
            {
                Console.Write($"{numeros2[i]} | ");
            }
            //recorr
            for (int i = 0; i < nombres.Length; i++) 
            {
                Console.WriteLine($"Ingrese el nombre para la posicion: {i + 1}, con indice {i} ");
            }
        }
    }
}
