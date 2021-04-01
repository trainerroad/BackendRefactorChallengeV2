namespace BikeDistributor.Domain
{
    public class OrderLine
    {
        public OrderLine(Bike bike, int quantity)
        {
            Bike = bike;
            Quantity = quantity;
        }

        public Bike Bike { get; }
        public int Quantity { get; }
    }
}
