namespace Decorator_Pattern
{
    public class Cheese : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Cheese";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.3;
            }
        }

        public Cheese(IOrder order) : base(order) { }
    }
}