using System.ComponentModel.Design;

namespace _4.CondicionalDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Crear un algoritmo */

            /*string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el suledo");
            sueldo = Int32.Parse (Console.ReadLine());

            if(sueldo>=3000)
            {
                //Verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //Falsa
                Console.WriteLine($"La persona {nombre}, no abona impuestos");
            }*/


            /*int Edad = 0;
            Console.WriteLine("Ingrese la edad");
            Edad = Int32.Parse (Console.ReadLine());
            if(Edad >= 18)
            {
                //Verdadera
                Console.WriteLine($"Bienvenido a mi sitio web");
            }
            else
            {
                //Falsa
                Console.WriteLine($"No es apto para el contenido de este sitio");
            }*/


            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Ingrese el numero 1");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero2");
            numero2 = Int32.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                //Verdadero
                Console.WriteLine(numero1 + numero2);
                Console.WriteLine(numero1 - numero2);  
            }
            else
            {
                //Falsa
                Console.WriteLine(numero2/numero1);
                Console.WriteLine(numero2 * numero1);
            }

         }
    }
}
