using BO;
using DalTest;
namespace BlTest;
internal class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
    public static int ReadId()
    {
        Console.WriteLine("insert id. for casual customer insert 0.");
        if (int.TryParse(Console.ReadLine(), out int id))
            return id;
        else
            return ReadId();
    }
    public static int ReadProduct(out int productId)
    {
        Console.WriteLine("insert product id and amount.");
        if (!int.TryParse(Console.ReadLine(), out productId))
            return ReadProduct(out productId);
        if (!int.TryParse(Console.ReadLine(), out int amount))
            return ReadProduct(out productId);
        return amount;
    }
    public static void Main()
    {
        Console.WriteLine("האם ברצונך להריץ שוב את הנתונים?");
        bool v = bool.TryParse(Console.ReadLine(), out bool m);
        if (m)
            Initialization.Initialize();
        Order order = new(false, [],0);
        int customerId = ReadId();
        int anotherProduct = 1, anotherOrder = 1, amount;
        while (anotherOrder == 1)
        {
            while (anotherProduct == 1)
            {
                amount = ReadProduct(out int productId);
                order.PreferredCustomer = customerId != 0;
                Console.WriteLine("list of sales: \n" + s_bl.Order.AddProductToOrder(order, productId, amount).ToString());
                Console.WriteLine("the interim price: " + order.FinalPrice);
                Console.WriteLine("insert 1 to add another product. to finish the order insert 0.");
                while (!int.TryParse(Console.ReadLine(), out anotherProduct)) ;
            }
            Console.WriteLine(order.ToString());
            Console.WriteLine("insert 1 to do another order. insert 0 to exit.");
            while (!int.TryParse(Console.ReadLine(), out anotherOrder)) ;
        }
    }
}