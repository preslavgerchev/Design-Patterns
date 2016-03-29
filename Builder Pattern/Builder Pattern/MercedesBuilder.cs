namespace Builder_Pattern
{
    public class MercedesBuilder : ICarBuilder
    {
        public Car Car { get; }

        public MercedesBuilder()
        {
            this.Car = new Car();
        }

        public void BuildColor()
        {
            Car.Color = "Mercedes Color";
        }

        public void BuildDoors()
        {
            Car.Doors = "Mercedes Doors";
        }

        public void BuildEngine()
        {
            Car.Engine = "Mercedes Engine";
        }

        public void BuildFrame()
        {
            Car.Frame = "Mercedes Frame";
        }

        public void BuildTyres()
        {
            Car.Tyres = "Mercedes Tyres";
        }
    }
}