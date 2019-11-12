using System;

namespace BinaryGapComputation
{
    public class ComputeGap
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an Integer whose binary gap needs to be calculated: ");
            var n = Convert.ToInt32(Console.ReadLine());
            var gap = new ComputeMaxZeros();
            Console.Write(gap.MaxZeros(n));
        }
    }
}
