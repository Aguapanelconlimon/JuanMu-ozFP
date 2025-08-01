namespace _1._InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta es la declaración e inicialización de una variable
            string nombre = "Juan";
            const string iva = "19%";

            Console.Write("Hola, " + nombre + "\n");
            Console.Write("\tBienvenido a la clase de programación");
            nombre = "David";
            Console.Write("\n" + nombre);
            //iva = "20%"; no se puede cambiar el valor de una constante

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = 202321;
            long dato3 = -9258491783;
            double dato4 = 326.5689;
            char dato5 = '&';//Puede almacenar un solo caracter
            bool dato6 = false;//Almacena True or False
            object dato7 = new Program(); 
        }
    }
}