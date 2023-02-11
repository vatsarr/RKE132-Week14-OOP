
Console.WriteLine("Enter your dogs name:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog neighborsDog = new Dog("Rexxx");

Console.WriteLine($"My dog is called {myDog.Name}");
Console.WriteLine($"My neighbors dog is called {neighborsDog.Name}\n");

myDog.Rename("Kihvvv");

//myDog.Bark();
Console.WriteLine($"My dogs level of happiness: {myDog.LevelOfHappiness}");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
    Console.WriteLine($"My dogs level of happiness: {myDog.LevelOfHappiness}");
}

myDog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHappiness;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }
}