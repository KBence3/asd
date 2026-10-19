using System;
using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintAndModify(IPersonModifier modifier)
        {
            Person person = Person.GetMe();

            for (int i = 0; i < 10; i++)
            {
                modifier.Modify(person);
                Console.WriteLine(person.GetDescription());
            }
        }

        static void Main(string[] args)
        {
            PersonGrower grower = new PersonGrower();
            grower.N = 0.05;

            PrintAndModify(grower);
        }
    }
}
