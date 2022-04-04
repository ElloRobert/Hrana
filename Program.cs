using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType Jabuka = new FoodType("jabuka", 10, 33, 33);
            Jabuka.Ispisi();
            Food Banana = new Food("Banana", 11, 35, 54,100);
            Food Piletina = new Food("Piletina", 50, 50, 0,100);
            Food Marelica = new Food("Marelica", 50, 1, 15,150);
         
            Marelica.Ispisi();
            Console.ReadKey();



        }
    }
}
