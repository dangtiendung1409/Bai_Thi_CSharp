using System;
namespace BaiThiCSharp.BaiThi2
{
    class Animal
    {
        protected double Weight { get; set; }
        protected string Name { get; set; }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }

        public void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}

