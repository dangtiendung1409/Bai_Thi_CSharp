using System;

namespace GeometryExample
{
    class Cylinder
    {
        private double Radius { get; set; }
        private double Height { get; set; }
        private double BaseArea { get; set; }
        private double LateralArea { get; set; }
        private double TotalArea { get; set; }
        private double Volume { get; set; }

        public void Process()
        {
            Console.Write("Enter the radius of the cylinder: ");
            Radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the cylinder: ");
            Height = Convert.ToDouble(Console.ReadLine());

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Calculation Results:");
            Console.WriteLine($"Base Area: {BaseArea}");
            Console.WriteLine($"Lateral Area: {LateralArea}");
            Console.WriteLine($"Total Area: {TotalArea}");
            Console.WriteLine($"Volume: {Volume}");
        }
    }
}
