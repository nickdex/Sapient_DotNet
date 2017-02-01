using System;

namespace Assignment_Feb01
{
	class MainClass
	{
		private static CustomList test;

		// Demos total 4 given interfaces
		public static void Main(string[] args)
		{
			demoList();
			demoEnumerable(); // Run with Above and contains IEnumerator demo also

			demoClone();
			Console.ReadLine();
		}

		static void demoEnumerable()
		{
			IEnumerableDemo demo = new IEnumerableDemo(test);
			foreach (var item in demo)
			{
				var data = item as string;
				Console.WriteLine(data);
			}
		}

		static void demoClone()
		{
			CloneDemo demo = new CloneDemo(2);
			Console.WriteLine("Object: " + demo.ToString() + "value: " + demo.Value);
			CloneDemo clone = demo.Clone() as CloneDemo;
			Console.WriteLine("Object: " + clone.ToString() + "value: " + clone.Value);
		}

		public static void demoList()
		{
			test = new CustomList();

			// Populate the List
			Console.WriteLine("Populate the List");
			test.Add("one");
			test.Add("two");
			test.Add("three");
			test.Add("four");
			test.Add("five");
			test.Add("six");
			test.Add("seven");
			test.Add("eight");
			test.PrintContents();
			Console.WriteLine();

			// Remove elements from the list
			Console.WriteLine("Remove elements from the list");
			test.Remove("six");
			test.Remove("eight");
			test.PrintContents();
			Console.WriteLine();

			// Add an element to the end of the list
			Console.WriteLine("Add an element to the end of the list");
			test.Add("nine");
			test.PrintContents();
			Console.WriteLine();

			// Insert an element into the middle of the list
			Console.WriteLine("Insert an element into the middle of the list");
			test.Insert(4, "number");
			test.PrintContents();
			Console.WriteLine();

			// Check for specific elements in the list
			Console.WriteLine("Check for specific elements in the list");
			Console.WriteLine("List contains \"three\": {0}", test.Contains("three"));
			Console.WriteLine("List contains \"ten\": {0}", test.Contains("ten"));

		}
	}
}
