
using System;

namespace Practice_DSA.Beginner
{
    public class NumberOperation
    {
        public void CallOperation()
        {
            Console.WriteLine("First Number");
            string firstNumber=Console.ReadLine();
            Console.WriteLine("Second Number");
            string secondNumber = Console.ReadLine();
            if (int.TryParse(firstNumber, out int FirstNumber) && int.TryParse(secondNumber, out int SecondNumber))
            {
                Console.WriteLine("Sum is-> {0}" ,new NumberOperation().OperationSum(FirstNumber, SecondNumber));
                Console.WriteLine($"Difference is -> {new NumberOperation().OperationDifference(FirstNumber,SecondNumber)}");
                Console.WriteLine("Multiplication is-> {0}", new NumberOperation().OperationMultiplication(FirstNumber, SecondNumber));
                Console.WriteLine("Division is-> {0}", new NumberOperation().OperationDivision(FirstNumber, SecondNumber));
                Console.WriteLine("Remainder is-> {0}", new NumberOperation().OperationRemainder(FirstNumber, SecondNumber));
            }
            else Console.WriteLine("Both Input Should Be Integer Number Only");
        }
        public int OperationSum(int n,int m)
        {
            return n + m;
        }
        public int OperationDifference(int n,int m)
        {
            return n - m;
        }
        public int OperationMultiplication(int n,int m)
        {
            return n * m;
        }
        public int OperationDivision(int n,int m)
        {
            return n / m;
        }
        public int OperationRemainder(int n,int m)
        {
            return n % m;
        }

    }
}
