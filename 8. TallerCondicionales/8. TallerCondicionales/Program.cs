namespace _8._TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.

            /*int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int mayor = 0;
            int medio = 0;
            int menor = 0;

            Console.Write("Ingresa el primer número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tercer número: ");
            numero3 = int.Parse(Console.ReadLine());
            
            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                mayor = numero1;
                if (numero2 > mayor) mayor = numero2;
                if (numero3 > mayor) mayor = numero3;

                Console.WriteLine($"El número mayor es: {mayor}");
                                
                if (numero1 < numero2 && numero1 < numero3)
                {
                    menor = numero1;
                    if (numero2 < numero3)
                    {
                        medio = numero2;
                        mayor = numero3;
                    }
                    else
                    {
                        medio = numero3;
                        mayor = numero2;
                    }
                }
                else if (numero2 < numero1 && numero2 < numero3)
                {
                    menor = numero2;
                    if (numero1 < numero3)
                    {
                        medio = numero1;
                        mayor = numero3;
                    }
                    else
                    {
                        medio = numero3;
                        mayor = numero1;
                    }
                }
                else
                {
                    menor = numero3;
                    if (numero1 < numero2)
                    {
                        medio = numero1;
                        mayor = numero2;
                    }
                    else
                    {
                        medio = numero2;
                        mayor = numero1;
                    }
                }

                Console.WriteLine("Números ordenados de menor a mayor:");
                Console.WriteLine($"{menor}, {medio}, {mayor}");
            }
            else
            {
                Console.WriteLine("Debes ingresar números diferentes.");
            }*/

            //2.

            /* int municion = 0;
             string estado = "";
             Random aleatoria = new Random();

             Console.WriteLine("¿El personaje está en estado invencible? (si/no): ");
             estado = Console.ReadLine();

             municion = aleatoria.Next(0,20);

             Console.WriteLine($"Cantidad de munición generada: {municion}");

             if (estado == "si" && municion >= 1 && municion <= 10)
             {
                 Console.WriteLine("El personaje está disparando.");
             }            
             else
             {
                 Console.WriteLine("El personaje NO puede disparar.");
             }*/

            //3.

            /*double x1 = 0;
            double x2 = 0;
            double x3 = 0;
            double y1 = 0;
            double y2 = 0;
            double y3 = 0;

            Console.Write("Ingrese x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese x3: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese y3: ");
            y3 = Convert.ToDouble(Console.ReadLine());
            
            double d12 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double d23 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double d13 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            Console.WriteLine();

            Console.WriteLine("Distancias:");
            Console.WriteLine("P1 -> P2: " + d12);
            Console.WriteLine("P2 -> P3: " + d23);
            Console.WriteLine("P1 -> P3: " + d13);
            
            if ((d12 + d23 > d13) && (d12 + d13 > d23) && (d13 + d23 > d12))
            {
                Console.WriteLine("Se puede formar un triángulo.");
            }
            else
            {
                Console.WriteLine("No se puede formar un triángulo. Faltan las siguientes condiciones:");

                if (!(d12 + d23 > d13))
                    Console.WriteLine("- d(P1->P2) + d(P2->P3) > d(P1->P3)");

                if (!(d12 + d13 > d23))
                    Console.WriteLine("- d(P1->P2) + d(P1->P3) > d(P2->P3)");

                if (!(d13 + d23 > d12))
                    Console.WriteLine("- d(P1->P3) + d(P2->P3) > d(P1->P2)");
            }*/

            //4.

            /*char tecla = ' ';

            Console.WriteLine("Presiona una tecla ('d' para derecha, 'i' para izquierda): ");
            tecla = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (tecla == 'd')
            {
                Console.WriteLine("El personaje se mueve hacia la derecha");
            }
            else if (tecla == 'i')
            {
                Console.WriteLine("El personaje se mueve hacia la izquierda");
            }
            else
            {
                Console.WriteLine("No me puedo mover en otra dirección");
            }*/

            //5.

            int vidas = 0;
            char accion = ' ';
            Random random = new Random();

            vidas = random.Next(0,6);

            Console.WriteLine($"Número de vidas del personaje: {vidas}");

            if(vidas > 0)
            {
                Console.Write("Ingrese una acción ('c', 'x', 't', 'i'): ");
                accion = Console.ReadKey().KeyChar;
                Console.WriteLine(); 

                if (accion == 'c')
                {
                    Console.WriteLine("El personaje está disparando");
                }
                else if (accion == 'x')
                {
                    Console.WriteLine("El personaje está hablando con la Rana");
                }
                else if (accion == 't')
                {
                    Console.WriteLine("El personaje está en modo Turbo");
                }
                else if (accion == 'i')
                {
                    Console.WriteLine("El personaje es Invencible");
                }
                else
                {
                    Console.WriteLine("Acción no reconocida");
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
            }



        }
    }
}
