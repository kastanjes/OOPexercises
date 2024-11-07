using System;

interface IDynArray<T> {
		void Append(T element);
		void Insert(int i, T element);
		void Remove(int i);
		void Se(int i, T element);
		T Get(int i);
		int GetFill();
		}
		
class DynArray<T> : IDynArray
{
	T[] array;
	int capacity = 0;
	int fill;
	
	
	void Append(T element)
	{
		T[] newArray;
		
		capacity++;
		newArray = new T[capacity];
		
	}
	
	void Insert(int i, T element)
	{
		
			
	}
	
	void Remove(int i)
	{
		
	}
	
	void Se(int i, T element)
	{
		
	}
	
	T Get(int i)
	{
		
	}
	
	int GetFill()
	{
		
	}
	
}
		
class Program
{
	static void Main()
	{
		DynArray<int> a = new DynArray<int>();
		
		Console.WriteLine("Add elements:");
		Console.WriteLine(a);
		
		for (int i=0 ; i<20 ; i++) {
			a.Append(i);
			Console.WriteLine(a);
		}
		
		Console.WriteLine("");
		
		Random random = new Random();
		
		Console.WriteLine("Remove elements:");
		Console.WriteLine(a);
		
		for (int i=19 ; i>=0 ; i--) {
			a.Remove(random.Next(a.GetFill()));
			Console.WriteLine(a);
	}	
}


	
	
	
