using BlApi;
using BO;
using static BO.Tools;


namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private readonly DalApi.IDal _dal = DalApi.Factory.Get;

        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int count)
        //add count items of products to order and return list of sales for this product
        {
            try
            {
                BO.Product product = _dal.Product.Read(productId)!.CastProductFromDOToBO();
                BO.ProductInOrder? prod = order.ListOfProducts!.FirstOrDefault(p => p.ProductId == productId);
                if (prod == null) //the product to add not exist
                {
                    if (product.Count < count)
                        throw new Exception("Not enough in stock");
                    BO.ProductInOrder newProd = new(productId, product.Name, product.Price, count, null, 0);
                    order.ListOfProducts!.Add(newProd);
                    prod = newProd;
                }
                else //the product to add exist
                {
                    if (product.Count < count)
                        throw new Exception("Not enough in stock");
                    product.Count += count;
                }
                CalcTotalPriceForProduct(prod, order.PreferredCustomer);
                CalcTotalPrice(order);
                return prod.ListProductSales!;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void CalcTotalPriceForProduct(ProductInOrder product, bool isPreffered)
        //calculate and update final price for this product
        {
            try
            {
                SearchSaleForProduct(product, isPreffered);
                if (product.ListProductSales!.Count == 0)
                {
                    product.FinalPrice = product.BasePriceToProduct * product.CountInOrder;
                }
                else
                {
                    List<SaleInProduct> sales = [];
                    int numOfProducts = product.CountInOrder;
                    double price = product.ListProductSales!.Where(s => s.Count >= numOfProducts)
                        .OrderByDescending(s => s.Count)
                        .Select(s =>
                        {
                            int cp = numOfProducts / s.Count; if (cp > 0) { numOfProducts -= s.Count * cp; sales.Add(s); }
                            return s.Price * cp;
                        }).Sum();
                    price += numOfProducts * product.BasePriceToProduct;
                    product.FinalPrice = price;
                    product.ListProductSales = sales;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public void CalcTotalPrice(Order order)
        //calculate and update final price for this order
        {
            try
            {
                var q = from product in order.ListOfProducts
                        select product.FinalPrice;
                order.FinalPrice = q.Sum();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DoOrder(Order order)
        //get an order and do it
        {
            try
            {
                foreach(ProductInOrder prod in order.ListOfProducts!)
                {
                    BO.Product product = _dal.Product.Read(prod.ProductId)!.CastProductFromDOToBO();
                    product.Count -= prod.CountInOrder;
                    _dal.Product.Update(product.CastProductFromBOToDO());
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool isPreferred)
        //return all relevant sales for this product
        {
            try
            {
                productInOrder.ListProductSales = [.. _dal.Sale.ReadAll(sale => sale.ProdId == productInOrder.ProductId 
                                                    && (sale.IsToAll == true || isPreferred) 
                                                    && sale.MinCount <= productInOrder.CountInOrder 
                                                    && DateTime.Now >= sale.Begin 
                                                    && DateTime.Now <= sale.Finish)
                    .Select(s => s!.CastSaleFromDOToBO().CastFromSaleToSaleInOrder())
                    .OrderBy(s => s.Price / s.Count)];
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }

}


