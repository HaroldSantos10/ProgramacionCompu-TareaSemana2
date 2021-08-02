using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSem2
{
    class dividirEnteros
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros,
            si el segundo no es cero mostrará el resultado de dividir entre el primero y el
            segundo.Por el contrario, si el segundo numero es cero, escribirá "Error:
            No se puede dividir entre cero".*/

            Int32 num1, num2;
            Console.WriteLine("A continuación proporcione un número entero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A continuación proporcione un número entero");
            num2 = Convert.ToInt32(Console.ReadLine());

            double resultado;
            if (num2 != 0)
            {
                resultado = (num1 / num2);
                Console.WriteLine($"El resultado de la división es: {resultado}");
                
            }
            if (num2 == 0)
            {
                Console.WriteLine("Error: no se puede dividir entre cero");
            }

            Console.ReadKey();
        }
       
    }
}
