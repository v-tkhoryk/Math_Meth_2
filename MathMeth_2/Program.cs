using QueueingSystem;

namespace MathMeth_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First task
            /*
            var queue1 = new MonoChannel(0.1, 2);
            queue1.PrintResults();

            var queue2 = new MonoChannel(0.1, 5);
            queue2.PrintResults();

            var queue3 = new MonoChannel(0.1, 9);
            queue3.PrintResults();

            var queue4 = new MonoChannel(0.2, 1);
            queue4.PrintResults();

            var queue5 = new MonoChannel(0.5, 1);
            queue5.PrintResults();

            var queue6 = new MonoChannel(0.9, 1);
            queue6.PrintResults();

            var queue7 = new MonoChannel(2, 0.1);
            queue7.PrintResults();

            var queue8 = new MonoChannel(5, 0.1);
            queue8.PrintResults();

            var queue9 = new MonoChannel(9, 0.1);
            queue9.PrintResults();
            */
            #endregion
            var multi = new MultiChannel(4, 2, 10);
            multi.PrintResults();

            var multi2 = new MultiChannel(1, 5, 10);
            multi2.PrintResults();

            var multi3 = new MultiChannel(0.3, 9, 10);
            multi3.PrintResults();

            System.Console.ReadLine();
        }
    }
}
