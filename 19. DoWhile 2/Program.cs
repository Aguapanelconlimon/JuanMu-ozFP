namespace _19._DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int TotalHombres = 0;
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
            Console.WriteLine("Total de menores de edad: " + MenoresEdad);*/

            int CantidadEstudiantes = 0;
            int Edad = 0;
            int genero = 0;
            int TotalHombres = 0;
            int TotalMujeres = 0;
            int MayoresEdad = 0;
            int MenoresEdad = 0;
            int cantidad = 0;

            do
            {
                Console.WriteLine($"Estudiante {CantidadEstudiantes}");
                Console.WriteLine("Ingrese la edad: ");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el genero: 1. Hombre 2. Mujer");
                genero = int.Parse(Console.ReadLine()); 

                if (genero == 1)
                {
                    TotalHombres++;
                }
                else 
                {
                    TotalMujeres++;
                }
                if (Edad >= 18)
                {
                    MayoresEdad++;
                }
                else
                {
                    MenoresEdad++;
                }
                CantidadEstudiantes++;
            }while (CantidadEstudiantes < cantidad);

            Console.WriteLine($"Total de hombres: {TotalHombres}");
            Console.WriteLine($"Total de mujeres: {TotalMujeres}");
            Console.WriteLine($"Total de mayores de edad: {MayoresEdad}");
            Console.WriteLine($"Total de menores de edad: {MenoresEdad}");

        }
    }
}
