namespace _16._While8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int número;
            Random rnd = new Random();
            número = rnd.Next(1, 101);
            
            int intentos = 0;

            Console.WriteLine("Adivina el número entre 1 y 100");

            while (intentos != número)
            {
                Console.WriteLine("Introduce tú numero: ");
                string entrada = Console.ReadLine();
                intentos = int.Parse(entrada);
                
                if (intentos<número)
                {
                    Console.WriteLine("Intento demasiado bajo");
                }
                else if (intentos>número)
                {
                    Console.WriteLine("Intento demasiado alto");
                }
                else
                {
                    Console.WriteLine("acertaste");

                }
            }
        }
    }
}
