namespace ParcialArreglos_JuanAlbertoMuñoz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] departamentos = { "Marketing", "Contabilidad", "RecursosHumanos", "Distribución", "ingeniería", "Investigación" };
            string[] conceptosGastos = { "Salarios", "Suministros", "Mobiliario", "Equipamento", "Otros" };

            double[,] gastos = new double[6, 5];
            double[] vectorOtros = new double[6];
            
            Console.WriteLine("Ingrese los gastos para cada departamento y concepto:");
            for (int i = 0; i < departamentos.Length; i++)
            {
                for (int j = 0; j < conceptosGastos.Length; j++)
                {
                    double valor = -1;
                    while (valor < 0)
                    {
                        Console.Write($"Ingrese gastos para {departamentos[i]} en {conceptosGastos[j]}: ");
                        valor = Convert.ToDouble(Console.ReadLine());

                        if (valor < 0)
                        {
                            Console.WriteLine("El valor no puede ser negativo. Intente de nuevo.");
                        }
                    }

                    gastos[i, j] = valor;
                }
            }

            Console.WriteLine("Matriz de gastos: ");
            Console.Write("{0,-20}", "Departamento");
            for (int k = 0; k < conceptosGastos.Length; k++)
            {
                Console.Write("{0,-15}", conceptosGastos[k]);
            }
            Console.WriteLine();

            for (int i = 0; i < departamentos.Length; i++)
            {
                Console.Write("{0,-20}", departamentos[i]);
                for (int j = 0; j < conceptosGastos.Length; j++)
                {
                    Console.Write("{0,-15}", gastos[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Gastos totales por departamento: ");
            for (int i = 0; i < departamentos.Length; i++)
            {
                double totalDepartamento = 0;
                for (int j = 0; j < conceptosGastos.Length; j++)
                {
                    totalDepartamento += gastos[i, j];
                }
                Console.WriteLine($"{departamentos[i],-20}: {totalDepartamento}");
            }

            Console.WriteLine("Gastos totales por concepto: ");
            for (int j = 0; j < conceptosGastos.Length; j++)
            {
                double totalConcepto = 0;
                for (int i = 0; i < departamentos.Length; i++)
                {
                    totalConcepto += gastos[i, j];
                }
                Console.WriteLine($"{conceptosGastos[j],-15}: {totalConcepto}");
            }

            Console.WriteLine("Gastos total del año: ");
            for (int i = 0; i < departamentos.Length; i++)
            {
                double totalAño = 0;
                for (int j = 0; j < conceptosGastos.Length; j++)
                {
                    totalAño += gastos[i, j];
                }
            }

            Console.WriteLine("Vector de gastos 'Otros' por deártamento: ");
            for (int i = 0; i < departamentos.Length; i++)
            {
                vectorOtros[i] = gastos[i, 4];
                Console.WriteLine($"{departamentos[i],-20}: {vectorOtros[i]}");
            }

            double MayorGasto = gastos [0,0];
            int filaMayor = 0;
            int columnaMayor = 0;

            for (int i = 0; i < departamentos.Length; i++)
            {
                for (int j = 0; j < conceptosGastos.Length; j++)
                {
                    if (gastos[i, j] > MayorGasto)
                    {
                        MayorGasto = gastos[i, j];
                        filaMayor = i;
                        columnaMayor = j;
                    }
                }
            }

            Console.WriteLine("Mayor gasto registrado:");
            Console.WriteLine($"Valor: {MayorGasto}");
            Console.WriteLine($"Departamento: {departamentos[filaMayor]}");
            Console.WriteLine($"Concepto: {conceptosGastos[columnaMayor]}");
        }
    }
}
