namespace _19._DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalHombres = 0;
            int TotalMujeres = 0;
            int MayoresEdad = 0;
            int MenoresEdad = 0;
            int Contador = 0;

            do
            {
                Console.WriteLine("Alumno #" + (Contador + 1));
                Console.WriteLine("Ingrese el sexo: H para hombre, M para mujer");
                string sexo = Console.ReadLine();

                TotalHombres += Convert.ToInt32(sexo == "H" || sexo == "h");
                TotalMujeres += Convert.ToInt32(sexo == "M" || sexo == "m");

                Console.WriteLine("Ingrese la edad: ");

                string Edad = Console.ReadLine();
                MayoresEdad += Convert.ToInt32(Convert.ToInt32(Edad) >= 18);
                MenoresEdad += Convert.ToInt32(Convert.ToInt32(Edad) < 18);
                Contador++;

            } while (Contador < 10);

            Console.WriteLine("Total de hombres: " + TotalHombres);
            Console.WriteLine("Total de mujeres: " + TotalMujeres);
            Console.WriteLine("Total de mayores de edad: " + MayoresEdad);
            Console.WriteLine("Total de menores de edad: " + MenoresEdad);
        }
    }
}
