namespace DotNet_Assignment_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Console.WriteLine("Enter a number(height) and I'll print you a pyramid of the given height : ");
			int height = Convert.ToInt32 (Console.ReadLine());
			printPyramid(height);

		}

		static void printPyramid(int height)
		{
			int increment = 1;
			for(int i =0;i < height;i++)
			{
				for(int j =0;j < height - i - 1; j++)
				{
					Console.Write(" ");
				}
				for(int k = i + increment; k > 0; k--)
				{
					Console.Write("*");
				}
				increment++;
				Console.WriteLine();
			}

		}
	}
}