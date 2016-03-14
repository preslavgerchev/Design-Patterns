namespace Decorator_Pattern
{
    public class Ketchup : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Ketchup";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.05;
            }
        }

        public Ketchup(IOrder order) : base(order) { }
    }
}