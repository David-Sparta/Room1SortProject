using SortProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProjectTests
{
    internal class RandomGeneratorTests
    {
        [TestCase(3)]
        [TestCase(1)]
        [TestCase(0)]
        public void GivenLength_GetRandomArray_CreatesAnArrayOfSpecifiedLength(int length)
        {
            Assert.That(() => RandomGenerator.GetRandomArray(length).Length == length);
        }

        [Test]
        public void GivenInvalidLength_GetRandomArray_ThrowsOverflowException()
        {
            Assert.That(() => RandomGenerator.GetRandomArray(-1), Throws.TypeOf<OverflowException>());
        }
    }
}
