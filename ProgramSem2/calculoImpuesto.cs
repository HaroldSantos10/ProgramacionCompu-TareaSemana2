using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSem2
{
    class calculoImpuesto
    {
        
        static void Main(string[] args)
        {
            /*Calcule el impuesto de un producto, pero coloque un impuesto
             del 0% si el producto es medicina
             */
            int numProduct;
            Console.WriteLine("Clasificación de productos según número: ");
            Console.WriteLine(
                "1- Alimentos" +
                " 2- Ropa" +
                " 3- Herramientas" +
                " 4- Medicina");

            Console.WriteLine("Nombre del producto: ");//por ejemplo camisas, aceite, martillo etc.
            string nombreProduct = Console.ReadLine();
            Console.WriteLine("Numero del tipo de producto: ");
            numProduct = int.Parse(Console.ReadLine());

            Console.WriteLine("El precio del producto: ");
            double precioProduct = double.Parse(Console.ReadLine());

            switch (numProduct)
            {
                case 1:
                    {
                        Console.WriteLine($"Producto: {nombreProduct}");
                        Console.WriteLine($"Precio: {precioProduct}");
                        
                        double impuesto = precioProduct * 0.05;
                        double precioMasImpuesto = precioProduct + impuesto;
                        Console.WriteLine($"Impuesto : ${impuesto}");
                        Console.WriteLine($"Total con impuesto: ${precioMasImpuesto}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Producto: {nombreProduct}");
                        Console.WriteLine($"Precio: {precioProduct}");

                        double impuesto = precioProduct * 0.10;
                        double precioMasImpuesto = precioProduct + impuesto;
                        Console.WriteLine($"Impuesto : ${impuesto}");
                        Console.WriteLine($"Total con impuesto: ${precioMasImpuesto}");
                        break;
                   
                    }
                case 3:
                    {
                        Console.WriteLine($"Producto: {nombreProduct}");
                        Console.WriteLine($"Precio: {precioProduct}");

                        double impuesto = precioProduct * 0.15;
                        double precioMasImpuesto = precioProduct + impuesto;
                        Console.WriteLine($"Impuesto : ${impuesto}");
                        Console.WriteLine($"Total con impuesto: ${precioMasImpuesto}");
                        break;
                   
                    }
                case 4:
                    {
                        Console.WriteLine($"Producto: {nombreProduct}");
                        Console.WriteLine($"Precio: {precioProduct}");

                        double impuesto = precioProduct * 0;
                        double precioMasImpuesto = precioProduct + impuesto;
                        Console.WriteLine($"Impuesto : ${impuesto}");
                        Console.WriteLine($"Total con impuesto: ${precioMasImpuesto}");
                        break;
                    }
                default:
                    Console.WriteLine("Lo sentimos el número de producto seleccionado es no es válido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
