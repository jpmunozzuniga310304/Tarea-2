
//******************************************************** Ejercicio 2 ********************************************************
//*Desarrolle un algotitmo que calcule el promedio final para un estudiante del curso de Programación 1                       *
//* - Deberá leer los siguientes datos para cada estudiante: carnet, nombre, quiz 1, quiz 2, quiz 3,                          *
//*   tarea 1, tarea 2, tarea 3, examen 1, examen 2, examen3.                                                                 *
//* - Calcular el procentaje de quices (25%), porcentaje de tareas (30%), y el porcentaje de exámenes (45%)                   *
//* - Si el promedio final es mayor o igual a 70 "Aprobado", si el promedio final es mayor o iugal a 50 y menor que 70        *
//*   "Aplazado" y si el promedio final es menor que 50 "Reprobado".                                                          *
//*****************************************************************************************************************************

//Estudiante: José Pablo Muñoz Zúñiga
//Carrera: Igeniería Informática
//Materia: Programácion II

using System;
using System.Diagnostics.Eventing.Reader;
using System.Security;

namespace Calculeelpromediofinaldeunestudiantedelcursodeprogramación1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcule el promedio final de un estudiante del curso de programación 1
            //Digite el nombre de un estudiante
            Console.WriteLine("Digite el nombre: ");
            string nombre = Console.ReadLine();
            //Digite el carnet de un estudiante
            Console.WriteLine("Digite el carnet del estudiante: ");
            string carnetdelestudiante = Console.ReadLine();
            //Se calcula las notas del estudiante para descubir si aprobo o no
            //El porcentaje de los quices (25%), porcentaje de tareas (30%),y el porcentaje de los examenes (45%)
            int nota1, nota2, nota3, nota4, nota5, nota6, nota7, nota8 ,nota9;
            //Se calcula la primera nota del curso de programación 1
            Console.Write("Ingrese la nota del quiz 1: ");
            nota1 = int.Parse(Console.ReadLine());
            //Se calcula la segunda nota del curso de programación 1
            Console.Write("Ingrese la nota del quiz 2: ");
            nota2 = int.Parse(Console.ReadLine());
            //Se calcula la tercera nota del curso de programación 1
            Console.Write("Ingrese la nota del quiz 3: ");
            nota3 = int.Parse(Console.ReadLine());
            //Se calcula la cuarta nota del curso de programación 1
            Console.Write("Ingrese la nota de la tarea 1: ");
            nota4 = int.Parse(Console.ReadLine());
            //Se calcula la quinta nota del curso de programación 1
            Console.Write("Ingrese la nota de la tarea 2: ");
            nota5 = int.Parse(Console.ReadLine());
            //Se calcula la sexta nota del curso de programación 1
            Console.Write("Ingrese la nota de la tarea 3: ");
            nota6 = int.Parse(Console.ReadLine());
            //Se calcula la septima nota del curso de programación 1
            Console.Write("Ingrese la nota del examen 1: ");
            nota7 = int.Parse(Console.ReadLine());
            //Se calcula la octava nota del curso de programación 1
            Console.Write("Ingrese la nota del examen 2: ");
            nota8 = int.Parse(Console.ReadLine());
            //Se calcula la novena nota del curso de programación 1
            Console.Write("Ingrese la nota del examen 3: ");
            nota9 = int.Parse(Console.ReadLine());
            //En esta parte se descubre si el estudiante aprobo o no
            double promedio = Convert.ToDouble(nota1 + nota2 + nota3 + nota4+ nota5 + nota6 + nota7 + nota8 + nota9);
            promedio = Math.Round(promedio, 3);
            //En esta parte se descubre si el estudiante esta aprobado
            if (promedio >= 70)
            {
                Console.Write("La nota del estudiante es: " + promedio + " el estudiante aprobó.");
            }
            //En este parte se descubre si el estudiante esta aplazado
            else if (promedio >= 50)
            { 
                Console.Write("La nota del estudiante es: " + promedio + " el estudiante esta aplazado."); 
            }
            //En esta parte se descubre si el estudiante esta reprobado
            else
            {
                Console.Write("La nota del estudiante es: " + promedio + " el estudiante esta reprobado.");
            }
            Console.ReadKey();

       
        }
    }
}
