namespace Builder_Pattern
{
    public interface ICarBuilder
    {
        Car Car { get; }
        void BuildEngine();
        void BuildTyres();
        void BuildColor();
        void BuildFrame();
        void BuildDoors();
    }
}