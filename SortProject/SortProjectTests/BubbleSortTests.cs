using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortProject;

namespace SortProjectTests
{
    public class BubbleSortTests
    {
        private BubbleSort _bubble;

        [OneTimeSetUp]
        public void SetUp()
        {
            _bubble = new BubbleSort();
        }

        [Test]

        public void GivenANullArray_Sort_ThrowsAnException()
        {
            int[] array = null;
            Assert.That(() => _bubble.Sort(array), Throws.TypeOf<NullReferenceException>());
        }

        [Test]

        public void GivenArray_Sort_ReturnArraySize()
        {
            int[] num = { 2, 4, 6, 8, 10, 12 };
            Assert.That(_bubble.Sort(num).Length, Is.EqualTo(6));
        }

        [Test]

        public void GivenArray_Sort_ReturnSortedArray()
        {
            int[] num = { 4, 6, 2, 12, 3, 5 };
            int[] expected = { 2, 3, 4, 5, 6, 12 };
            Assert.That(_bubble.Sort(num), Is.EqualTo(expected));
        }
    }
}
