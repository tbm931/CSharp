using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal;
internal class CustomerImplementation : ICustomer
{
    private static readonly string filePath = @"..\xml\customers.xml";
    private static List<Customer> listOfCustomers;
    XmlSerializer serializerList = new XmlSerializer(typeof(List<Customer>));
    private void Deserialize()
    {
        StreamReader sr = new StreamReader(filePath);
        listOfCustomers = serializerList.Deserialize(sr) as List<Customer>;
        sr.Close();
    }
    private void Serialize()
    {
        StreamWriter sw = new StreamWriter(filePath);
        serializerList.Serialize(sw, listOfCustomers);
        sw.Close();
    }

    public int Create(Customer item)
    {
        Deserialize();
        listOfCustomers.Add(item);
        Serialize();
        return item.Id;
    }

    public void Delete(int id)
    {
        Deserialize();
        listOfCustomers!.Remove(listOfCustomers.First(c => c.Id == id));
        Serialize();
    }

    public Customer? Read(int id)
    {
        Deserialize();
        return listOfCustomers.First(c => c.Id == id);
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        Deserialize();
        return listOfCustomers.First(c => filter(c));
    }
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        Deserialize();
        return listOfCustomers!.Where(c => filter == null || filter(c)).Select(c => c).ToList();
    }

    public void Update(Customer item)
    {
        Deserialize();
        listOfCustomers = listOfCustomers!.Select(c => item.Id == c.Id ? item : c).ToList();
        Serialize();
    }
}
