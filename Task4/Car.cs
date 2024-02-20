namespace Task4;

public class Car
{
    public string Marke;
    public string Model;
    public int Year ;
    public double Mileage;
    public double Fuel ;


    public Car(string make, string model,int year)
    {
    }

    public void Drive(double miles)
    {
        if (Fuel < miles)
        {
            System.Console.WriteLine("Vam nuzhno zapravitsa dlya ezdi na machine ");
        }
    }

    public void AddFuel(double gallon)
    {
        
    }
    
}
