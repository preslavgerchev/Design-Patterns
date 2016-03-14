namespace Decorator_Pattern
{
    public class WhiteBread : IOrder
    {
        public string Description
        {
            get
            {
                return "White bread";
            }
        }

        public double Price
        {
            get
            {
                return 0.95;
            }
        }
    }
}