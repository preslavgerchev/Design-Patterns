namespace Decorator_Pattern
{
    public class Cabbage : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Cabbage";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.15;
            }
        }

        public Cabbage(IOrder order) : base(order) { }
    }
}