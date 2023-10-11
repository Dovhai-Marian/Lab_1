using System;

class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToCurrency(double amount, string currency)
    {
        if (currency == "USD")
            return amount / usd;
        else if (currency == "EUR")
            return amount / eur;
        else if (currency == "PLN")
            return amount / pln;
        else
            return amount;
    }

    public double ConvertFromCurrency(double amount, string currency)
    {
        if (currency == "USD")
            return amount * usd;
        else if (currency == "EUR")
            return amount * eur;
        else if (currency == "PLN")
            return amount * pln;
        else
            return amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть курс долара (USD):");
        double usdRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть курс євро (EUR):");
        double eurRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть курс злотого (PLN):");
        double plnRate = Convert.ToDouble(Console.ReadLine());

        Converter converter = new Converter(usdRate, eurRate, plnRate);

        Console.WriteLine("Оберіть тип операції:");
        Console.WriteLine("1 - Конвертація з гривні в іноземну валюту");
        Console.WriteLine("2 - Конвертація з іноземної валюти в гривню");

        int operationType = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть суму:");

        double amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть валюту (USD, EUR або PLN):");

        string currency = Console.ReadLine();

        double result = 0;

        if (operationType == 1)
            result = converter.ConvertToCurrency(amount, currency);
        else if (operationType == 2)
            result = converter.ConvertFromCurrency(amount, currency);

        Console.WriteLine($"Результат конвертації: {result}");
    }
}
