using BaiThiCSharp.BaiThi2;

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion(200, "Lion");
        Tiger tiger = new Tiger(150, "Tiger");

        Animal[] animals = { lion, tiger };

        foreach (var animal in animals)
        {
            animal.Show();
        }
    }
}
