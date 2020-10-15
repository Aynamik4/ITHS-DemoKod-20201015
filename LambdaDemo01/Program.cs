using System;

namespace LambdaDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Named method...
            TakeAMethodAsParameter(null);

            //Lambda expression...
            TakeAMethodAsParameter(() =>
            {
                Console.WriteLine("Any old message");
                Console.WriteLine("Another old message");
            });
        }

        static void VoidParameterLess()
        {
            Console.WriteLine("Any old message");
            Console.WriteLine("Another old message");
        }

        static void TakeAMethodAsParameter(Action a)
        {
            a?.Invoke();
        }
    }
}
