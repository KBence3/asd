using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Tests
{
    public class TrivialPersonSourceTests
    {
        [Fact]
        public void TestCount()
        {
            IPersonSource source = new TrivialPersonSource(12);
            int count = source.GetPersons().Count();
            Assert.Equal(12, count);
        }
    }
}
