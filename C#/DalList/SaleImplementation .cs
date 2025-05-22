using DO;
using DalApi;
using System.Reflection;

namespace Dal;

internal class SaleImplementation:ISale
{
    public int Create(Sale item) {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "Create Sale Start--");
        Sale s = item with { Id = DataSource.Config.CurrentSale };
        DataSource.Sales.Add(s);
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "Create Sale --End");
        return s.Id;
    }

    public Sale? Read(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Sale Start--");
        Sale? sale = DataSource.Sales.FirstOrDefault(s => s!.Id == id, null);
        if (sale == null)
        {
            Tools.LogManager.WriteToLogError(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "לא קיים כזה מבצע");
            throw new DalNotExist("לא קיים כזה מבצע");
        }
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Sale --End");
        return sale;
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Sale Start--");
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Sale --End");
        return DataSource.Sales.FirstOrDefault(filter!, null);
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll Sale Start--");
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "Sale Product --End");
        if (filter == null)
            return new List<Sale?>(DataSource.Sales);
        return DataSource.Sales.Where(filter!).ToList();
    }

    public void Update(Sale item)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update Sale Start--");
        Delete(item.Id);
        DataSource.Sales.Add(item);
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update Sale --End");
    }

    public void Delete(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete Sale --End");
        DataSource.Sales.Remove(Read(id));
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete Sale --End");
    } 
}
