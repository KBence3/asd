using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class PersonGrower : IPersonModifier
    {
        public double N { get; set; }

        public void Modify(Person person)
        {
            person.Height += N;
        }
    }
}
