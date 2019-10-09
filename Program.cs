using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            //serie fibonachi: 0, 1, 1, 2 3 5 8 13 21 34 55 89.....

            Console.WriteLine("Introduzca el valor hasta calcular la serie");
            string valor = Console.ReadLine();
            int numero = -1;
            try
            {
                 numero = Convert.ToInt32(valor);

            }
            catch (Exception)
            {
                Console.WriteLine("Debe introducir un numero: ");
                Console.ReadLine();
            }

            int a = 0;
            int b = 1;
            int suma = 0;

            string mostrarPantalla = string.Empty;
            mostrarPantalla ="0";

            while (suma <= numero)
            {
                suma = a + b;
                a = b;
                b = suma;
                mostrarPantalla += " " + suma; 
            }

            Console.WriteLine(mostrarPantalla);
            Console.ReadLine();
        }
    }
}
