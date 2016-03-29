namespace Builder_Pattern
{
    public class CarConstructor
    {
        public void Construct(ICarBuilder carBuilder)
        {
            carBuilder.BuildFrame();
            carBuilder.BuildEngine();
            carBuilder.BuildColor();
            carBuilder.BuildTyres();
            carBuilder.BuildDoors();
        }
    }
}