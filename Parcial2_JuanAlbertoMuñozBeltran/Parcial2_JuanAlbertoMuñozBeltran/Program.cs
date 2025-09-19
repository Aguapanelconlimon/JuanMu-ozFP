using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;

namespace Parcial2_JuanAlbertoMuñozBeltran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//El almacén Oxford cuenta con los registros mensuales del número de ventas del año anterior y requiere un programa que procese esta información para evaluar el desempeño anual.
            El programa debe realizar las siguientes operaciones:
            Ingresar por teclado el número de ventas realizadas en cada mes(12 meses en total).
            Calcular el promedio anual de ventas.
            Determinar y mostrar el mes con mayor número de ventas.
            Determinar y mostrar el mes con menor número de ventas.
            Evaluar el promedio anual de ventas y mostrar un mensaje:
            Si el promedio es mayor a 500 ventas, mostrar: “Se aprobó la meta”.
            Si el promedio es menor o igual a 500 ventas, mostrar: “La meta de ventas no se cumplió”.*/



            int TotalVentas = 0;
            int MayorVentas = 0;
            int MenosVentas = 0;
            int MesMayor = 0;
            int MesMenor = 0;
            int Ventas = 0;
            int Mes = 1;
            int i = 0;
            double promedio = 0;

            for (Mes =1; Mes<=12; Mes++) 
            {
                Console.WriteLine($"Ingrese las ventas del mes"  + Mes +  " : ");
                Ventas = int.Parse(Console.ReadLine());
                
                              
                TotalVentas += Ventas;

                if (Mes == 1)
                {
                    MayorVentas = Ventas;
                    MenosVentas = Ventas;
                }
                else
                {
                    if (Ventas > MayorVentas)
                    {
                        MayorVentas = Ventas;
                        MesMayor = Mes;
                    }
                    if (Ventas < MenosVentas)
                    {
                        MenosVentas = Ventas;
                        MesMenor = Mes;
                    }
                }
                
            }

            promedio = TotalVentas / 12.0;
            Console.WriteLine($"Promedio anual de ventas: {promedio:f2}");
            Console.WriteLine($"Mes con mayor número de ventas: Mes"+MesMayor+" con "+MayorVentas+" ventas ");
            Console.WriteLine($"Mes con menor número de ventas: Mes" + MesMenor + " con " + MenosVentas + " Ventas ");


            if (promedio > 500)
            {
                Console.WriteLine("Se aprobó la meta");
            }
            else
            {
                Console.WriteLine("La meta de ventas no se cumplio");
            }
        }
    }
}
