using System;
using static System.Console;

namespace COPC.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Put some test code here to test your solution on your local machine.
            var solution = new ChallengeSolution();

            var problem = "";

            var results = solution.GetChallengeSolutions(problem);

            foreach(var r in results)
            {
                WriteLine(r);
            }
        }
    }
}
