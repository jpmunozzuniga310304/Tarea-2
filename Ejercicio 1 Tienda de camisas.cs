
//*********************************************** Ejercicio 1 ***********************************************
//*En esta tienda de camisas puede elegir la cantidad de camisas que deseas y tambien se hace un descuento: *
//* - Si la persona se lleva entre 2 y 5 camisas se le hace un descuento del 15%.                           *
//* - Si la persona se lleva más de 5 el descuento es de 20%.                                               *
//***********************************************************************************************************

//Estudiante: José Pablo Muñoz Zúñiga
//Carrera: Ingeniería Informática
//Materia: Programación II

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendadecamisas
{
    internal class Tiendadecamisas
    {
        static void Main(string[] args)
        {
            //Se va a descubir el numero de camisas, precio de camisas, descuento de camisas, al igual que el total
            double descuento, numero_de_camisas, precio_por_camisas, total;
            //Ingrese el numero de camisas que deseas comprar
            Console.Write("Ingrese el valor de numero de camisas: ");
            numero_de_camisas = double.Parse(Console.ReadLine());
            //Ingrese el precio del numero de camias que escogio
            Console.Write("Ingrese el valor de precio por camisas: ");
            precio_por_camisas = double.Parse(Console.ReadLine());
            //Se descubre tanto el precio de camisas y numero de camisas
            total = precio_por_camisas * numero_de_camisas;
            if (numero_de_camisas >= 5)
                descuento = total * 15;
            else
                descuento = total * 20;
            total = total - descuento;
            //Se descubre el descuento de las camisas escogidas
            Console.WriteLine("Valor de descuento: " + descuento);
            //Se descubre el total de las camisas escogidas
            Console.WriteLine("Valor de total: " + total);
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
