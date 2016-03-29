namespace Builder_Pattern
{
    public class AudiBuilder : ICarBuilder
    {
        public Car Car { get; }

        public AudiBuilder()
        {
            this.Car = new Car();
        }

        public void BuildColor()
        {
            Car.Color = "Audi Color";
        }

        public void BuildDoors()
        {
            Car.Doors = "Audi Doors";
        }

        public void BuildEngine()
        {
            Car.Engine = "Audi Engine";
        }

        public void BuildFrame()
        {
            Car.Frame = "Audi Frame";
        }

        public void BuildTyres()
        {
            Car.Tyres = "Audi Tyres";
        }
    }
}