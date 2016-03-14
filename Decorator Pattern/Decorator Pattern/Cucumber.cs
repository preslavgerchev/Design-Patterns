namespace Decorator_Pattern
{
    public class Cucumber : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Cucumbers";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.35;
            }
        }

        public Cucumber(IOrder order) : base(order) { }
    }
}