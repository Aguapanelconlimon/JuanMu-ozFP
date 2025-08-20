namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicional Multiple

            /* float ValorCompra = 0;
             float Descuento = 0;
             char dia = ' ';

             Console.WriteLine("Ingrese el valor de la compra");
             ValorCompra = Single.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el día de la semana: l: lunes, m: martes, x: miércoles, j: jueves, v: viernes, s: sábado, d: domingo");
             dia = Convert.ToChar(Console.ReadLine());

             switch (dia)
             {
                 case 'l':
                     Descuento = ValorCompra * 0.1f;
                     Console.WriteLine(($"Hoy es lunes, descuento: {Descuento}, valor a pagar: {ValorCompra - Descuento}"));
                     break;
                 case 'm':
                     Descuento = ValorCompra * 0.15f;
                     Console.WriteLine(($"Hoy es martes, descuento: {Descuento}, valor a pagar: {ValorCompra - Descuento}"));
                     break;
                 case 'x':
                    Descuento = ValorCompra * 0.1f;
                     Console.WriteLine(($"Hoy es miércoles, descuento: {Descuento}, valor a pagar: {ValorCompra - Descuento}"));
                     break;
                 case 'j':
                     Descuento = ValorCompra * 0.15f;
                     Console.WriteLine(($"Hoy es jueves, descuento: {Descuento}, valor a pagar: {ValorCompra - Descuento}"));
                     break;
                 case 'v':
                     Descuento = ValorCompra * 0.2f;
                     Console.WriteLine(($"Hoy es viernes, descuento: {Descuento}, valor a pagar: {ValorCompra - Descuento}"));
                     break;
                 case 's':
                     Descuento = ValorCompra * 0.2f;
                     Console.WriteLine(($"Hoy es sábado, descuento: {Descuento}, valor a pagar: {ValorCompra - Descuento}"));
                     break;
                 case 'd':
                     Descuento = ValorCompra * 0;
                     Console.WriteLine(($"Hoy es domingo, descuento: {Descuento}, valor a pagar: {ValorCompra - Descuento}"));
                     break;
                 default:
                     Console.WriteLine("Debe ingresar un valor válido");
                     break;

             }*/

            float Valor1 = 0;
            float Valor2 = 0;
            float Resultado = 0;
            char Operación = ' ';

            Console.WriteLine("Ingrese el valor1");
            Valor1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor2");
            Valor2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la operación que desea realizar: +: suma, -: resta, *:multiplicación, /:división");
            Operación = Convert.ToChar(Console.ReadLine());

            switch (Operación)
            {
                case '+':
                    Resultado= Valor1 + Valor2;
                    Console.WriteLine($"la operación suma es igual: {Valor1 + Valor2}");
                    break;
                case '-':
                    Resultado= Valor1 - Valor2;
                    Console.WriteLine($"la operación resta es igual: {Valor1 - Valor2}");
                    break;
                case '*': 
                    Resultado = Valor1 * Valor2;
                    Console.WriteLine($"la operación multiplicación es igual: {Valor1 * Valor2}");
                    break;
                case '/':
                    Resultado = Valor1 / Valor2;
                    Console.WriteLine($"la operación división es igual: {Valor1 / Valor2}");
                    break;
                default:
                    Console.WriteLine("ingrese un valor valido");
                    break;
            }

        }
    }
}
