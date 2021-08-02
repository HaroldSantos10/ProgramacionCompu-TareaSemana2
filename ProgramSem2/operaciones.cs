using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSem2
{
    class operaciones
    {
        static void Main(string[] args)
        {
            /*Solicitar a un usuario dos valores (a y b) y el programa
            mostrará el resultado de la operación (a+b)*(a-b) y el resultado
            dela  operación a2-b
             */
            
            double a, b;
            Console.WriteLine("Introduzca el valor de a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el valor de b");
            b = Convert.ToDouble(Console.ReadLine());

            double result1, result2;
            result1 = (a+b)*(a-b);
            result2 = (2 * a) - b;

            Console.WriteLine($"El resultado de la operación (a+b)*(a-b) es: {result1}");
            Console.WriteLine($"El resultado de la operación a2-b es: {result2}");

            Console.ReadKey();
        }

    }
}
