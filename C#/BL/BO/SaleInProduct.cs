namespace BO
{
    public class SaleInProduct(int SaleId, int Count, double price, bool IsToAll)
    {
        public int SaleId { get; } = SaleId;
        public int Count { get; set; } = Count;
        public double Price { get; set; } = price;
        public bool IsToAll { get; set; } = IsToAll;

        public override string ToString() => this.ToStringProperty();
    }
}
