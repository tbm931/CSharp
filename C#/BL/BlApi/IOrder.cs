using BO;
namespace BlApi
{
    public interface IOrder
    {
        public List<SaleInProduct> AddProductToOrder(Order o,int productId,int count); //add count items of products to order and return list of sales for this product
        public void CalcTotalPriceForProduct(ProductInOrder product, bool isPreferred);//calculate and update final price for this product
        public void CalcTotalPrice(Order order);//calculate and update final price for this order
        public void DoOrder(Order order);//get an order and do it
        public void SearchSaleForProduct(ProductInOrder productInOrder, bool isPreferred);//return all relevant sales for this product
    }
}