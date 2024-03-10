public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{_coffee.GetDescription()}, Milk";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.5;
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{_coffee.GetDescription()}, Sugar";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.2;
    }
}

public class VanillaDecorator : CoffeeDecorator
{
    public VanillaDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{_coffee.GetDescription()}, Vanilla";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.7;
    }
}

public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{_coffee.GetDescription()}, Chocolate";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.9;
    }
}

public class CreamDecorator : CoffeeDecorator
{
    public CreamDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{_coffee.GetDescription()}, Cream";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 0.6;
    }
}
