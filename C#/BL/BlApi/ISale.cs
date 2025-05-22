using BO;
namespace BlApi
{
    public interface ISale
    {
        public int Create(Sale item);//Creates new entity object in DAL

        public Sale Read(int id);//Reads entity object by its ID 

        public Sale? Read(Func<Sale, bool> filter);

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null);//stage 1 only, Reads all entity objects

        public void Update(Sale item); //Updates entity object

        public void Delete(int id); //Deletes an object by its Id

    }
}