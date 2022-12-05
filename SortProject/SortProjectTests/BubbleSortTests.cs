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
            Assert.That(() => _bubble.Sort(array), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]

        public void GivenArray_Sort_ReturnArraySize()
        {
            int[] num = { 2, 4, 6, 8, 10, 12 };
            Assert.That(_bubble.Sort(num).Length, Is.EqualTo(6));
        }
    }
}
