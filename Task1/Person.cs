namespace Task1;

public class Person
{
    public string FirstName;
    public string LastName;
    public int Age ;
    public string Address;

    public void GetFullName()
    {
        System.Console.WriteLine($"My name is {FirstName} {LastName}");

    }

    public int GetBirthYear()
    {
        return 2024 - Age;
    }

}
