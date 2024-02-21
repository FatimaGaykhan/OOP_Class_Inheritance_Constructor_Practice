using OOP_Class_Inheritance_Tasks;

//string name1 = "Fatima";
//string surname1 = "Gaykhanova";
//int age1  = 22;

//string name2 = "Sadigkhan";
//string surname2 = "Gaykhanoiv";
//int age2 = 26;

//string name3 = "Kamala";
//string surname3 = "Gaykhanova";
//int age3 = 50;

//Console.WriteLine($"{name1} {surname1} {age1}");

//var stu1 = new
//{
//    name = "Amiraslan",
//    surname = "Miriyev",
//    age = 33

//};

//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22 

//};

//Console.WriteLine(stu1.name+" "+stu1.surname+" "+ stu1.age);



Student stu1 = new Student();
stu1.name = "Ismayil";
stu1.surname = "Ceferli";
stu1.age = 24;
stu1.address = "Ehmedli";
 
Student stu2 = new();
stu2.name = "Test";
stu2.surname = "Testov";
stu2.age = 70;
stu2.address = "Xetai";
stu2.phone = "115323434";

string fullname = stu1.name + " " + stu1.surname;

//Console.WriteLine(fullname);

Student stu3 = new()
{
    name = "Sirac",
    surname = "Memmedov",
    age = 22,
    address = "Masazir"
};

//Console.WriteLine(stu3.phone );
//Console.WriteLine(stu3.GetFullName());
//var result = stu2.GetFullDatas();
//Console.WriteLine(result);

//Student[] students = { stu1, stu2, stu3 };


// void ShowAll(Student[] datas)
//{
//    foreach (var item in datas)
//    {
//        Console.WriteLine(item.GetFullDatas());
//    }
//}
//ShowAll(students);


Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student [] datas,int age)
//{
//    Student foundStudent = new();
//    foreach (var data in datas)
//    {
//        if (data.age==age)
//        {
//            foundStudent= data;
//            break;
//        }

//    }
//    return foundStudent;
//}


//Student GetByAge(Student[] datas, int age)
//{
//    //return Array.Find(datas, m => m.age == age);
//    var result = datas.FirstOrDefault(m => m.age == age);
//    return result!=null?result:new Student();
//}

//Student GetByAge(Student[] datas, int age)
//{
//    return datas.FirstOrDefault(m => m.age == age);

//}

//var result = GetByAge(students, 25);
//if (result!=null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("Data Not Found");
//}

//Student GetByAge(Student[] datas, int age)=> datas.FirstOrDefault(m => m.age == age);


//var result = GetByAge(students, 25);
//if (result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("Data Not Found");
//}

Book book = new Book("Elmir");
Console.WriteLine(book.name);
//Console.WriteLine(book.name+" "+ book.author);