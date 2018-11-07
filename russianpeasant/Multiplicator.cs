using System;
namespace russianpeasant
{
    /// <summary>
    /// Class that executes the russian peasant multiplication.
    /// </summary>
    public class Multiplicator
    {
        /// <summary>
        /// Multiplies <paramref="x"> with <paramref="y"> using the russian peasant method.
        /// </summary>
        /// <param name="x">First multiplier.</param>
        /// <param name="y">Second multiplier.</param>
        /// <returns></returns>
        public int Mul(int x, int y) {
            return this.Mul(x, y, new Multiplier());
        }

        private int Mul(int x, int y, Multiplier engine){
            Accumulator accumulator = new Accumulator();
            int left = x;
            int right = y;
            accumulator.Accumulate(left, right);
            while(left > 1) {
                (left, right) = engine.ExecuteRow(left, right);
                accumulator.Accumulate(left, right);
            }
            int result = accumulator.SumRight();
            return result;
        }

    }
}
