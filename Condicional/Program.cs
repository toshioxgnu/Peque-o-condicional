using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad para poder ingresar a la pagina malula");
            edad = Console.Read();
            var edadint = Convert.ToInt32(edad);

            if (edadint < 18)
            {
                Console.WriteLine("Eres muy pequeño prueba de nuevo ");
                edad = Console.Read();
                edadint = Convert.ToInt32(edad);
            }
            else
            {
                Console.WriteLine("Asi me gusta una persona de avanzada edad ");
            }
        }
    }
}