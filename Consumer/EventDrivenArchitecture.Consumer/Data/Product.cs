namespace EventDrivenArchitecture.Consumer.Data
{
    public class Product
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quality { get; set; }
        public int Quantity { get; set; }
    }
}
