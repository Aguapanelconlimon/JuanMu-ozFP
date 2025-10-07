namespace _7._Operador_ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            string resultado = "";

            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            resultado = (edad >= 18) ? "Eres mayor de edad." : "Eres menor de edad.";

            Console.WriteLine($"{resultado}");
        }
    }
}
