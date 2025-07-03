using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Beginner
{
    public class StringOperations
    {

        public void CallOperation()
        {
            Console.WriteLine("First String");
            string first = Console.ReadLine();
            Console.WriteLine("Second String");
            string second= Console.ReadLine();
            if (!string.IsNullOrEmpty(first) && !string.IsNullOrEmpty(second))
            {
                Console.WriteLine("AddString is-> {0}", new StringOperations().OperationConcat(first, second));
                
            }
            else Console.WriteLine("Both Input Should Be Integer Number Only");
        }
        public string OperationConcat(string n, string m)
        {
            return n + m;
        }
    }
}
