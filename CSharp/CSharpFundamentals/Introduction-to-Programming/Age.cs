using System;
using System.Globalization;
class AgeAfter10Y
{
    static void Main()
    {
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);
        DateTime presentYear = DateTime.Now;
        TimeSpan timeSpan = presentYear - birthDate;
        DateTime Age = DateTime.MinValue.AddDays(timeSpan.Days);
        Console.WriteLine(Age.Year - 1);
        int ageAFterTen = Age.Year + 9;
        Console.WriteLine(ageAFterTen);
    }
}
