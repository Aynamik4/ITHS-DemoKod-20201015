using System;

namespace LambdaDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Named method...
            TakeAMethodAsParameter(VoidParameterLess);

            //Lambda expression...
            //TakeAMethodAsParameter();
        }

        static void VoidParameterLess()
        {
            Console.WriteLine("Any old message");
            Console.WriteLine("Another old message");
        }

        static void TakeAMethodAsParameter(Action a)
        {
            a();
        }
    }
}
