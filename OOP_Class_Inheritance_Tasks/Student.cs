using System;
namespace OOP_Class_Inheritance_Tasks
{
	class Student
	{
		public string name;
		public string surname;
		public int age;
		public string address;
		public string phone="536478";

		//public void ShowText(string text)
		//{
			
		//	Console.WriteLine(text);
		//}

		public string GetFullName()
		{
			return name + " " + surname;
		}
		public string GetFullDatas()
		{
			string fullData = $"Name:{name} , Surname:{surname} , Age:{age} , Address:{address} , Phone:{phone}";
			return fullData;
		}

		

	}
}

