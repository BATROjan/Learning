using System;

namespace ConsoleApplication1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("введите первое число");
      int firstNumber = int.Parse(Console.ReadLine());
      Console.WriteLine("введите первое число");
      int secondNumber = int.Parse(Console.ReadLine());
      int currentNumber = firstNumber;
      int CountOfEvenNumber = 0;
      int CountOfOddNumber = 0;
      while ( currentNumber <=secondNumber)
      {
        if (currentNumber%2==0)
        {
          CountOfEvenNumber++;
        }
        else
        {
          CountOfOddNumber++;
        }
        currentNumber++;
      }
      Console.WriteLine("в диапазоне от " + firstNumber + " до " + secondNumber);
      Console.WriteLine("кол-во четных чисел " + CountOfEvenNumber);
      Console.WriteLine("кол-во нечетных чисел " + CountOfOddNumber);
    }
  }
}