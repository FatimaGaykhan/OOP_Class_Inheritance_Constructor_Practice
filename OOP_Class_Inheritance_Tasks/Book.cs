using System;
namespace OOP_Class_Inheritance_Tasks
{
	public class Book
	{
		public string name;
		public string author;

		public Book()
		{
			Console.WriteLine("PB101");
		}
		public Book(string name)
		{
			this.name = name;
		}
		public Book(string name,string author)
		{
			this.name = name;
			this.author = author;
		}

	}
}

