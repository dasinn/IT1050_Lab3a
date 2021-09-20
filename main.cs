using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a temperature in Celsius:");
    double celsius = Convert.ToDouble(Console.ReadLine());
    double farenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine ("The Farenheit equivalent for " + celsius + " degrees Celsius is " + farenheit);

    if (farenheit < 32)
    {
      Console.WriteLine ("This temperature is below freezing temperature of 32 degrees Farenheit.");
    }
    if (farenheit > 212)
    {
      Console.WriteLine ("This temperature is above boiling point temperature of 212 degrees Farenheit.");
    }


  }
}