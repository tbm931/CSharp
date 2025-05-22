namespace BlApi
{
    public interface IBl
    {
        public IProduct Product { get; }
        public ICustomer Customer { get; }
        public IOrder Order { get; }
        public ISale Sale { get; }
    }
}
