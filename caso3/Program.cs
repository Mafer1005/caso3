using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           float Costo,d1,depreciado, valorf;
            string calificacion;
            int vidaU, n;
            Console.WriteLine("Ingrese el costo inicial del producto: $");
            Costo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la vida util del producto en meses: ");
            vidaU = int.Parse(Console.ReadLine());
            Console.WriteLine("¿De cuantos meses desea hallar el valor depreciado?");
            n = int.Parse(Console.ReadLine());

            d1 = Costo = ((1 - 1 / vidaU) ^ n);
            depreciado = Costo - d1;
            valorf = (depreciado * 100) / Costo;
            if (valorf>= 0 && depreciado <= 500)
            {
                calificacion = "A";

                if (depreciado>500 && depreciado <= 750)
                {
                    calificacion = "B";
                }
                else if (valorf > 750)
                {
                    calificacion = "C";
                }
                
                Console.WriteLine("MES------------VALOR ACTUAL DEL PRODUCTO--------VALOR DEPRECIADO POR EL USO---------CALIFICACION");
                Console.WriteLine($"{n}------------------------{Costo}-------------------------------{valorf}--------------------------------{calificacion}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.ReadKey();





        }
    }
}
