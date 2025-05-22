namespace DalApi
{
    public interface ICrud<T>
    {
        public int Create(T item);//Creates new entity object in DAL

        public T? Read(int id);//Reads entity object by its ID 

        public T? Read(Func<T,bool> filter);

        public List<T?> ReadAll(Func<T,bool>? filter=null);//stage 1 only, Reads all entity objects

        public void Update(T item); //Updates entity object

        public void Delete(int id); //Deletes an object by its Id
    }
}
