using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "create customer Start--");
        if (DataSource.Customers.Any(cust => cust!.Id == item.Id) == true) {
            Tools.LogManager.WriteToLogError(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "קיים כבר כזה לקוח");
            throw new DalExist("קיים כבר כזה לקוח");
        }
        DataSource.Customers.Add(item);
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "create customer --End");
        return item.Id;
    }
    public Customer? Read(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read customer Start--");
        Customer? customer = DataSource.Customers.FirstOrDefault((c=> c!.Id==id),null);
        if (customer == null) {
            Tools.LogManager.WriteToLogError(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "לא קיים כזה לקוח");
            throw new DalNotExist("לא קיים כזה לקוח");
        }
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read customer --End");
        return customer;
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read customer Start--");
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read customer --End");
        return DataSource.Customers.FirstOrDefault(filter!,null);
    }


    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll customers Start--");
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll customers --End");
        if (filter==null)
            return new List<Customer?>(DataSource.Customers);
        return DataSource.Customers.Where(filter!).ToList();
    }

    public void Update(Customer item)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update customer Start--");
        Delete(item.Id);
        DataSource.Customers.Add(item);
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update customer --End");
    }

    public void Delete(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete customer Start--");
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete customer --End");
        DataSource.Customers.Remove(Read(id));
    }
}
