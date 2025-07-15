using System.Reflection;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

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
        LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "create customer Start--");
        Deserialize();
        listOfCustomers.Add(item);
        Serialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "create customer --End");
        return item.Id;
    }

    public void Delete(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete customer Start--");
        Deserialize();
        listOfCustomers!.Remove(listOfCustomers.First(c => c.Id == id));
        Serialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete customer --End");
    }

    public Customer? Read(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read customer Start--");
        Deserialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read customer --End");
        return listOfCustomers.First(c => c.Id == id);
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read customer Start--");
        Deserialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read customer --End");
        return listOfCustomers.First(c => filter(c));
    }
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll customers Start--");
        Deserialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll customers --End");
        return listOfCustomers!.Where(c => filter == null || filter(c)).Select(c => c).ToList();
    }

    public void Update(Customer item)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update customer Start--");
        Deserialize();
        listOfCustomers = listOfCustomers!.Select(c => item.Id == c.Id ? item : c).ToList();
        Serialize();
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update customer --End");
    }
}
