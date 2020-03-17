using System;
using System.Text;

namespace FizzBuzz.Domain
{
  class Program
  {
    public static void Main(string[] args)
    {
      FizzBuzz(75);
    }

    public static void FizzBuzz(int n)
    {
      int countFizz = 0;
      int countBuzz = 0;
      int countFizzBuzz = 0;
      for (int i = 1; i <= n; i++)
      {
        if ((i % 5 != 0) && (i % 3 != 0))
        {
          Console.WriteLine(i);
        }
        else if ((i % 3 == 0) && (i % 5 == 0))
        {
          Console.WriteLine("FizzBuzz");
          countFizzBuzz++;
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("Fizz");
          countFizz++;
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Buzz");
          countBuzz++;
        }
      }
      Console.WriteLine("num of Fizz: " + countFizz);
      Console.WriteLine("num of Buzz: " + countBuzz);
      Console.WriteLine("num of FizzBuzz: " + countFizzBuzz);
    }
  }
}
