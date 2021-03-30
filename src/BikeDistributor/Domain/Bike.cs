namespace BikeDistributor.Domain
{
    public class Bike
    {
        public const int OneThousand = 1000;
        public const int TwoThousand = 2000;
        public const int FiveThousand = 5000;

        public Bike(string brand, string model, int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public string Brand { get; }
        public string Model { get; }
        public int Price { get; set; }
    }
}
