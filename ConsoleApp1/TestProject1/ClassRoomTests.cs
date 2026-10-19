using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class ClassRoomTests
    {
        [Fact]
        public void TestAddition()
        {
            ClassRoom classRoom = new ClassRoom();
            classRoom.Add(Person.GetMe());
            classRoom.Add(Person.GetMe());
            classRoom.Add(Person.GetMe());
            Assert.Equal(3, classRoom.Count());
        }

        [Fact]
        public void TestHeightInClass()
        {
            ClassRoom classRoom = new ClassRoom();

            Person person1 = new Person("Aladár", 20, 170);
            Person person2 = new Person("Béla", 25, 180);

            classRoom.Add(person1);
            classRoom.Add(person2);

            // Növelés előtt Béla a legmagasabb
            Assert.Equal(person2, classRoom.GetTallestPerson());

            // Aladár magasságának növelése
            PersonGrower grower = new PersonGrower();
            grower.N = 20;
            grower.Modify(person1);

            // Növelés után Aladár a legmagasabb
            Assert.Equal(person1, classRoom.GetTallestPerson());
        }
    }
}
