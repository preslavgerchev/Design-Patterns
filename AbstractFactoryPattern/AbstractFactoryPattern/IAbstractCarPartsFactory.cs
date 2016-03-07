namespace AbstractFactoryPattern
{
    public interface IAbstractCarPartsFactory
    {
        IBrand CreateBrand();
        ICarColor CreateCarColor();
        ITyres CreateTyres();
        IEngine CreateEngine();
        ISpeed CreateSpeed();
    }
}