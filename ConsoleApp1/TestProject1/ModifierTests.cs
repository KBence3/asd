using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class ModifierTests
    {
        [Fact]
        public void TestGrowPerson()
        {
            Person p = new Person("Teszt Elek", 20, 180);
            double originalHeight = p.Height;
            PersonGrower grower = new PersonGrower{
                N = 5
            };
            grower.Modify(p);
            Assert.Equal(originalHeight + 5, p.Height);
        }
    }
}
