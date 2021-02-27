using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] students = new string[3];
				

			////string[] students2 ={ "engin", "derin", "murat" };
			//foreach (var student in students2)
			{
				//Console.WriteLine(student);
			}
			string[,] regions = new string[3, 3] 
			{
				{ "elazığ", "bingöl" , "malatya" },
				{ "rize", "trabzon", "samsun" },
				{ "istanbul", "izmit", "yalova" },
			};
			for (int i = 0; i <= regions.GetUpperBound(0); i++)
			{
				for (int j = 0; j <= regions.GetUpperBound(1); j++)
					
				{
					Console.WriteLine(regions[i, j]);

				}
				Console.WriteLine("*********");
			}
			
			Console.ReadLine();

		}
		
	}
	

}
