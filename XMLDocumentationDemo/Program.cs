// See https://aka.ms/new-console-template for more information

using MyNamespace;

var myMaths = new MyMaths();

Console.WriteLine(myMaths.Subtract(1, 2).ToString());

namespace MyNamespace
{
    public class MyMaths
    {

        /// <summary>
        /// Subtracts one number from another.
        /// </summary>
        /// <param name="a">The number to subtract from.</param>
        /// <param name="b">The number to subtract.</param>
        /// <returns>The difference between the two numbers.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when b is greater than a.</exception>
        public int Subtract(int a, int b)
        {
            if (b > a)
                throw new ArgumentOutOfRangeException("b", "b cannot be greater than a.");

            return a - b;
        }
    }
}

