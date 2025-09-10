namespace ParcialCondicionales_JuanAlbertoMuñoz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sexo= "";
            int Edad = 0;
            int UltimoDigito = 0;
            bool DominaIngles = false;
            string Grupo ="";

            Console.WriteLine("ingrese su sexo: Masculino, Femenino");
            Sexo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ingrese su edad");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese ultimo digito del documento de identidad");
            UltimoDigito = int.Parse(Console.ReadLine());
           
            if (Edad == 15) 
            {
                Console.WriteLine("¿Domina el ingles? (si/no)");
                string ingles = Console.ReadLine();
                DominaIngles = (ingles == "si" || ingles == "si");
            }
            string grupo;
            // Grupo A
            if ((Sexo == "Femenino" && Edad >= 16 && Edad <= 20 && (UltimoDigito == 0 || UltimoDigito== 4 || UltimoDigito== 8)) || (Sexo == "Masculino" &&  Edad >= 18 && Edad <= 22 && (UltimoDigito == 1 || UltimoDigito == 5 || UltimoDigito == 9)))
            {
                Grupo = "A";
            }
            // Grupo B
            if ((Sexo == "Femenino" && Edad >= 21&& Edad <= 25 && (UltimoDigito == 3 || UltimoDigito == 7 )) || (Sexo == "Masculino" && Edad >= 23 && Edad <= 26 && (UltimoDigito == 2 || UltimoDigito == 6)))
            {
                Grupo = "B";
            }
            // Grupo C
           else if ( Edad == 15 && DominaIngles)
            {          
                Grupo = "C";
            }
            // Grupo D
            else
            {
                Grupo = "D";
            }

            Console.WriteLine($"La persona pertenece al grupo {Grupo}");
        }
    }
}
