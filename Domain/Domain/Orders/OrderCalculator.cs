namespace Domain.Orders
{
    public class OrderCalculator : IOrderCalculator
    {
        public OrderCalculator(/*DI from discount interface*/)
        {
        }

        public void Applay(Order order)
        {
            // discount 1%
            order.Discount = order.Price * 0.01m;
        }
    }
}
