using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }


        public static Person GetMe()
        {
            return new Person
            {
                Name = "Teszt Elek",
                Age = 25,
                Height = 180
            };
        }

        public override string ToString()
        {
            return $"{Name}, {Age} éves, {Height} cm magas";
        }
    }
}
