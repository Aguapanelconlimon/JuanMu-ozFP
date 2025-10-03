namespace _28._ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            Console.WriteLine();
            MostrarMensaje("Soy Juan");
            MostrarMensaje($"Tengo {CalcularEdad()} años");
            MostrarMensaje($"Tengo {CalcularEdad(2025, 1895)} años");
        }

        //Modúlo 1 - Procedimiento sin parámetros

        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la Programación Modular");
            Console.WriteLine("Estoy siendo llamado desde MostrarMensaje()");
        }

        //Módulo 2 - Procedimiento con parámetros

        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Función sin parámetros

        static int CalcularEdad()
        {
            int edad = 2025 - 1999;
            return edad;
        }

        //Módulo 4 - Función con parámetros

        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
