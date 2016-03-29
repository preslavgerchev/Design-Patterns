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

        public Car(IAbstractCarPartsFactory carPartsFactory)
        {
            this.Brand = carPartsFactory.CreateBrand();
            this.Color = carPartsFactory.CreateCarColor();
            this.Tyres = carPartsFactory.CreateTyres();
            this.Engine = carPartsFactory.CreateEngine();
            this.Speed = carPartsFactory.CreateSpeed();
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