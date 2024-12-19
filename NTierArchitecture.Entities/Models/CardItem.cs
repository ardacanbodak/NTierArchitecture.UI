namespace NTierArchitecture.Entities.Models
{
    public class CardItem
    {
        public Guid CardItemID { get; set; }
        public Guid ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public override string ToString()
        {
            return $"{ProductName}-{Quantity}-{UnitPrice}";
        }
    }
}
