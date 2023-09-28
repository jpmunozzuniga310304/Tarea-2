
//***************************** Ejercicio 3 *******************************
//Un vendedor ofrece su producto de la siguiente manera:                  *
// - Si le compran 10 productos o menos, el precio por producto es de $20 *
// - Si le compran más de 10 artículos, el precio es de $15 por artículo  *
//*************************************************************************

//Estudiante: José Pablo Muñoz Zúñiga 
//Carrera: Ingeniería Informática
//Materia: Programácion II

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventadeartículos
{
    internal class Program
    {
        //Proporcion de cantidad de productos y artículos
        static void Main(string[] args)
        {
            ushort productos, artículos;
            Console.WriteLine("Digite la cantidad de productos que deseas: ");
            productos = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de artículos que deseas: ");
            artículos = ushort.Parse(Console.ReadLine());
            Console.WriteLine(totaldeventas(productos,artículos));
            Console.ReadKey();

        }
        static string totaldeventas(ushort p, ushort a)
        {
            string cad;
            cad = ((p * 15) + (a * 20)).ToString();
            return cad;
        }
    }
}
