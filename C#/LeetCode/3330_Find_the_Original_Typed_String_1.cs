
/*
Alice is attempting to type a specific string on her computer. However, she tends to be clumsy and may press a key for too long, resulting in a character being typed multiple times.

Although Alice tried to focus on her typing, she is aware that she may still have done this at most once.

You are given a string word, which represents the final output displayed on Alice's screen.

Return the total number of possible original strings that Alice might have intended to type.

Example 1:

Input: word = "abbcccc"

Output: 5

Explanation:

The possible strings are: "abbcccc", "abbccc", "abbcc", "abbc", and "abcccc".

Example 2:

Input: word = "abcd"

Output: 1

Explanation:

The only possible string is "abcd".

Example 3:

Input: word = "aaaa"

Output: 4

 

Constraints:

1 <= word.length <= 100
word consists only of lowercase English letters.
 */



using System.Linq;

namespace Practice_DSA.LeetCode
{
    public class _3330_Find_the_Original_Typed_String_1
    {
        public int PossibleStringCount(string word)
        {
            int Totalcount = 1;
            char previous = ' ';
            int currentcount = 0;
            foreach(char i in word)
            {
                if (previous == i)
                {
                    Totalcount++;
                    continue;
                }
                previous = i;

            }

            return Totalcount ;
        }
        public int PossibleStringCount1(string word)
        {
            int Totalcount = 1;
            char previous = ' ';
            int currentcount = 1;
            foreach(char i in word)
            {
                if (previous == i)
                {
                    currentcount++;
                    continue;
                }
                    
                Totalcount += currentcount - 1;
                currentcount = 1;
                previous = i;

            }

            return Totalcount += currentcount - 1;
        }
        public int PossibleStringCount2(string word) // this will Work While No repetation of same char later
        {
            int Totalcount = 1;
            var TotalcountVal = word.ToCharArray().GroupBy(a => a).ToDictionary(g=>g.Key, g => g.Count());

            foreach(var pair in TotalcountVal)
            {
                Totalcount += pair.Value - 1;
            }
            return Totalcount ;
        }
    }
}

