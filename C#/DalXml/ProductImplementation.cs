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
        Deserialize();
        listOfProducts.Add(item with { id = Config.NextProductId });
        Serialize();
        return item.id;       
    }

    public void Delete(int id)
    {
        Deserialize();
        listOfProducts!.Remove(listOfProducts.First(p => p.id == id));
        Serialize();
    }
    
    public Product? Read(int id)
    {
        Deserialize();
        return listOfProducts.First(p => p.id == id);
    }
    public Product? Read(Func<Product, bool> filter)
    {
        Deserialize();
        return listOfProducts.First(p=>filter(p));
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        Deserialize();
        return listOfProducts!.Where(p => filter == null || filter(p)).Select(p => p).ToList();
    }
    
    public void Update(Product item)
    {
        Deserialize();
        listOfProducts = listOfProducts!.Select(p => item.id == p.id ? item : p).ToList();
        Serialize();
    }
}
