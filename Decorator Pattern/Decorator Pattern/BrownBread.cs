namespace Decorator_Pattern
{
    public class BrownBread : IOrder
    {
        public string Description
        {
            get
            {
                return "Brown bread";
            }
        }

        public double Price
        {
            get
            {
                return 1;
            }
        }
    }
}