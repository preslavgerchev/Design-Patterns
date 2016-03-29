namespace Builder_Pattern
{
    public class BMWBuilder : ICarBuilder
    {
        public Car Car { get; }

        public BMWBuilder()
        {
            this.Car = new Car();
        }

        public void BuildColor()
        {
            Car.Color = "BMW Color";
        }

        public void BuildDoors()
        {
            Car.Doors = "BMW Doors";
        }

        public void BuildEngine()
        {
            Car.Engine = "BMW Engine";
        }

        public void BuildFrame()
        {
            Car.Frame = "BMW Frame";
        }

        public void BuildTyres()
        {
            Car.Tyres = "BMW Tyres";
        }
    }
}