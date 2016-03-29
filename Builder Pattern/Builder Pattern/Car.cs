using System.Text;

namespace Builder_Pattern
{
    public class Car
    {
        public string Frame { get; set; }
        public string Doors { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Tyres { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Car Frame : " + this.Frame);
            sb.AppendLine("Car Doors : " + this.Doors);
            sb.AppendLine("Car Engine : " + this.Engine);
            sb.AppendLine("Car Color : " + this.Color);
            sb.AppendLine("Car Tyres : " + this.Tyres);

            return sb.ToString();
        }
    }
}