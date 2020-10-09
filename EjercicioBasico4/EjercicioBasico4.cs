using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico4
{
    class EjercicioBasico4
    {
        static void Main(string[] args)
        {
            Int16 primer_numero = 0;
            Int16 segundo_numero = 0;
            Console.Write("Introduzca el primer númnero: ");
            primer_numero = Convert.ToInt16(Console.ReadLine());
            Console.Write("Introduzca el segundo númnero: ");
            segundo_numero = Convert.ToInt16(Console.ReadLine());

            if ((primer_numero % 2 == 0) && (segundo_numero % 2 == 0))
            {
                Console.WriteLine("Ambos números son pares");
            }
            else
            {
                Console.WriteLine("No son ambos números pares");
            }
        }
    }
}
