
using Task2;

var rec1 = new Rectangle();
System.Console.Write($"width = ");
rec1.Width = Convert.ToDouble(Console.ReadLine());
System.Console.Write($"height = ");

rec1.Height = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Area = {rec1.Area()}");

