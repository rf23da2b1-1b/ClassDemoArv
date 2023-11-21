// See https://aka.ms/new-console-template for more information
using ClassDemoArv.model;

Console.WriteLine("Hello, World!");


Employee peter = new Employee(3, "peter", "mail@mail.dk", 201, 33);
Employee defaultEmployee = new Employee();

Console.WriteLine(defaultEmployee);

Console.WriteLine(peter);

int løn = peter.Salary();
Console.WriteLine( "løn peter = " + løn);

Ansat peter2 = new Employee(3, "peter", "mail@mail.dk", 201, 33);
Console.WriteLine(peter2);

Console.WriteLine(peter2.Salary());




//Ansat kanViDet = new Ansat(3, "kurt", "en mail");
//Console.WriteLine(kanViDet);