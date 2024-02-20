using Task3;

var student1 = new Student();
student1.Name = "Shahrom Sharipov";
student1.GradeLevel = 9;
student1.TestScores = new double [5]{70.0,70.0,80.0,90.0,91.0};
System.Console.WriteLine(student1.GetInfo());
System.Console.WriteLine("--------------------------------------------------------------------------------------");


var student2 = new Student();
student2.Name = "Abdulloj Abduloev";
student2.GradeLevel = 10;
student2.TestScores = new double [5]{55.0,60.0,80.0,90.0,90.0};
System.Console.WriteLine(student2.GetInfo());
System.Console.WriteLine("--------------------------------------------------------------------------------------");

var student3 = new Student();
student3.Name = "Nurullo Sulaymonov";
student3.GradeLevel = 11;
student3.TestScores = new double [5]{95.0,95.0,95.0,95.0,95.0};
System.Console.WriteLine(student3.GetInfo());

var student4 = new Student();
student4.Name = "Alijoni Zabiri";
student4.GradeLevel = 12;
student4.TestScores = new double [5]{90.0,90.0,89.0,91.0,90.0};
System.Console.WriteLine(student4.GetInfo());

var student5 = new Student();
student5.Name = "Olimjon Tojaev";
student5.GradeLevel = 9;
student5.TestScores = new double [5]{85.0,85.0,85.0,85.0,85.0};
System.Console.WriteLine(student5.GetInfo());