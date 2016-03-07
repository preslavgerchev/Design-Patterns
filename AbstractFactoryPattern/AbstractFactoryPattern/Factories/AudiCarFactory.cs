namespace AbstractFactoryPattern
{
    using Audi;

    public class AudiCarFactory : IAbstractCarFactory
    {
        public IBrand CreateBrand()
        {
            return new AudiBrand();
        }

        public ICarColor CreateCarColor()
        {
            return new AudiCarColor();
        }

        public IEngine CreateEngine()
        {
            return new AudiEngine();
        }

        public ISpeed CreateSpeed()
        {
            return new AudiSpeed();
        }

        public ITyres CreateTyres()
        {
            return new AudiTyres();
        }
    }
}