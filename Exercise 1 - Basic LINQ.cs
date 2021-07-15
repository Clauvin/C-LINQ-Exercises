// Write a program in C# Sharp to shows how the three parts of a query operation execute.

public class Program
{
	public static void Main()
	{
		 // The Three Parts of a LINQ Query:
        // 1. Data source.
        int[] numbers = new int[16] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers
            where num < 10 
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write(num + " ");
        }
	}
}
