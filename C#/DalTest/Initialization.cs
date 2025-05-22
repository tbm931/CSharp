using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;
    private static List<int> productsCode = new List<int>();

    private static void createProducts()
    {
        productsCode.Add(s_dal.Product.Create(new Product(0, "מייבש שיער", DO.categories.מוצרי_שיער, 219.90, 20)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "מקרוגל", DO.categories.כלי_מטבח, 650.00, 10)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "מקדחה", DO.categories.כלי_עבודה, 199.00, 0)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "מחשבון כיס", DO.categories.אלקטרוניקה, 50, 0)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "פופיט חשמלי", DO.categories.אלקטרוניקה, 20.00, 0)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "נגן mp3", DO.categories.אלקטרוניקה, 150.00, 0)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "מחשב נייד lenovo", DO.categories.מיחשוב, 3000.0, 0)));
        productsCode.Add(s_dal.Product.Create(new Product(0, "מצלמת קנון 185", DO.categories.אלקטרוניקה, 480.00, 0)));
    }

    private static void createCustomers()
    {
        s_dal.Customer.Create(new Customer(0, "Moshe Cohen", "5 Hazait Street", "0527232314"));
    }
    private static void createSales()
    {
        s_dal.Sale.Create(new Sale(0, productsCode[0],2,400,true,new DateTime(2024,11,10), new DateTime(2024, 12, 10)));
        s_dal.Sale.Create(new Sale(0, productsCode[0], 2, 400, true, new DateTime(2024, 11, 10), new DateTime(2024, 12, 10)));
        s_dal.Sale.Create(new Sale(0, productsCode[0], 2, 400, true, new DateTime(2024, 11, 10), new DateTime(2024, 12, 10)));
        s_dal.Sale.Create(new Sale(0, productsCode[0], 2, 400, true, new DateTime(2024, 11, 10), new DateTime(2024, 12, 10)));
    }

    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        createCustomers();
        createProducts();
        createSales();
    }

}
