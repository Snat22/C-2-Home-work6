public class Car
{
    public string Make;
    public string Model;
    public int Year;
    public double Mileage;
    public double Fuel;


public Car(string mark,string model,int year)
{
    Make = mark;
    Model = model;
    Year = year;
}
    public void Drive (double miles)
    {
        Mileage = miles;
    }
    public void AddFuel(double gallons)
    {
        Fuel=gallons;
    }
}
