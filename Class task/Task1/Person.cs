namespace Task1;

public class Person
{
public string FirstName;
public string LastName;
public int Age ;

public string GetInfo()
{
    return $"FirstName: {FirstName} \nLastName: {LastName} \nAge: {Age}";
}

}
