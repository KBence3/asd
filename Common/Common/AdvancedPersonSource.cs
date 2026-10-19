using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    internal class AdvancedPersonSource
    {
        private readonly List<Person> persons = new List<Person>();

        public void Add(string name, int age, int height)
        {
            persons.Add(new Person
            {
                Name = name,
                Age = age,
                Height = height
            });
        }

        public IEnumerable<Person> GetPersons()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                yield return persons[i];
            }
        }
    }
}
