namespace Decorator_Pattern
{
    public class Ham : IngredientDecorator
    {
        public override string Description
        {
            get
            {
                return Order.Description + ", Ham";
            }
        }

        public override double Price
        {
            get
            {
                return Order.Price + 0.5;
            }
        }

        public Ham(IOrder order) : base(order) { }
    }
}