namespace Decorator_Pattern
{
    public class Pepper : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Peppers";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.25;
            }
        }

        public Pepper(IOrder order) : base(order) { }
    }
}