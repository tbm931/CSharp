using System.Reflection;
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal;
internal class ProductImplementation : IProduct
{
    private static readonly string filePath = @"..\xml\products.xml";
    private static List<Product> listOfProducts;
    XmlSerializer serializerList = new XmlSerializer(typeof(List<Product>));
    private void Deserialize()
    {
        StreamReader sr = new StreamReader(filePath);
        listOfProducts = serializerList.Deserialize(sr) as List<Product>;
        sr.Close();
    }
    private void Serialize()
    {
        StreamWriter sw = new StreamWriter(filePath);
        serializerList.Serialize(sw, listOfProducts);
        sw.Close();
    }

    public int Create(Product item)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "Create Product Start--");
        Deserialize();
        listOfProducts.Add(item with { id = Config.NextProductId });
        Serialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "Create Product --End");
        return item.id;       
    }

    public void Delete(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete Product --End");
        Deserialize();
        listOfProducts!.Remove(listOfProducts.First(p => p.id == id));
        Serialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete Product --End");
    }
    
    public Product? Read(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Product Start--");
        Deserialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Product --End");
        return listOfProducts.First(p => p.id == id);
    }
    public Product? Read(Func<Product, bool> filter)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Product Start--");
        Deserialize(); 
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Product --End");
        return listOfProducts.First(p=>filter(p));
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll Product Start--");
        Deserialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll Product --End");
        return listOfProducts!.Where(p => filter == null || filter(p)).Select(p => p).ToList();
    }
    
    public void Update(Product item)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update Product Start--");
        Deserialize();
        listOfProducts = listOfProducts!.Select(p => item.id == p.id ? item : p).ToList();
        Serialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update Product --End");
    }
}
