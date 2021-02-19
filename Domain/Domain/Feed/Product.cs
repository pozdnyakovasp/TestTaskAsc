using Domain.Infrastructure;

namespace Domain.Feed
{
    public class Product : IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }

        public int Key => Id;
    }
}
