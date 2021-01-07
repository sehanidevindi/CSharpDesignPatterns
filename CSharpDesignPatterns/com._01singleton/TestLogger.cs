using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.com._01singleton
{
    class TestLogger
    {
		static void Main()
		{
			Console.WriteLine("---singleton---");
			Logger obj1 = Logger.GetInstance();
			Logger obj2 = Logger.GetInstance();

			Console.WriteLine(obj1.GetHashCode());
			Console.WriteLine(obj2.GetHashCode());


			Console.WriteLine("---non singleton---");
			Test obj3 = new Test();
			Test obj4 = new Test();

			Console.WriteLine(obj3.GetHashCode());
			Console.WriteLine(obj4.GetHashCode());

		}
	}
	class Test
	{


	}
}
