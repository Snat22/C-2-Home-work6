using Task4;

var employe1 = new Employee();
System.Console.Write("Enter employee's FirstName:");
employe1.FirstName = Console.ReadLine();
System.Console.Write("Enter employee's LasttName:");
employe1.LastName = Console.ReadLine();
System.Console.Write("Enter employee's Age:");
employe1.Age = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter employee's Position:");
employe1.Position = Console.ReadLine();
System.Console.Write("Enter employee's Salary:");
employe1.Salary = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine(employe1.GetInfo());
System.Console.WriteLine();
        System.Console.Write("Set a new Salary: ");

employe1.SetSalary(Convert.ToDecimal(Console.ReadLine()));
System.Console.WriteLine(employe1.GetInfo());



