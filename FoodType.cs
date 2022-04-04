using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrana
{
    /*public abstract*/ class FoodType
    {
        //Varijable
        private string name;
        private int protein;
        private int carbs;
        private int fat;
        private int postotak = 100;
        public static int brojac = 0;


        // Konstruktor
        public FoodType(string aname, int aprotein, int acarbs, int afat)
        {
            name = aname;
            Protein = aprotein;
            Carbs = acarbs;
            Fat = afat;
            brojac++;

        }
        // Get i Set za sve parametre koji se unose!
        public string Name { get { return name; } }
        public int Protein
        {
            get { return protein; }
            set
            {
                if (value < 100 && postotak - value >= 0)
                {
                    protein = value;
                    postotak = postotak - value;
                }
                else
                {
                    protein = 0;
                    Console.WriteLine("Unijeli ste neispravan podatak o vrijednosti Proteina");

                }
            }
        }

        public int Carbs
        {
            get { return carbs; }
            set
            {
                if (value < 100 && postotak - value >= 0)
                {
                    carbs = value;
                    postotak = postotak - value;
                }
                else
                {
                    carbs = 0;
                    Console.WriteLine("Unijeli ste neispravan podatak o vrijednosti Carbsa");

                }
            }
        }
        public int Fat
        {
            get { return fat; }
            set
            {
                if (value < 100 && postotak - value >= 0)
                {
                    fat = value;
                    postotak = postotak - value;
                }
                else
                {
                    fat = 0;
                    Console.WriteLine("Unijeli ste neispravan podatak o vrijednosti Masti");

                }
            }
        }


        //Ispis
        public virtual void Ispisi()
        {
            Console.WriteLine("Ostatak proizvoda {0}% nepoznate je vrste ", postotak);
            Console.WriteLine("{0}ima {1}% proteina, {2}% ugljikohidrata, {3}%masti", name, protein, carbs, fat);
        }

        public void Brojac()
        {
            Console.WriteLine("Unijeli ste {0} prehrambenih proizvoda", brojac);
        }
    }
}
