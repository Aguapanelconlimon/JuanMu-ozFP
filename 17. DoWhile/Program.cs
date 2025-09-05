namespace _17._DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador=acumulador+contador;

            } while (contador < 5);
            Console.WriteLine("la suma de los cinco primeros números enteros es: "+acumulador);*/

            int numero = 0;
            int contador = 1;
            string respuesta = "";

            do
            {
                Console.WriteLine($"ingrese un número para calcular su tabla de multiplicar");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                    contador++;

                } while (contador <= 10);

                contador = 1;
                Console.WriteLine("Desea generar una nueva tabla de multiplicar; s: sí, n; no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");//Variable Bandera

            Console.WriteLine("Gracias por utilizarnos");
        }
    }
}
