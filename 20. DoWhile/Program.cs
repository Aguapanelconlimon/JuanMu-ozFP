using System;

namespace _20._DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PartidosJugados = 30;
            int PartidosGanados = 0;
            int PartidosPerdidos = 0;
            int PartidosEmpatados = 0;
            Double porcentajeGanados = 0;
            Double porcentajePerdidos = 0;
            Double porcentajeEmpatados = 0;
            int contador = 0;

            do
            {
                Console.WriteLine("Partido #" + (contador + 1));
                Console.WriteLine("Ingrese el resultado (G/P/E): G ganado, P perdido, E empatado");
                string resultado = Console.ReadLine();

                PartidosGanados += Convert.ToInt32(resultado == "G" || resultado == "g");
                Console.WriteLine("partido ganados: " + PartidosGanados);
                PartidosPerdidos += Convert.ToInt32(resultado == "P" || resultado == "p");
                PartidosEmpatados += Convert.ToInt32(resultado == "E" || resultado == "e");
                contador++;
                Console.WriteLine();

            } while (contador < PartidosJugados);

            porcentajeGanados = (PartidosGanados *100) / PartidosJugados;
            porcentajePerdidos = (PartidosPerdidos *100) / PartidosJugados;
            porcentajeEmpatados = (PartidosEmpatados *100) / PartidosJugados;

            Console.WriteLine("Partidos Ganados: " + PartidosGanados + " - Porcentaje: " + porcentajeGanados + "%");
            Console.WriteLine("Partidos Perdidos: " + PartidosPerdidos + " - Porcentaje: " + porcentajePerdidos + "%");
            Console.WriteLine("Partidos Empatados: " + PartidosEmpatados + " - Porcentaje: " + porcentajeEmpatados + "%");
        }
    }
}
