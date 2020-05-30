using System;
using System.Collections.Generic; 

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var myParentClass1 = new ParentClass(); 
                var myString1 = "This is the first string used on Parent class";
                var myString2 = "This is the second string used on Parent class"; 
                myParentClass1.CompareLenghtTwoStrings(myString1, myString2); 

                List<int> myList1 = new List<int> {8,2,10,4,5,1,50,6,7,9,3};
                List<int> myList2 = new List<int> {6,8,4,1,9,3,0,50,38};
                myParentClass1.CompareSizeTwoLists(myList1, myList2);

                var myClassB= new ClassB();
                myString1 = "First string used on ClassB";
                myString2 = "Second string used on ClassB"; 
                myClassB.CompareLenghtTwoStrings(myString1, myString2);

                List<int> myList3 = new List<int> {10,14,65,18,50,68,75,91,33};
                List<int> myList4 = new List<int> {66,85,49,17,95,32,50};
                myClassB.CompareSizeTwoLists(myList3, myList4);

                Console.WriteLine("\nFunctionality to Print:"); 
                myClassB.PrintHello(); 

                List<string> myStrList1 = new List<string> {"Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " "}; 
                myClassB.SortAscDesc(myStrList1);
                myClassB.FilterWhiteSpaces(myStrList1); 

                List<int> myIntList1 = new List<int> {1,1,2,3,4,4,5,6,7,8,10};
                myClassB.RemoveDuplicates(myIntList1); 



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

        }
    }
}
