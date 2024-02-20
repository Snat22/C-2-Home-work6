using Task1;

var person1 = new Person();
System.Console.Write("Enter your FirstName: ");
person1.FirstName = Console.ReadLine();
System.Console.Write("Enter your LastName: ");
person1.LastName = Console.ReadLine();
System.Console.Write("Enter your Age: ");
person1.Age = int.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine(person1.GetInfo());

