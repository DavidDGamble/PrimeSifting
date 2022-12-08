using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PrimeSifting.Models;

namespace PrimeSifting.Test
{
  [TestClass]
  public class NumbersTests
  {
    [TestMethod]
    public void CreateList_CreatesNewListOfNumbersUpToInput_List()
    {
      List<int> numbers = new List<int> { 2, 3, 4, 5};
      Numbers testNumbers = new Numbers();
      
      CollectionAssert.AreEqual(numbers, testNumbers.CreateList(5));
    }

    [TestMethod]
    public void ListPrimeNums_ListsPrimeNumbersFromList_List()
    {
      List<int> expected = new List<int> { 2, 3, 5, 7 };  //creates a new local list
      Numbers testNumbers = new Numbers();  //creates a new instance to o
      List<int> testList = testNumbers.CreateList(10);
      List<int> test = testNumbers.ListPrimeNums(testList);
      //--- foreach only runs if test is failing ---
      foreach(int element in test){
        Console.WriteLine(element);
      }
      //------------------------------------------
      CollectionAssert.AreEqual(expected, testNumbers.ListPrimeNums(testList));
    }
  }
}