using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
        string str = "Display the characters and frequency of character from giving string";

        var strQuery =
            from x in str
			group x by x into y  
			select y; 

		foreach (var arrNo in strQuery)  
		{  
			Console.WriteLine("Letter "+arrNo.Key + " appears " + arrNo.Count()+" times");  
		} 
	}
}
