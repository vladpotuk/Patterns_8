using System;

class Program
{
    static void Main(string[] args)
    {
        
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

        
        coffee = new MilkDecorator(coffee);
        coffee = new VanillaDecorator(coffee);
        coffee = new ChocolateDecorator(coffee);
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

        
        coffee = new SugarDecorator(coffee);
        coffee = new CreamDecorator(coffee);
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

        Console.ReadKey();
    }
}
