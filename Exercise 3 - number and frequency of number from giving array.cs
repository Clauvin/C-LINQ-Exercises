using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
        int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 }; 

        var numQuery =
            from x in numbers
			group x by x into y  
			select y; 

		foreach (var arrNo in numQuery)  
		{  
			Console.WriteLine("Number "+arrNo.Key + " appears " + arrNo.Count()+" times");  
		} 
	}
}
