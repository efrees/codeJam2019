using System;
using System.Text;
using System.Numerics;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        var t = int.Parse(Console.ReadLine());

        var k = 1;
        while (k <= t)
        {
            var lineOne = Console.ReadLine().Split(' ');
            var n = int.Parse(lineOne[0]);
            var l = int.Parse(lineOne[1]);

            // a*b b*c c*d d*e
            var ciphertext = Console.ReadLine().Split(' ')
                .Select(t => BigInteger.Parse(t))
                .ToArray();

            // find some one of the primes
            // use this to find the other factorizations
            // list and sort all the primes
            // trace through the factorizations to convert to letters

            var answerBuilder = new StringBuilder();

            Console.WriteLine($"Case #{k}: {answerBuilder}");
            k++;
        }
    }

    private static BigInteger Sqrt(BigInteger n)
    {
        var mask = BigInteger.One << 300; // need better approximation
        var root = BigInteger.Zero;
        var remainder = n;

        while(mask > 0)
        {
            var rootPlusMask = root + mask;
            if (rootPlusMask <= remainder)
            {
                remainder -= rootPlusMask;
                root += mask << 1;
            }
            root >>= 1;
            mask >>= 2;
        }
    }
}
