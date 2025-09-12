namespace Taller_Parcial_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // punto 1.
            /*int Contador = 0;
            double Calificaciones = 0;
            double suma = 0;
            double promedio = 0;
            string respuesta = "";

            do
            {
                Console.WriteLine("ingrese una califacación: ");
                string entrada =Console.ReadLine();
                Calificaciones= double.Parse(entrada);

                suma += Calificaciones;
                Contador++;

                Console.WriteLine("¿Desea ingresar otra calificación? (s/n)");
                respuesta = Console.ReadLine();

            }while (respuesta == "s");
            Console.WriteLine($"contador: {Contador}, {suma}");

            if (Contador > 0)
            {
                promedio = suma / Contador;
                Console.WriteLine($"El promedio de las {Contador} calificaciones es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron califaciones");
            }*/

            // punto 2.
            /*string entrada = "";
            int numero = 0;
            int contador = 1;
            int divisores = 0;

            Console.WriteLine("Ingrese un número entero: ");
            entrada = Console.ReadLine();
            numero = int.Parse(entrada);

            Console.WriteLine("Los divisores de "+numero+" son:");

            do
            {
                if(numero %contador ==0)
                {
                    Console.WriteLine(contador);
                }
                contador++;

            }while (contador <= numero);*/

            //punto3.

            int Base = 0;
            string EntradaBase = "";
            int Exponente = 0;
            string EntradaExponente = "";
            int Contador = 0;
            int resultado = 0;
            string continuar = "";

            do
            {
                Console.WriteLine("Ingrese un número entero (Base): ");
                EntradaBase = Console.ReadLine();
                Base = int.Parse(EntradaBase);

                Console.WriteLine("Ingrese un número entero (Exponente): ");
                EntradaExponente = Console.ReadLine();
                Exponente = int.Parse(EntradaExponente);

                while (Contador <= Exponente)
                {
                    resultado = resultado * Base;
                    Contador++;
                }
                Console.WriteLine("Resultado de " + Base + +Exponente + "=" + resultado);
                Console.WriteLine("¿Desea continuar? ingrese 'n' para terminar, cualquier otra tecla para continuar");
                continuar = Console.ReadLine();
            }while (continuar == "n");
        }
    }
}
