namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permite generar primeros 5 números enteros positivos realizar y mostrar su suma.

            int contador = 1;
            int acumulador = 0;

            while (contador <=5)
            {
                acumulador += contador; // acumaldor =acumulador + contador
                Console.WriteLine($"C: {contador} - A: {acumulador}");
                contador++;
            }
            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");

        }
    }
}
