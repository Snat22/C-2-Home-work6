using Task1;

var person1 = new Person();
person1.FirstName = "Shahrom";
person1.LastName = "Sharipov";
person1.Age = 24;

person1.GetFullName();
System.Console.WriteLine($"My birth year is {person1.GetBirthYear()}.");