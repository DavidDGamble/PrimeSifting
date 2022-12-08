using System;
using PrimeSifting.Models;

namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\nEnter a number to see all prime numbers leading up to your number:\n");
      int userNum = int.Parse(Console.ReadLine());
      Numbers newNumber = new Numbers();
      List<int> userList = newNumber.CreateList(userNum);
      List<int> userPrimeList = newNumber.ListPrimeNums(userList);
      Console.WriteLine("---------------");
      Console.WriteLine("Your prime numbers are: ");
      foreach(int element in userPrimeList){
        Console.WriteLine(element);
      }
      Console.WriteLine("---------------");
      Main();
    }
  }
}