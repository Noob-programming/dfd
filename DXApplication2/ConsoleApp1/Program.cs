
Console.WriteLine(5.IsEven());
Console.WriteLine(6.IsEven());
const int x = 10;
const int y = 11;
Console.WriteLine(x.IsEqual(y));
Console.WriteLine(x.Objester());

internal static class Ex
{
	public static bool IsEven(this int x) => x % 2 == 0;

	public static bool IsEqual(this int x, int y) => x == y;
	public static bool Objester(this object? x) => x == null;
}
