using DO;

namespace Dal;

internal static class DataSource
{
    internal static List<Customer?> Customers = new List<Customer?>();
    internal static List<Sale?> Sales = new List<Sale?>();
    internal static List<Product?> Products = new List<Product?>();

    internal static class Config
    {
        private const int ProductBegin = 100;
        private const int SaleBegin = 100;
        private static int ProductLast = ProductBegin;
        private static int SaleLast = SaleBegin;
        public static int CurrentProduct
        { 
            get
            { return ProductLast++; }
        }

        public static int CurrentSale
        {
            get
            { return SaleLast++; }
        }
    }

}
