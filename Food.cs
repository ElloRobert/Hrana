using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrana
{
    /*internal*/ class Food:FoodType
    {


        public Food(string name, int protein, int carbs, int fat, int aWeight) :
            base(name,protein,carbs,fat)
        {
            
            weight = aWeight;

        }
      

        public FoodType type;
        public double weight { get; set; }

      

        public override void Ispisi()
        {
            base.Ispisi();
            Console.WriteLine("Masa namirnice je {0}",weight);
        }
        //Izracunavanje koliko grama proteina masti i uglijkohidrata ima proizvod navedene mase 
        /* public void Preracunaj()
         {
             double IznosProteina = (Convert.ToDouble(type.Protein) / 100) * weight;
             double IznosUgljkiohidrata = (Convert.ToDouble(type.Carbs) / 100) * weight;
             double IznosMasti = (Convert.ToDouble(type.Fat) / 100) * weight;
             Console.WriteLine("{0} mase {1} gram sadrzi {2} grama proteina, {3} grama ugljkiohidrata i {4} grama masti ",
                 type.Name, weight, IznosProteina, IznosUgljkiohidrata, IznosMasti);
         }*/
    }
}
