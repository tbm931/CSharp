using BO;

namespace BlApi
{
    public interface ICustomer
    {
        public int Create(Customer item);//Creates new entity object in DAL

        public Customer Read(int id);//Reads entity object by its ID 

        public Customer? Read(Func<Customer, bool> filter);

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null);//stage 1 only, Reads all entity objects

        public void Update(Customer item); //Updates entity object

        public void Delete(int id); //Deletes an object by its Id
        public bool IsExist(int id); //return if this customer exist
    }
}