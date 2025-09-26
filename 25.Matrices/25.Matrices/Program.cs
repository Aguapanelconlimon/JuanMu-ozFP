namespace _25.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales - Matrices

            int[,] números = new int[2, 2]; //rango=fxc=2x2=4
            string[,] nombres = new string[3, 2];
            char[,] caracteres = new char[2, 4];
            bool[,] banderas = new bool[2, 5];
            object[,] objetos = new object[2, 5];

            //Asignación de valores con f,c

            números[0, 0] = 15;
            números[0, 1] = 25;
            números[1, 0] = 32;
            números[1, 1] = 4;
            números[1, 1] = 7;
            //numeros [1,2] = 7; Error por índices fuera de los rangos

            //Recuperar datos almacenados en una posición
            Console.WriteLine($"Valor almacenado en la posición del índice 1,0: {números[1, 0]}");

            //Declaración e inicialización de matrices con valores por defecto

            string[,] apellido =
            {
                {"chica","lopez","Alvarez" },
                {"Patiño","Ciro","Botero" },
                {"Duque","Carmona","Castaño" }
            };

            //Recorrer matrices para almacenar datos


            for (int i = 0; i < 3; i++)//ecorrer cada una de las filas
            {
                for (int j = 0; j < 2; j++)//recorrer las columnas
                {
                    Console.WriteLine($"Digite nombre para almacenarlo en la posición con índices {i},{j}: ");
                    nombres[i, j] = Console.ReadLine();
                }
            }

            //Recorrer para recuperar sus datos

            for (int i = 0; i < nombres.GetLength(0); i++)//.GetLength (0) devuelve el número de filas de la matris
            {
                for (int j = 0; j < nombres.GetLength(1); j++)//.Getlength (1) devuelve el número de columnas
                {
                    Console.Write($" {nombres[i, j]}   |");
                }
            }
            Console.WriteLine();

            for (char i = 'a'; i <2; i++)
            {
                for (char j='a'; j <4; j++)
                {
                    Console.Write($"Digite los caracteres para almacenarlos en la posicion de los indices {i},{j}: ");
                    caracteres[i,j] = Console.ReadLine();
                }
            }
            Console.WriteLine();
        }
    }
}
