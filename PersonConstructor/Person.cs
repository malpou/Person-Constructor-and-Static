using System;
using System.Collections.Generic;

namespace PersonConstructor
{
    public class Person : IDisposable
    {
        private static List<bool> UsedCounter = new List<bool>();
        private static object Lock = new object();

        public int ID { get; set; }
        public Name Name { get; set; }
        public Adress Adress { get; set; }

        public Person(string firstName, string lastName, string streetName, int houseNumber, string city)
        {
            ID = GetID();
            Name = new Name(firstName, lastName);
            Adress = new Adress(streetName, houseNumber, city);
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"{ID}\t{Name.FirstName} {Name.LastName} | {Adress.StreetName} {Adress.HouseNumber} {Adress.City}");
        }

        public static void DisplayPerson(Person person)
        {
            Console.WriteLine($"{person.ID}/{UsedCounter.Count}\t{person.Name.FirstName} {person.Name.LastName}");
        }

        private int GetID()
        {
            lock (Lock)
            {
                int nextIndex = GetAvailableIndex();
                if (nextIndex == -1)
                {
                    nextIndex = UsedCounter.Count;
                    UsedCounter.Add(true);
                }

                return nextIndex + 1;
            }
        }

        public void Dispose()
        {
            lock (Lock)
            {
                UsedCounter[ID - 1] = false;
            }
        }

        private int GetAvailableIndex()
        {
            for (int i = 0; i < UsedCounter.Count; i++)
            {
                if (UsedCounter[i] == false)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
