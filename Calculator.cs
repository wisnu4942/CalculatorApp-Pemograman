class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: (0) + (1) = (2)", a, b, Penambahan(a,b));
		Console.WriteLine("Hasil Pengurangan: (0) - (1) = (2)", a, b, Pengurangan(a,b)); 
		Console.WriteLine("Hasil Perkalian: (0) * (1) = (2)", a, b, Perkalian(a,b));
		Console.WriteLine("Hasil Pembagianan: (0) / (1) = (2)", a, b, Pembagianan(a,b));
		
		Console.WriteLine("\nTekan sembarang untuk keluar");
		Console.ReadKey();
	}
	
	static void Penambahan(int a, int b)
	{
		return a + b;
	}
	
	static void Pengurangan(int a, int b)
	{
		return a - b;
	}
	
	static void Perkalian(int a, int b)
	{
		return a * b;
	}
	
	static void Pembagianan(int a, int b)
	{
		return a / b;
	}
}	