internal class Person : IBehaver
{
    /// <inheritdoc />
    public void Sleep()
    {
        Console.WriteLine("sleep 8 h");
        Thread.Sleep(200);
    }

    /// <inheritdoc />
    public void Eat()
    {
        Console.WriteLine("Eat the meal");
        Thread.Sleep(1000);
    }

    /// <inheritdoc />
    public void Play()
    {
        Console.WriteLine("play the game");
        Thread.Sleep(200);
    }

    /// <inheritdoc />
    public void Weak()
    {
        Console.WriteLine("weak up for sleep");
        Thread.Sleep(1000);
    }
}