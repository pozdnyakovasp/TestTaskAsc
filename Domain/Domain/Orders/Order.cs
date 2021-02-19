using Domain.Infrastructure;
using System;

namespace Domain.Orders
{
    public class Order : IAggregateRoot
    {
        public int Id { get; set; }
        public Guid OrderId { get; set; }
        public int ProducId { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal Proffit { get; set; }

        public decimal GetCustomerPrice()
        {
            return Math.Max(0, Price - (Discount ?? 0));
        }

        public int Key => Id;
    }
}
