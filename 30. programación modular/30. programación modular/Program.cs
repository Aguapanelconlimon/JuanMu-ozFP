namespace _30._programación_modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                mostrarmenu();
                opcion = int.Parse(Console.ReadLine());

                if( opcion == 1 )
                {
                    RealizarOperaciones(opcion );
                }
                else if( opcion != 5)
                {
                    Console.WriteLine("Opción invalida. Intente nuevamente");
                }
            }while( opcion != 5);

            Console.WriteLine("Gracias porusar la calculadora. ¡Hasta luego!");
        }

        static void mostrarmenu()
        {
            Console.WriteLine("====MENÚ DE OPERACIONES====");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void RealizarOperaciones(int opcion)
        {
            switch( opcion)
            {
                case 1:
                    sumar();
                    break;
                case 2:
                    restar();
                    break;
                case 3:
                    multiplicar();
                    break;
                case 4:
                    dividir();
                    break;
            }
        }

        static void sumar()
        {
            int cantidad = 0;
            double numero = 0;
            double sumar = 0;

            Console.WriteLine("¿Cuántos números desea sumar?");
            cantidad = int.Parse(Console.ReadLine());

            for(int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Ingrese el número" + i + ":");
                numero = double.Parse(Console.ReadLine());
                sumar += numero;
            }

            Console.WriteLine("La suma total es: " + sumar);
            
        }

        static void restar()
        {
            double num1 = 0;
            double num2 = 0;
            double restar = 0;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            restar = num1 - num2;
            Console.WriteLine("El resultado de la resta es: " + restar);
        }

        static void multiplicar()
        {
            int cantidad = 0;
            double numero = 0;
            double producto = 0;

            Console.WriteLine("¿Cuántos números desea multiplicar? ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 1;i <= cantidad;i++)
            {
                Console.WriteLine("Ingrese el número " + i +":");
                numero = double.Parse(Console.ReadLine());
                producto *= numero;
            }
            Console.WriteLine("El producto es: " + producto);
        }

        static void dividir()
        {
            double num1 = 0;
            double num2 = 0;
            double dividir = 0;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = double.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            if (num2!=0)
            {
                dividir = num1 / num2;
                Console.WriteLine(num1 + "/" + num2 + "=" + dividir);
            }
            else
            {
                Console.WriteLine("Error: no se puede dividir");
            }

        }
    }
}
