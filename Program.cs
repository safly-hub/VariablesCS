using System;

namespace VariablesCS
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to C#");
      var numberOfCupsOfCoffee = '1';
      var fullName = "Luke Safly";
      var today = "August, 11th";
      Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);
      Console.Write("What is your name? ");
      var userName = Console.ReadLine();
      Console.WriteLine("It is a pleasure to meet you," + " " + userName);
      Console.Write("How old are you? ");
      var firstNumberAsString = Console.ReadLine();
      var firstOperand = double.Parse(firstNumberAsString);
      Console.Write("What is your shoe size? ");
      var secondNumberAsString = Console.ReadLine();
      var secondOperand = double.Parse(secondNumberAsString);
      var sum = secondOperand + firstOperand;
      Console.WriteLine(sum);
      var product = secondOperand * firstOperand;
      Console.WriteLine(product);
      var difference = secondOperand - firstOperand;
      Console.WriteLine(difference);
      var quotient = secondOperand / firstOperand;
      Console.WriteLine(quotient);
      var remainder = secondOperand % firstOperand;
      Console.WriteLine(remainder);
    }
  }
}
