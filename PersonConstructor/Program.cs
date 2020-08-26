namespace PersonConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Malthe", "Poulsen", "En Vej", 3, "Byen");
            Person p2 = new Person("Jane", "Doe", "Ny Vej", 32, "Aarhus");
            Person p3 = new Person("Jim", "Not", "A Road", 999, "Florida");
            Person p4 = new Person("Annie", "Stevens", "Forest Road", 395, "Amazonas");


            p1.DisplayPerson();
            Person.DisplayPerson(p2);
            p3.DisplayPerson();
            Person.DisplayPerson(p4);
        }
    }
}
