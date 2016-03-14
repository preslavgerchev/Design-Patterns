namespace Decorator_Pattern
{
    public class SesameBread : IOrder
    {
        public string Description
        {
            get
            {
                return "Sesame bread";
            }
        }

        public double Price
        {
            get
            {
                return 1.15;
            }
        }
    }
}