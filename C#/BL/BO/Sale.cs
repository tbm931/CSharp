namespace BO
{
    public class Sale(int id, int? prodId, int minCount, double allPrice, bool isToAll, DateTime? begin, DateTime? finish)
    {
        public int Id { get; init; } = id;
        public int? ProdId { get; set; } = prodId;
        public int MinCount { get; set; } = minCount;
        public double AllPrice { get; set; } = allPrice;
        public bool IsToAll { get; set; } = isToAll;
        public DateTime? Begin { get; set; } = begin;
        public DateTime? Finish { get; set; } = finish;

        public override string ToString() => this.ToStringProperty();
    }
}
