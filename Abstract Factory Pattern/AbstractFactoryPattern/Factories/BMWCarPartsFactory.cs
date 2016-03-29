namespace AbstractFactoryPattern
{
    using BMW;

    public class BMWCarPartsFactory : IAbstractCarPartsFactory
    {
        public IBrand CreateBrand()
        {
            return new BMWBrand();
        }

        public ICarColor CreateCarColor()
        {
            return new BMWCarColor();
        }

        public IEngine CreateEngine()
        {
            return new BMWEngine();
        }

        public ISpeed CreateSpeed()
        {
            return new BMWSpeed();
        }

        public ITyres CreateTyres()
        {
            return new BMWTyres();
        }
    }
}