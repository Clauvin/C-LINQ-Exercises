using System;
using System.Linq;

//Write a program in C# Sharp to find the string which starts and ends with a specific character

//Yes, this is a really covoluted way to use LINQ to do this.
public class Program
{

	public static void Main()
	{
        string phrase = "The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'";
		
		char phrase_starts_with = 'A';
		char phrase_ends_with = 'M';
		
        var strQuery1 =
            from x in phrase
			where x == phrase_starts_with  
			select phrase.IndexOf(phrase_starts_with); 

		string phrase_2 = phrase.Remove(0, strQuery1.FirstOrDefault());
		
		var strQuery2 =
			from x in phrase_2
			where x == phrase_ends_with
			select phrase_2.IndexOf(phrase_ends_with); 
		
		Console.WriteLine(phrase_2);
		Console.WriteLine(phrase_2.IndexOf(phrase_ends_with));
		Console.WriteLine(strQuery2.FirstOrDefault());
		
		phrase_2 = phrase_2.Remove(strQuery2.FirstOrDefault()+1);
		
		Console.WriteLine(phrase_2);
	}
}
