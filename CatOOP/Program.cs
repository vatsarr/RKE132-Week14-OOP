﻿
Cat newCat = new Cat("Garfield", "ginger");
Console.WriteLine($"{newCat.Name} wants a rub on its belly.");

while (newCat.BellyFull > 5)
{
    newCat.Sleep();
}
newCat.Meow();
newCat.ShowCatData();

class Cat
{
    private string _name;
    private string _color;
    private int _bellyFull;
    public Cat(string name, string color)
    {
        _name = name;
        _color = color;
        _bellyFull = 10;
        Console.WriteLine($"A {color} cat named {name} has been created");
    }

    public string Name
    {
        get { return _name; }
    }
    public int BellyFull
    {
        get { return _bellyFull; }
    }
    public void Sleep()
    {
        _bellyFull--;
        Console.WriteLine($"{_name} says Z-z-Z-z-Z-z");
    }
    public void Meow()
    {
        Console.WriteLine($"{_name} says: Meow!");
    }
    public void ShowCatData()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Level on hungriness: {_bellyFull}");
    }

}