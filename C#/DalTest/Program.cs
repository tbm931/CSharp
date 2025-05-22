using Dal;
using DalApi;
using DO;

namespace DalTest;
internal class Program
{
    public enum Kind { Product, Sale, Customer };
    private static void Read<T>(ICrud<T> crud, Kind k)
    {
        try
        {
            Console.WriteLine($"הכנס מזהה של {k} להצגה");
            if (int.TryParse(Console.ReadLine(), out int id))
                Console.WriteLine(crud.Read(id));
        }
        catch
        {
            Console.WriteLine("מזהה שגוי");
        }
    }
    private static void Delete<T>(ICrud<T> crud, Kind k)
    {
        try
        {
            Console.WriteLine($"הכנס מזהה של {k} למחיקה");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                crud.Delete(id);
            }
            else throw new Exception("מזהה לא קיים");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    private static void ReadAll<T>(ICrud<T> crud)
    {
        foreach (var item in crud.ReadAll())
        {
            Console.WriteLine(item);
        }
    }
    private static DateTime CreateDateTime(string str)
    {
        Console.WriteLine($"הכנס יום, חודש, שנה של {str} לפי הסדר");
        if (int.TryParse(Console.ReadLine(), out int day) && int.TryParse(Console.ReadLine(), out int month) && int.TryParse(Console.ReadLine(), out int year))
            return new DateTime(year, month, day);
        else throw new Exception("תאריך לא תקין");
    }
    private static Product? GetDetailsOfProduct()
    {
        string? prodname;
        Console.WriteLine("הכנס שם מוצר, מחיר, כמות במלאי");
        prodname = Console.ReadLine();
        if (int.TryParse(Console.ReadLine(), out int price) && int.TryParse(Console.ReadLine(), out int count))
        {
            Console.WriteLine($"הכנס 1 ל {categories.מוצרי_שיער}, 2 ל {categories.כלי_מטבח}, 3 ל {categories.כלי_עבודה}, 4 ל {categories.אלקטרוניקה}, 5 ל {categories.מיחשוב}");
            if (int.TryParse(Console.ReadLine(), out int category))
            {
                return new Product(0, prodname, (categories)(category - 1), price, count);
            }
        }
        Console.WriteLine("הוזנו נתוני מוצר שגויים");
        return null;
    }
    private static int CreateProduct()
    {
        Product? product = GetDetailsOfProduct();
        if (product == null)
            return 0;
        return s_dal.Product.Create(product);
    }
    private static Sale? GetDetailsOfSale()
    {
        DateTime begin, finish;
        Console.WriteLine("הכנס קוד מוצר, כמות מינימלית למבצע, מחיר במבצע");
        if (int.TryParse(Console.ReadLine(), out int prodId) && int.TryParse(Console.ReadLine(), out int minCount) && double.TryParse(Console.ReadLine(), out double allPrice))
        {
            begin = CreateDateTime("תחילת המבצע");
            finish = CreateDateTime("סיום המבצע");
            Console.WriteLine("האם המבצע לכלל הלקוחות? הקש true או false");
            if (bool.TryParse(Console.ReadLine(), out bool isToAll))
                return new Sale(0, prodId, minCount, allPrice, isToAll, begin, finish);
            throw new Exception("הוזן נתון שגוי");
        }
        Console.WriteLine("הוזנו נתוני מבצע שגויים");
        return null;
    }
    private static int CreateSale()
    {
        Sale? sale = GetDetailsOfSale();
        if (sale == null) 
            return 0;
        return s_dal.Sale.Create(sale);
    }
    private static Customer? GetDetailsOfCustomer()
    {
        string? name;
        string? address;
        string? telephone;
        Console.WriteLine("הכנס תז, שם, כתובת, מס טלפון");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            name = Console.ReadLine();
            address = Console.ReadLine();
            telephone = Console.ReadLine();
            return new Customer(id, name, address, telephone);
        }
        Console.WriteLine("הוזנו נתוני לקוח שגויים");
        return null;
    }
    private static int CreateCustomer()
    {
        Customer? customer = GetDetailsOfCustomer();
        if (customer == null) 
            return 0;
        return s_dal.Customer.Create(customer);
    }
    private static void UpdateProduct()
    {
        try
        {
            Console.WriteLine("insert id");
            if (int.TryParse(Console.ReadLine(), out int id) && s_dal.Product.Read(id) != null)
            {
                Product? p = GetDetailsOfProduct()! with { id = id };
                s_dal.Product.Update(p);
            }
            else throw new Exception("מזהה לא תקין");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    private static void UpdateSale()
    {
        try
        {
            Console.WriteLine("insert id");
            if (int.TryParse(Console.ReadLine(), out int id) && s_dal.Sale.Read(id) != null)
            {
                Sale? p = GetDetailsOfSale()! with { Id = id };
                s_dal.Sale.Update(p);
            }
            else throw new Exception("מזהה לא תקין");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    private static void UpdateCustomer()
    {
        try
        {
            Console.WriteLine("insert id");
            if (int.TryParse(Console.ReadLine(), out int id) && s_dal.Customer.Read(id) != null)
            {
                Customer? p = GetDetailsOfCustomer()! with { Id = id };
                s_dal.Customer.Update(p);
            }
            else throw new Exception("מזהה לא תקין");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public static void PrintMainMenu()
    {
        Console.WriteLine("בחר:\n 1 למוצר\n 2 למבצע\n 3 ללקוח\n 4 לניקוי קובץ לוג\n 0 ליציאה");
        if (!int.TryParse(Console.ReadLine(), out int choose))
            PrintMainMenu();
        switch (choose)
        {
            case 0:
                break;
            case 1:
                ICrud<Product> Refproduct = s_dal.Product;
                PrintSubMenu<Product>(Kind.Product, Refproduct);
                break;
            case 2:
                ICrud<Sale> Refsale = s_dal.Sale;
                PrintSubMenu<Sale>(Kind.Sale, Refsale);
                break;
            case 3:
                ICrud<Customer> Refcustomer = s_dal.Customer;
                PrintSubMenu<Customer>(Kind.Customer, Refcustomer);
                break;
            case 4:
                Tools.LogManager.DeleteOldDirs();
                break;
            default:
                Console.WriteLine("בחירה שגויה");
                PrintMainMenu();
                break;
        }

    }
    public static void PrintSubMenu<T>(Kind selected, ICrud<T> selectedCrud)
    {
        Console.WriteLine($"בחר:\n 1 להוספת {selected} חדש\n 2 להדפסת {selected} בודד\n 3 להדפסת כל ה {selected}s\n 4 לעדכון {selected}\n5 למחיקה {selected}\n 0 ליציאה");
        if (!int.TryParse(Console.ReadLine(), out int choose))
            PrintSubMenu<T>(selected,selectedCrud);
        switch (choose)
        {
            case 0:
                PrintMainMenu();
                break;
            case 1:
                switch (selected)
                {
                    case Kind.Product:
                        CreateProduct();
                        break;
                    case Kind.Customer:
                        CreateCustomer();
                        break;
                    case Kind.Sale:
                        CreateSale();
                        break;
                }
                PrintSubMenu<T>(selected, selectedCrud);
                break;
            case 2:
                Read<T>(selectedCrud, selected);
                PrintSubMenu<T>(selected, selectedCrud);
                break;
            case 3:
                ReadAll<T>(selectedCrud);
                PrintSubMenu<T>(selected, selectedCrud);
                break;
            case 4:
                switch (selected)
                {
                    case Kind.Product:
                        UpdateProduct();
                        break;
                    case Kind.Customer:
                        UpdateCustomer();
                        break;
                    case Kind.Sale:
                        UpdateSale();
                        break;
                }
                PrintSubMenu<T>(selected, selectedCrud);
                break;
            case 5:
                Delete<T>(selectedCrud, selected);
                PrintSubMenu<T>(selected, selectedCrud);
                break;
            default:
                Console.WriteLine("בחירה שגויה");
                PrintSubMenu<T>(selected, selectedCrud);
                break;
        }
    }

    private readonly static IDal s_dal = DalApi.Factory.Get;
    static void Main()
    {
        Console.WriteLine("האם ברצונך להריץ שוב את הנתונים?");
        bool.TryParse(Console.ReadLine(), out bool m);
        if(m)
            Initialization.Initialize();
        try
        {
            PrintMainMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}