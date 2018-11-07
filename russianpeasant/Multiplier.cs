namespace russianpeasant
{
    /// <summary>
    /// The <see cref="Multiplier"> class executes the russian peasant multiplication for a single row.
    /// </summary>
    public class Multiplier
    {
        /// <summary>
        /// Multiplies <paramref="x"> by 2.
        /// </summary>
        /// <param name="x">The value to multiply.</param>
        /// <returns><paramref="x"> multiplied by 2.</returns>
        public int MultiplyBy2(int x) {
            return x * 2;
        }

        /// <summary>
        /// Divides <paramref="x"> by 2.
        /// </summary>
        /// <param name="x">The value to divide.</param>
        /// <returns><paramref="x"> divided by 2 and rounded.</returns>
        public int DivideBy2(int x) {
            return x/2;
        }

        /// <summary>
        /// Executes a sigle row operation of the russian peasant multiplication.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns><paramref="left"> divided by 2, and <paramref="right"> multiplied by 2.</returns>
        public (int, int) ExecuteRow(int left, int right) {
            int newLeft = this.DivideBy2(left);
            int newRight = this.MultiplyBy2(right);

            return (newLeft, newRight);
        }



    }
}