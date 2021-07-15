//Write a program in C# Sharp to find the number of an array and the square of each number.

using System;
using System.Linq;
					
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
            select "Number = " + num + "|Square = " + (num * num);

        // 3. Query execution.
        foreach (string num in numQuery)
        {
            Console.WriteLine(num);
        }
	}
}
