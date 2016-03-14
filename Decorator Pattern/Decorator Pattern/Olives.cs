namespace Decorator_Pattern
{
    public class Olives : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Olives";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.65;
            }
        }

        public Olives(IOrder order) : base(order) { }
    }
}