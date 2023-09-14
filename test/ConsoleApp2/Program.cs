// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a = new MyClass();
a.Send();

internal abstract class IN
{
    public abstract void Send();
}

internal class MyClass : IN
{
    /// <inheritdoc />
    public override void Send()
    {
        Console.WriteLine("nenwnn");
    }
}