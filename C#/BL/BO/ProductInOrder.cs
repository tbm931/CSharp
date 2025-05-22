namespace BO
{
    public class ProductInOrder(int ProductId, string? ProductName, double BasePriceToProduct, int CountInOrder, List<SaleInProduct>? LIstProductSales, double FinalPrice)
    {
        public int ProductId { get; } = ProductId;
        public string? ProductName { get; set; } = ProductName;
        public double BasePriceToProduct { get; set; } = BasePriceToProduct;
        public int CountInOrder { get; set; } = CountInOrder;
        public List<SaleInProduct>? ListProductSales { get; set; } = LIstProductSales;
        public double FinalPrice { get; set; } = FinalPrice;

        public override string ToString() => this.ToStringProperty();
    }
}
