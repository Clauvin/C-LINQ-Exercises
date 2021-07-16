using System;
using System.Linq;

//Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80 as output.
public class Program
{

	public static void Main()
	{
		int[] list = new int[]{55, 200, 740, 76, 230, 482, 95};
		
        var intQuery =
            from x in list
			where x > 80
			group x by x into y
			select y; 
		
		foreach (var number in intQuery){
			foreach(var num in number.ToArray()){
				Console.WriteLine(num);
			}
		}
	}
}
