using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad para poder ingresar a la pagina malula");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Eres muy pequeño prueba de nuevo ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Asi me gusta una persona de avanzada edad ");
            }
        }
    }
}