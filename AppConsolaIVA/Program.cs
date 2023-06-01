using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoIVA;
namespace AppConsolaIVA
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bucle = 0;
            do
            {
                byte tipo = 0;
                Console.WriteLine("Escoge el tipo de IVA:\n1-Reducido\t2-Básico\tDefault- Genérico");
                Byte.TryParse(Console.ReadLine(), out tipo);
                double numero = -1;
                while (numero < 0)
                {
                    Console.WriteLine("Pon el precio con IVA");
                    Double.TryParse(Console.ReadLine(), out numero);
                }
                String opcion = "d";
                do
                {
                    Console.WriteLine("Escoge:\t'a' para calcular el precio original\n\t'b' para calcular el IVA\n\t'c' para mostrar ambos");
                    opcion = Console.ReadLine();
                } while (opcion != "a" && opcion != "b" && opcion != "c");

                Calculadora cal = new Calculadora(numero, tipo);
                switch (opcion)
                {
                    case "a": Console.WriteLine("El precio sin IVA es " + cal.totalSinIVA()); break;
                    case "b": Console.WriteLine("El IVA es un total de " + cal.IVA()); break;
                    case "c": Console.WriteLine("El precio sin IVA es " + cal.totalSinIVA() + " y el IVA es un total de " + cal.IVA()); break;
                    default:; break;
                }
                Console.WriteLine("Si quieres repetir, pulsa 1");
                Byte.TryParse(Console.ReadLine(), out bucle);
            } while (bucle == 1);
        }
    }
}
