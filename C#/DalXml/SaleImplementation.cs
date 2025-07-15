using DalApi;
using DO;
using System.Reflection;
using System.Xml.Linq;
using Tools;

namespace Dal;

internal class SaleImplementation : ISale
{
    private static readonly string filePath = @"..\xml\sales.xml";
    private static readonly XDocument doc = XDocument.Load(filePath); //private static XDocument doc = XDocument.Load(@"..\xml\data-config.xml");
    private static readonly XElement root = doc.Root!;
    public int Create(Sale item)
    {
        LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "Create Sale Start--");
        var newItem = item with { Id = Config.NextSaleId };
        root.Add(SaleToXElement(newItem));
        doc.Save(filePath);
        LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Create", "Create Sale --End");
        return item.Id;
    }
    private XElement SaleToXElement(Sale sale) => new XElement("Sale",
            new XElement("id", sale.Id),
            new XElement("prodId", sale.ProdId),
            new XElement("minCount", sale.MinCount),
            new XElement("allPrice", sale.AllPrice),
            new XElement("isToAll", sale.IsToAll),
            new XElement("begin", sale.Begin),
            new XElement("finish", sale.Finish)
        );
    public void Delete(int id)
    {
        LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete Sale --End");
        root.Elements().FirstOrDefault(s => int.Parse(s.Element("id")!.Value) == id)!.Remove();
        doc.Save(filePath);
        LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Delete", "Delete Sale --End");
    }

    public Sale? Read(int id)
    {
        LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Sale Start--");
        XElement? el = root.Elements().FirstOrDefault(s => int.Parse(s.Element("Id")!.Value) == id);
        if (el == null)
            return null;
        LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Sale --End");
        return new Sale(id,int.Parse(el!.Element("ProdId")!.Value), int.Parse(el!.Element("MinCount")!.Value), int.Parse(el!.Element("AllPrice")!.Value), bool.Parse(el!.Element("IsToAll")!.Value), DateTime.Parse(el!.Element("Begin")!.Value), DateTime.Parse(el!.Element("Finish")!.Value));
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Sale Start--");
        Sale? sale = root.Elements().Select(s => { Sale sl = new Sale(int.Parse(s!.Element("Id")!.Value), int.Parse(s!.Element("ProdId")!.Value), int.Parse(s!.Element("MinCount")!.Value), int.Parse(s!.Element("AllPrice")!.Value), bool.Parse(s!.Element("IsToAll")!.Value), DateTime.Parse(s!.Element("Begin")!.Value), DateTime.Parse(s!.Element("Finish")!.Value));return sl; }).Where(filter).ToArray()[0];
        LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Read", "Read Sale --End");
        return sale;
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "ReadAll Sale Start--");
        LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "ReadAll", "Sale Product --End");
        //List<Sale?> sales = root.Elements().Select(s => { Sale sl = new Sale(int.Parse(s!.Element("id")!.Value), int.Parse(s!.Element("prodId")!.Value), int.Parse(s!.Element("minCount")!.Value), int.Parse(s!.Element("allPrice")!.Value), bool.Parse(s!.Element("isToAll")!.Value), DateTime.Parse(s!.Element("begin")!.Value), DateTime.Parse(s!.Element("finish")!.Value));return sl; }).Where(filter).ToList();
        var query = root.Elements()
         .Select(s =>
         {
             try
             {
                 return new Sale(
                     int.Parse(s.Element("id")?.Value ?? "0"),
                     int.Parse(s.Element("prodId")?.Value ?? "0"),
                     int.Parse(s.Element("minCount")?.Value ?? "0"),
                     int.Parse(s.Element("allPrice")?.Value ?? "0"),
                     bool.Parse(s.Element("isToAll")?.Value ?? "false"),
                     DateTime.Parse(s.Element("begin")?.Value ?? DateTime.MinValue.ToString()),
                     DateTime.Parse(s.Element("finish")?.Value ?? DateTime.MaxValue.ToString())
                 );
             }
             catch
             {
                 return null;
             }
         })
         .Where(sale => sale != null);

        // מוסיפים פילטר אם קיים
        query = filter != null ? query.Where(filter!) : query;

        return query.ToList();
    }
    public void Update(Sale item)
    {
        LogManager.WriteToLogStartFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update Sale Start--");
        XElement? element = root.Elements().FirstOrDefault(ele => ele.Element("id")!.Value == item.Id.ToString());
        if (element != null)
        {
            element.ReplaceWith(SaleToXElement(item));
            doc.Save(filePath);
        }
        LogManager.WriteToLogEndFunc(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, "Update", "Update Sale --End");
    }
}
