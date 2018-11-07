using System.Collections.Generic;

namespace russianpeasant
{
    /// <summary>
    /// Class that accumulates the results of the russian peasant multiplication steps
    /// </summary>
    public class Accumulator
    {
        /// <summary>
        /// The left column results.
        /// </summary>
        public Stack<int> LeftStack { get; private set; } = new Stack<int>();

        /// <summary>
        /// The right column results.
        /// </summary>
        public Stack<int> RightStack { get; private set; } = new Stack<int>();

        /// <summary>
        /// Accumulate the results. Only pairs where <paramref="left"> is odd are accumulated.
        /// </summary>
        /// <param name="left">The left part.</param>
        /// <param name="right">The right part.</param>
        public void Accumulate(int left, int right) {
            if(this.IsOdd(left)) {
                this.LeftStack.Push(left);
                this.RightStack.Push(right);
            }
        }

        /// <summary>
        /// Determines if an integer is odd.
        /// </summary>
        /// <param name="x">The value to evalute.</param>
        /// <returns>True if <paramref="x"> is odd, otherwise false.</returns>
        public bool IsOdd(int x) {
            return x % 2 != 0;
        }

        /// <summary>
        /// Sums up the values of the right stack.
        /// </summary>
        /// <returns>The sum of all values in the right stack.</returns>
        public int SumRight(){
            int sum = 0;
            foreach(int x in this.RightStack) {
                sum += x;
            }
            return sum;
        }
    }
}