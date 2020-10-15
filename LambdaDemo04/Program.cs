using System;

namespace LambdaDemo04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Named method...
            TakeAMethodAsParameter(IntWithParameters);

            ////Lambda expression...
            //TakeAMethodAsParameter();
        }

        static int IntWithParameters(string name)
        {
            return name.Length;
        }

        static void TakeAMethodAsParameter(Func<string, int> a)
        {
            int i = a(Console.ReadLine());
            Console.WriteLine($"Length of string: {i}");
        }
    }
}
