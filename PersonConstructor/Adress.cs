namespace PersonConstructor
{
    public class Adress
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public string City { get; set; }

        public Adress(string streetName, int houseNumber, string city)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
            City = city;
        }
    }
}
