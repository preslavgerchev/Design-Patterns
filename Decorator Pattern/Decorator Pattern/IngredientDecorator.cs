namespace Decorator_Pattern
{
    public abstract class IngredientDecorator : IOrder
    {
        public IOrder Order { get; set; }
        public abstract string Description { get; }
        public abstract double Price { get; }

        public IngredientDecorator(IOrder order)
        {
            this.Order = order;
        }
    }
}