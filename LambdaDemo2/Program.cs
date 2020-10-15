using System;

namespace LambdaDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Named method...
            TakeAMethodAsParameter(VoidWithParameters);

            //Lambda expression...
            //TakeAMethodAsParameter();
        }

        static void VoidWithParameters(string name, int age)
        {
            Console.WriteLine($"{name} är {age} år gammal.");
        }

        static void TakeAMethodAsParameter(Action<string, int> a)
        {
            a("Håkan", 58);
        }
    }
}
