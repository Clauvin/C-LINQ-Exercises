using System;
using System.Linq;

//Write a program in C# Sharp to display numbers, multiplication of number with frequency and frequency of a number of giving array
public class Program
{

	public static void Main()
	{
        int [] numbers  = new int[] {5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2};

        var strQuery =
            from x in numbers
			group x by x into y  
			select y; 

		foreach (var arrNo in strQuery)  
		{  
			Console.WriteLine("Number " + arrNo.Key + "| N * frequency " + (arrNo.Key * arrNo.Count()) + "| Frequency " + arrNo.Count());  
		} 
	}
}
