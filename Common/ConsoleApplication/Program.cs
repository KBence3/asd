using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TrivialPersonSource létrehozása: 3 alkalommal adja vissza a saját adataidat
            IPersonSource trivialSource = new TrivialPersonSource(3);

            // AdvancedPersonSource létrehozása és feltöltése
            AdvancedPersonSource advancedSource = new();

            advancedSource.Add("Minta Mókus", 3, 41);
            advancedSource.Add("Kiss Anna", 22, 168);
            advancedSource.Add("Nagy Béla", 30, 182);
            advancedSource.Add("Szabó Péter", 27, 175);

            // TrivialPersonSource személyeinek kiírása
            Console.WriteLine("TrivialPersonSource:");
            foreach (Person person in trivialSource.GetPersons())
            {
                Console.WriteLine(person);
            }

            // AdvancedPersonSource személyeinek kiírása
            Console.WriteLine("\nAdvancedPersonSource:");
            foreach (Person person in advancedSource.GetPersons())
            {
                Console.WriteLine(person);
            }
        }
    }
}
