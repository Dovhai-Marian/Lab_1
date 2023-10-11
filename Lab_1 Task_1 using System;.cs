using System;

public class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }
    
    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Index: {Index}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Street: {Street}");
        Console.WriteLine($"House: {House}");
        Console.WriteLine($"Apartment: {Apartment}");
    }
}

class Program
{
    static void Main()
    {
        Address address = new Address("54321", "США", "Нью-Йорк", "Бродвей", "25", "Apt 301");
address.DisplayAddress();

    }
}
