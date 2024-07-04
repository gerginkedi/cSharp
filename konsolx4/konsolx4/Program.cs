namespace konsolx4

{

    internal class Program
    {
        static void Main(string[] args)
        {
            clas car1= new clas();
            car1.brand = "ford";
            car1.age = 12;
            car1.colour = "black";
            Console.WriteLine(car1.brand);
            Console.WriteLine(car1.colour);
            Console.WriteLine(car1.age);
        }
    }
}