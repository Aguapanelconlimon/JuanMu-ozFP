namespace TallerProgModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1.

            string palabra = ingresarPalabra();
            char[] vector = convertirVector(palabra);

            int vocales = contarVocales(vector);
            int consonantes = contarConsonantes(vector);

            Console.WriteLine($"La palabra igresada es: {palabra}");
            Console.WriteLine($"La cantidad de vocales es: {vocales}");
            Console.WriteLine($"La cantidad de consonantes es: {consonantes}");
        }

        static string ingresarPalabra()
        {
            Console.WriteLine("Ingrese una palabra: ");
            return Console.ReadLine().ToLower();

        }
        static char[] convertirVector(string palabra)
        {
            char[] vector = new char[palabra.Length];
            for (int i = 0; i < palabra.Length; i++)
            {
                vector[i] = palabra[i];
            }
            return vector;
        }
        static int contarVocales(char[] vector)
        {
            int contador = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                char c = vector[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    contador++;
                }

            }
            return contador;

        }

        static int contarConsonantes(char[] vector)
        {
            int contador = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                char c = vector[i];
                if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')


                {
                    contador++;
                }
            }
            return contador;*/

            //2.

            /*string[] tareas = new string[10];
            int cantidad = 0;
            int opcion;

            do
            {
                opcion = mostrarMenu();
                if (opcion == 1)
                {
                    cantidad = agregarTarea(tareas, cantidad);
                }
                else if (opcion == 2)
                {
                    cantidad = eliminarTarea(tareas, cantidad);
                }
                else if (opcion == 3)
                {
                    mostrarTareas(tareas, cantidad);
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }
                Console.WriteLine();

            } while (opcion != 4);
            {
                Console.WriteLine("Saliendo del programa...");
            }

            static int mostrarMenu()
            {
                Console.WriteLine("Menú de Tareas:");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Mostrar tareas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());
                return opcion;
            }

            static int agregarTarea(string[] tareas, int cantidad)
            {
                if (cantidad < tareas.Length)
                {
                    Console.Write("Ingrese la tarea a agregar: ");
                    tareas[cantidad] = Console.ReadLine();
                    cantidad++;
                    Console.WriteLine("Tarea agregada exitosamente.");
                }
                else
                {
                    Console.WriteLine("No se pueden agregar más tareas.");
                }
                return cantidad;
            }

            static int eliminarTarea(string[] tareas, int cantidad)
            {
                if (cantidad > 0)
                {
                    Console.Write("Ingrese el número de la tarea a eliminar (1 a {0}): ", cantidad);
                    int numero = int.Parse(Console.ReadLine());
                    if (numero >= 1 && numero <= cantidad)
                    {
                        for (int i = numero - 1; i < cantidad - 1; i++)
                        {
                            tareas[i] = tareas[i + 1];
                        }
                        tareas[cantidad - 1] = null;
                        cantidad--;
                        Console.WriteLine("Tarea eliminada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarea inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay tareas para eliminar.");
                }
                return cantidad;
            }

            static void mostrarTareas(string[] tareas, int cantidad)
            {
                if (cantidad > 0)
                {
                    Console.WriteLine("Lista de Tareas:");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("{0}. {1}", i + 1, tareas[i]);
                    }
                }
                else
                {
                    Console.WriteLine("No hay tareas para mostrar.");
                }
            }*/

            //3.

            /*int tipo = ElegirMedida();
            int opcion = ElegirConversion(tipo);
            double valor = IngresarValor();
            RealizarConversion(tipo, opcion, valor);
        }

        static int ElegirMedida()
        {
            Console.WriteLine("======Conversor de Medidas======");
            Console.WriteLine("1. Masa");
            Console.WriteLine("2. Capacidad");
            Console.WriteLine("3. Longitud");
            Console.WriteLine("4. Tiempo");
            Console.Write("Elija el tipo de medida que desea convertir: ");
            int tipo = int.Parse(Console.ReadLine());
            return tipo;
        }

        static int ElegirConversion(int tipo)
        {
            int opcion = 0;

            if (tipo == 1)
            {
                Console.WriteLine("1. Kilogramos a Gramos");
                Console.WriteLine("2. Gramos a kilogramos");
            }
            else if (tipo == 2)
            {
                Console.WriteLine("1. Litros a mililitros");
                Console.WriteLine("2. Mililitros a litros");
            }
            else if (tipo == 3)
            {
                Console.WriteLine("1. Kilómetros a metros");
                Console.WriteLine("2. Metros a kilómetros");

            }
            else if (tipo == 4)
            {
                Console.WriteLine("1. Horas a segundos");
                Console.WriteLine("2. Segundos a horas");
            }
            else
            {
                Console.WriteLine("Tipo de medida inválido.");
                return 0;
            }
            Console.Write("Elija la conversión que desea realizar: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return opcion;
        }

        static double IngresarValor()
        {
            Console.Write("Ingrese el valor a convertir: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine();
            return valor;
        }

        static void RealizarConversion(int tipo, int opcion, double valor)
        {
            double resultado = 0;
            string unidadOrigen = "";
            string unidadDestino = "";

            if (tipo == 1)
            {
                if (opcion == 1)
                {
                    resultado = valor * 1000;
                    unidadOrigen = "kilogramos";
                    unidadDestino = "gramos";
                }
                else if (opcion == 2)
                {
                    resultado = valor / 1000;
                    unidadOrigen = "gramos";
                    unidadDestino = "kilogramos";
                }
                else
                {
                    Console.WriteLine("Opción de conversión inválida.");
                    return;
                }
            }
            else if (tipo == 2)
            {
                if (opcion == 1)
                {
                    resultado = valor * 1000;
                    unidadOrigen = "litros";
                    unidadDestino = "mililitros";
                }
                else if (opcion == 2)
                {
                    resultado = valor / 1000;
                    unidadOrigen = "mililitros";
                    unidadDestino = "litros";
                }
                else
                {
                    Console.WriteLine("Opción de conversión inválida.");
                    return;
                }
            }
            else if (tipo == 3)
            {
                if (opcion == 1)
                {
                    resultado = valor * 1000;
                    unidadOrigen = "kilómetros";
                    unidadDestino = "metros";
                }
                else if (opcion == 2)
                {
                    resultado = valor / 1000;
                    unidadOrigen = "metros";
                    unidadDestino = "kilómetros";
                }
                else
                {
                    Console.WriteLine("Opción de conversión inválida.");
                    return;
                }
            }
            else if (tipo == 4)
            {
                if (opcion == 1)
                {
                    resultado = valor * 3600;
                    unidadOrigen = "horas";
                    unidadDestino = "segundos";
                }
                else if (opcion == 2)
                {
                    resultado = valor / 3600;
                    unidadOrigen = "segundos";
                    unidadDestino = "horas";
                }
                else
                {
                    Console.WriteLine("Opción de conversión inválida.");
                    return;
                }
            }

            Console.WriteLine($"{valor} {unidadOrigen} son {resultado} {unidadDestino}.");*/


            //4.

            int filas = 2;
            int columnas = 3;
            string[,] contactos = new string[filas, columnas];

            LLenarMatriz(contactos, filas, columnas);
            BuscarReemplazar(contactos, filas, columnas);

            Console.WriteLine("Matriz de contactos actualizada:");
            MostrarMatriz(contactos, filas, columnas);
        }

        static void LLenarMatriz(string[,] matriz, int filas, int columnas)
        {
            Console.WriteLine("Ingrese datos de los contactos:");
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write($"Ingrese el valor para la posición [{f}, {c}]: ");
                    matriz[f, c] = Console.ReadLine();
                }
            }
        }

        static void BuscarReemplazar(string[,] matriz, int filas, int columnas)
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine();
            Console.Write("Ingrese el nuevo número de teléfono: ");
            string nuevoTelefono = Console.ReadLine();

            bool encontrado = false;
            int fila = -1;
            int columna = -1;

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    if (matriz[f,c].ToLower() == nombreBuscar.ToLower())
                    {
                        encontrado = true;
                        fila = f;
                        columna = c;
                        break;
                    }
                }
                if(encontrado)
                {
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"Nombre encontrado en la posición [{fila}, {columna}].");
                string nuevoNombre = Console.ReadLine();
                matriz[fila, columna] = nuevoNombre;

                Console.WriteLine($"El nombre'{nombreBuscar}' ha sido reemplazado por '{nuevoNombre}' en la posición [{fila}, {columna}].");
            }
            else
            {
                Console.WriteLine($"El nombre '{nombreBuscar}' no fue encontrado en la matriz.");
            }
        }

        static void MostrarMatriz(string[,] matriz, int filas, int columnas)
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
