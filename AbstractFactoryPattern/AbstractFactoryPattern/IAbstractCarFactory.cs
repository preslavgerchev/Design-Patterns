namespace AbstractFactoryPattern
{
    public interface IAbstractCarFactory
    {
        IBrand CreateBrand();
        ICarColor CreateCarColor();
        ITyres CreateTyres();
        IEngine CreateEngine();
        ISpeed CreateSpeed();
    }
}