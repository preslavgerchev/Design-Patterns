﻿namespace AbstractFactoryPattern
{
    using Mercedes;

    public class MercedesCarPartsFactory : IAbstractCarPartsFactory
    {
        public IBrand CreateBrand()
        {
            return new MercedesBrand();
        }

        public ICarColor CreateCarColor()
        {
            return new MercedesCarColor();
        }

        public IEngine CreateEngine()
        {
            return new MercedesEngine();
        }

        public ISpeed CreateSpeed()
        {
            return new MercedesSpeed();
        }

        public ITyres CreateTyres()
        {
            return new MercedesTyres();
        }
    }
}