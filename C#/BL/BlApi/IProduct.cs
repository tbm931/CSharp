using BO;
namespace BlApi
{
    public interface IProduct
    {
        public int Create(Product item);//Creates new entity object in DAL

        public Product Read(int id);//Reads entity object by its ID 

        public Product? Read(Func<Product, bool> filter);

        public List<Product?> ReadAll(Func<Product, bool>? filter = null);//stage 1 only, Reads all entity objects

        public void Update(Product item); //Updates entity object

        public void Delete(int id); //Deletes an object by its Id
        public List<SaleInProduct>? AllRelevantSales(int productId,bool isPreffered); //return all the sales in force for this product
    }
}
