using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hola pe Batedia, como te iamas?: ");
            string nombre = Console.ReadLine();

            Console.Write("tu edad p: ");
            int edad = Convert.ToInt32(Console.ReadLine());


            Console.Write("y mides?: ");
            decimal estatura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Mi nombre es {nombre}, mi edad es {edad} y mi estatura es {estatura:N2} ");



        }
    }
}
