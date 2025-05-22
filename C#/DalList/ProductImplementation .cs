using DO;
using DalApi;
using System.Reflection;

namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product item) {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "Create Product Start--");
        Product p = item with { id= DataSource.Config.CurrentProduct};
        DataSource.Products.Add(p);
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "Create Product --End");
        return p.id;
    }

    public Product? Read(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Product Start--");
        Product? product = DataSource.Products.FirstOrDefault((p => p!.id == id), null);
        if (product == null)
        {
            Tools.LogManager.WriteToLogError(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "קיים כבר כזה מוצר");
            throw new DalNotExist("לא קיים כזה מוצר");
        }
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Product --End");
        return product;
    }

    public Product? Read(Func<Product, bool>? filter)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Product Start--");
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Product --End");
        return DataSource.Products.FirstOrDefault(filter!, null);
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll Product Start--");
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll Product --End");
        if (filter == null)
            return new List<Product?>(DataSource.Products);
        return DataSource.Products.Where(filter!).ToList();
    }

    public void Update(Product item) {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update Product Start--");
        Delete(item.id);
        DataSource.Products.Add(item);
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update Product --End");
    }


    public void Delete(int id)
    {
        Tools.LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete Product --End");
        DataSource.Products.Remove(Read(id));
        Tools.LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete Product --End");
    }
}
