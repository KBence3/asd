using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }


        public Person(string name, int age, double height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public static Person GetMe()
        {
            return new Person("Bence", 21, 180);
        }

        public string GetDescription()
        {
            return $"{Name} ({Height} cm) születésnapja 2003. 05. 15.";
        }
    }
}
