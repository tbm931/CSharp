using System.Collections;
using System.Reflection;

namespace BO
{
    internal static class Tools
    {
        public static BO.Customer CastCustomerFromDOToBO(this DO.Customer customer) => new(customer.Id, customer.Name, customer.Address, customer.Telephone);

        public static DO.Customer CastCustomerFromBOToDO(this BO.Customer customer) => new(customer.Id, customer.Name, customer.Address, customer.Telephone);

        public static BO.Product CastProductFromDOToBO(this DO.Product p) => new(p.id, p.name, (Categories)p.category!, p.price, p.count);

        public static DO.Product CastProductFromBOToDO(this BO.Product p) => new(p.Id, p.Name, (DO.categories)p.Category, p.Price, p.Count);

        public static BO.Sale CastSaleFromDOToBO(this DO.Sale s) => new(s.Id, s.ProdId, s.MinCount, s.AllPrice, s.IsToAll, s.Begin, s.Finish);

        public static DO.Sale CastSaleFromBOToDO(this BO.Sale s) => new(s.Id, s.ProdId, s.MinCount, s.AllPrice, s.IsToAll, s.Begin, s.Finish);

        public static BO.SaleInProduct CastFromSaleToSaleInOrder(this BO.Sale s) => new(s.Id, s.MinCount, s.AllPrice, s.IsToAll);

        public static BO.ProductInOrder CastFromProductToProductInOrder(this BO.Product p) => new(p.Id, p.Name, p.Price, p.Count, p.ListOfSales, p.Count * p.Price);

        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            Type Ttype = t!.GetType();
            PropertyInfo[] info = Ttype.GetProperties();
            foreach (PropertyInfo item in info)
            {
                if (typeof(IEnumerable).IsAssignableFrom(item.PropertyType) && item.PropertyType != typeof(string))
                {
                    IEnumerable? collection = item.GetValue(t) as IEnumerable;
                    foreach (var x in collection!)
                    {
                        str += x.ToStringProperty();
                    }
                }
                else
                    str += string.Format("name: {0,-15} value: {1,-15}\n", item.Name, item.GetValue(t, null));

            }
            return str;
        }

    }
}
