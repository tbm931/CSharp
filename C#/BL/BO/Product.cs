namespace BO
{
    public class Product(int id, string? name, Categories category, double price, int count)
    {
        public int Id { get; init; } = id;
        public string? Name { get; set; } = name;
        public Categories Category { get; set; } = category;
        public double Price { get; set; } = price;
        public int Count { get; set; } = count;
        public List<SaleInProduct>? ListOfSales { get; set; } = [];

        public override string ToString() => this.ToStringProperty();
    }
}
