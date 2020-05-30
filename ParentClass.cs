using System;
using System.Collections.Generic; 

namespace Exercise_3
{
    public class ParentClass
    {
        public void CompareLenghtTwoStrings (string str1, string str2)
        {
            Console.WriteLine("\nComparing if string lenght is the same for:\n    String 1:\"{0}\"\n    String 2:\"{1}\"",str1, str2);
            if (str1.Length == str2.Length)
            {
                Console.WriteLine("RESULT: String lenght is the same");
            }
            else 
            {
                Console.WriteLine("RESULT: String lenght is not the same");
            }
        }

        public void CompareSizeTwoLists(List<int> lst1, List<int> lst2)
        {
            Console.WriteLine("\nComparing if the size of two List is the same");
            if (lst1.Count == lst2.Count)
            {
                Console.WriteLine("RESULT: Lists size is the same");
            }
            else 
            {
                Console.WriteLine("RESULT: Lists size is not the same");
            }
        }
    }
}
