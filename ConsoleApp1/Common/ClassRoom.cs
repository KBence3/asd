using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ClassRoom
    {
        private List<Person> people=new List<Person>();

        public void Add(Person person)
        {
            people.Add(person);
        }

        public int Count()
        {
            return people.Count;
        }

        public double GetAverageAge()
        {
            double osszeg = 0;
            for (int i = 0; i < people.Count; i++)
            {
                osszeg= osszeg + people[i].Age;
            }
            return osszeg / people.Count;
        }

        public Person GetTallestPerson()
        {
            Person tallest = people[0];
            for (int i = 1; i < people.Count; i++)
            {
                if (people[i].Height > tallest.Height)
                {
                    tallest = people[i];
                }
            }
            return tallest;
        }
    }
}
