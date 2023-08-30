using System;

namespace GeometryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometry Calculation for Cylinder");

            Cylinder cylinder = new Cylinder();
            cylinder.Process();
            cylinder.Result();
        }
    }
}
