using System;

namespace PrimeSifting.Models
{
  public class Numbers
  {
    public List<int> CreateList(int input)
    {
      List<int> newList = new List<int> { };
      for (int i = 2; i <= input; i++)
      {
        newList.Add(i);
      }
      return newList;
    }

    //create a list of prime numbers given an input

    public List<int> ListPrimeNums(List<int> input)
    {
      List<int> newList = input;
      for (int i = 4; i <= newList[newList.Count - 1]; i = i + 2)
      {
        newList.Remove(i);
      }
      for (int i = 6; i <= newList[newList.Count - 1]; i = i + 3)
      {
        newList.Remove(i);
      }
      for (int i = 10; i <= newList[newList.Count - 1]; i = i + 5)
      {
        newList.Remove(i);
      }
      for (int i = 14; i <= newList[newList.Count - 1]; i = i + 7)
      {
        newList.Remove(i);
      }
      return newList;
    }
  }
}