using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    public class ClassB:ParentClass,ImyInterface
    {
        public void PrintHello()
        {
            Console.WriteLine("\"Hello Interface\""); 
        } 

        public void SortAscDesc(List<string> myStrList)
        {
            myStrList.Sort(); 
            Console.WriteLine("\nPrint the list of strings ascending:");        
            foreach(string str in myStrList)
            {
                Console.Write("{0} ", str);
            }
            myStrList.Reverse(); 
            Console.WriteLine("\nPrint the list of strings descending:");        
            foreach(string str in myStrList)
            {
                Console.Write("{0} ", str);
            }            
        }

        public void FilterWhiteSpaces(List<string> myStrList)
        {
            Console.WriteLine("\n\nPrinting list of strings, not selecting white spaces (using linq):");        
            IEnumerable<string> query = from word in myStrList
                                        where word.Trim().Length > 0 
                                        select word; 
            foreach (var word in query)
            {
                Console.Write("{0} ", word); 
            }
        }

        public void RemoveDuplicates(List<int> myIntList)
        {
            Console.WriteLine("\n\nPrinting the list of integers removing duplicate numbers (using foreach to print filtered list):");
            foreach(var numbers in from numbers in myIntList.Distinct()
                                    select numbers)
            {
                Console.Write("{0} ", numbers); 
            }

        }
    }
}