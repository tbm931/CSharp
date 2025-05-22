namespace BO
{
    public class Customer(int id, string? name, string? address, string? telephone)
    {
        public int Id { get; init; } = id;
        public string? Name { get; set; } = name;
        public string? Address { get; set; } = address;
        public string? Telephone { get; set; } = telephone;

        public override string ToString() => this.ToStringProperty();
    }
}
