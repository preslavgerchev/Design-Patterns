namespace Decorator_Pattern
{
    public class Tomato : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Tomatoes";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.2;
            }
        }

        public Tomato(IOrder order) : base(order) { }
    }
}