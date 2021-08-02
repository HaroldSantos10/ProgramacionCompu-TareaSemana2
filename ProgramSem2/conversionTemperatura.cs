using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSem2
{
    class conversionTemperatura
    {
        static void Main(string[] args)
        { //programa que convierta de centigrados a fahrenheit
            double tempCentigrados, tempConvert;
            Console.WriteLine("Introduzca una temperatura en grados centigrados");
            tempCentigrados = Convert.ToDouble(Console.ReadLine());

            tempConvert = (tempCentigrados*1.8)+32;
            Console.WriteLine($"{tempCentigrados} grados centigrados son iguales a {tempConvert} grados fahrenheit");
        }
    }
}
