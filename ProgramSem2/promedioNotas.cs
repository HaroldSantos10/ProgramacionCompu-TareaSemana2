using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSem2
{
    class promedioNotas
    {
        static void Main(string[] args)
        {
            /*Calcule la nota de un estudiante en base a 3 notas ingresadas
             cada nota equivale a 30%, 35% y 25%, deberá mostrar las notas
            ingresadas, notas con el porcentaje aplicado y la nota final.
             */
            double nota1, nota2, nota3;

            Console.WriteLine("Bienvenido, por favor intrduzca su nombre:");
            string nombreEstud = Console.ReadLine();

            Console.WriteLine("Nota 1 (30%)");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2 (35%)");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 3 (25%)");
            nota3 = double.Parse(Console.ReadLine());

            double notaPorcent1, notaPorcent2, notaPorcent3;

            notaPorcent1 = (nota1 * 0.30);
            notaPorcent2 = (nota2 * 0.35);
            notaPorcent3 = (nota3 * 0.25);

            double notaFinal = notaPorcent1 + notaPorcent2 + notaPorcent3;
            notaFinal = Math.Round(notaFinal,2);
            Console.WriteLine($"Nombre del estudiante: {nombreEstud}");
            Console.WriteLine($"Nota 1(30%): {nota1}  Nota 2(35%): {nota2}  Nota 3(25%): {nota3}");
            Console.WriteLine("             Notas con porcentaje aplicado        ");
            Console.WriteLine($"Nota 1(30%): {notaPorcent1}  Nota 2(35%): {notaPorcent2}  Nota 3(25%): {notaPorcent3}");
            Console.WriteLine($"NOTA FINAL: {notaFinal}");
            
            
            Console.ReadKey();
        }
    }
}
