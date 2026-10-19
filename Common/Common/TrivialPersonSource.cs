using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class TrivialPersonSource : IPersonSource
    { 
        private readonly int _count;

        public TrivialPersonSource(int count)
        {
            _count = count;
        }

        public IEnumerable<Person> GetPersons()
        {
           for (int i = 0; i < _count; i++)
            {
                yield return Person.GetMe();
            }
        }

    }
}
