
var file = new Stack<int>();

file.Push(1);
file.Push(2);
file.Push(3);
file.Push(4);
file.Push(5);
file.Push(6);
file.Push(7);
file.Push(8);
file.Push(9);
file.Push(10);

Print(file[2..5]);

return;

void Print<T>(T data)
{
	Console.WriteLine($@"{data}");
}

public class Stack<T>
{
	int position;
	T[] data = new T[100];
	public void Push(T obj) => data[position++] = obj;
	public T Pop() => data[--position];

	public T[] this[Range index] => data[index];
}

