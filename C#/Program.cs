using Practice_DSA.Beginner;
using Practice_DSA.LeetCode;
using System;

namespace Practice_DSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Function ....");

            //var nishay = "Nishant".Split();
            //Console.WriteLine(nishay);
            string Word = "27. Remove Element".Replace(".", "_");
            Console.WriteLine(Word.Replace(" ", "_"));

            //Console.WriteLine(new _3330_Find_the_Original_Typed_String_1().PossibleStringCount("abbcccc"));
            //Console.WriteLine(new _28_Find_the_Index_of_the_First_Occurrence_in_a_String().StrStr("aasadbutsad", "sad"));
            int[] ints = { 0, 1, 2, 2, 3, 0, 4, 2 };
            Console.WriteLine(new _27_Remove_Element().RemoveElement(ints, 2));
            Console.WriteLine(ints);
            Console.ReadLine();
        }
    }
}
