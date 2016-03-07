using System.Text;

namespace AbstractFactoryPattern
{
    public class Car
    {
        IBrand Brand { get; }
        ICarColor Color { get; }
        ITyres Tyres { get; }
        IEngine Engine { get; }
        ISpeed Speed { get; }

        public Car(IAbstractCarFactory carFactory)
        {
            this.Brand = carFactory.CreateBrand();
            this.Color = carFactory.CreateCarColor();
            this.Tyres = carFactory.CreateTyres();
            this.Engine = carFactory.CreateEngine();
            this.Speed = carFactory.CreateSpeed();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Brand: " + Brand.BrandInfo());
            sb.AppendLine("Tyres: " + Tyres.TyresInfo());
            sb.AppendLine("Engine: " + Engine.EngineInfo());
            sb.AppendLine("Car color: " + Color.ColorInfo());

            return sb.ToString();
        }

        public string Drive()
        {
            return "The car is moving with " + Speed.SpeedInfo() + " km/h";
        }
    }
}