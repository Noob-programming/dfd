/*
Start();
return;

void Start()
{
    var person = new Person();
    person.Weak();
    person.Eat();
    person.Play();
    person.Sleep();
}


using System.Collections;

var octagon = new Octagon(5);

Console.WriteLine(octagon.GetArea());
Console.WriteLine();
Console.WriteLine(octagon.GetPerimeter());


var a = new Hashtable
{
    { true, null },
    { false, null },
    { 2, 1 },
    { 4, 2 },
    { 5, 4 }
};
Console.WriteLine(a.ToString());
foreach (DictionaryEntry entry in a)
{
    Console.WriteLine(entry.Key + "\t" + entry.Value);
}
Console.ReadKey();

internal interface IReg
{
    int NumberOfSides { get; set; }
    int SideLength { get; set; }
    double GetPerimeter();
    double GetArea();
}


internal class Octagon : IReg
{
    public Octagon(int length)
    {
        NumberOfSides = 8;
        SideLength = length;
    }

    /// <inheritdoc />
    public int NumberOfSides { get; set; }

    /// <inheritdoc />
    public int SideLength { get; set; }

    /// <inheritdoc />
    public double GetPerimeter()
    {
        return NumberOfSides * SideLength;
    }

    /// <inheritdoc />
    public double GetArea()
    {
        return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
    }
}



Rabbit rabbit = new Rabbit();
rabbit.Feel();
Hawk uvular = new Hawk();
uvular.Hunt();
Fish fish = new Fish();
fish.Hunt();
fish.Feel();

interface IPrey
{
    void Feel();
}

interface IPredator
{
    void Hunt();
}


class Rabbit : IPrey
{
    /// <inheritdoc />
    public void Feel()
    {
        Console.WriteLine("the rabbit");
    }
}


class Hawk : IPredator
{
    /// <inheritdoc />
    public void Hunt()
    {
        Console.WriteLine("hawk search for food");
    }
}

class Fish : IPredator, IPrey
{
    /// <inheritdoc />
    public void Hunt()
    {
        Console.WriteLine("The fish search for smaller fish");

    }

    /// <inheritdoc />
    public void Feel()
    {
        Console.WriteLine("swim away");

    }
}
*/

var point = new Point(3, 4);
PrintPoint(point);
return;
static void PrintPoint(IPoint p)
{
    Console.WriteLine("x={0}, y={1}", p.X, p.Y);
}

internal interface IPoint
{
    // Property signatures:
    int X { get; set; }

    int Y { get; set; }

    double Distance { get; }
}

internal class Point : IPoint
{
    // Constructor:
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Property implementation:
    public int X { get; set; }

    public int Y { get; set; }

    // Property implementation
    public double Distance =>
        Math.Sqrt(X * X + Y * Y);
}