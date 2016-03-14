namespace Decorator_Pattern
{
    public class Mayonnaise : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Mayonnaise";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.15;
            }
        }

        public Mayonnaise(IOrder order) : base(order) { }
    }
}