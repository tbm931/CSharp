namespace BO
{
    public class Order
    {
        public bool PreferredCustomer { get; set; }
        public List<ProductInOrder>? ListOfProducts { get; set; }
        public double FinalPrice { get; set; }
        public Order(bool PreferredCustomer, List<ProductInOrder>? listOfProducts, double FinalPrice)
        {
            this.PreferredCustomer = PreferredCustomer;
            this.ListOfProducts = listOfProducts;
            this.FinalPrice = FinalPrice;
        }
        public override string ToString() => this.ToStringProperty();
    }
}
