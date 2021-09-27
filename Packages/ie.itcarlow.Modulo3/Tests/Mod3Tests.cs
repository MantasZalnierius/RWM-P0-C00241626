using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class Mod3Tests
    {
        [Test]
        public void mod3FilterSample()
        {
            int[] input = { 7, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = Modulo3.mod3(input);
            int[] expected = { 1, 2, 2, 0, 0, 1, 1, 2, 2, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

