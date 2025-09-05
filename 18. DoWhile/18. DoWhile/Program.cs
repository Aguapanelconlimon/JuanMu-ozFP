namespace _18._DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            double acumulador = 0;
            string continuar = "";
            double Saldo = 0;

            do
            {
                Console.WriteLine("Ingrese el nombre del usuario: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el número de cuenta: ");
                string NumeroCuenta = Console.ReadLine();

                Console.WriteLine($"Ingrese su saldo");
                Saldo = double.Parse(Console.ReadLine());
            
            } while (contador > 0);
        }
    }
}
