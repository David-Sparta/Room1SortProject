using SortProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProjectTests
{
    public class MergeSortTests
    {
        private MergeSort _merge;

        [OneTimeSetUp]

        public void SetUp()
        {
            _merge = new MergeSort();
        }

        [Test]

        public void GivenANullArray_Sort_ThrowsAnException()
        {
            int[] array = null;
            Assert.That(() => _merge.Sort(array), Throws.TypeOf<NullReferenceException>());
        }

        [Test]

        public void GivenArray_Sort_ReturnArraySize()
        {
            int[] num = { 2, 4, 6, 8, 10, 12 };
            Assert.That(_merge.Sort(num).Length, Is.EqualTo(6));
        }

        [Test]

        public void GivenArray_Sort_ReturnSortedArray()
        {
            int[] num = { 4, 6, 2, 12, 3, 5 };
            int[] expected = { 2, 3, 4, 5, 6, 12 };
            Assert.That(_merge.Sort(num), Is.EqualTo(expected));
        }

        [Test]
        public void Given2Arrays_Merge_ReturnCorrectSize()
        {
            int[] left = { 1, 3, 5 };
            int[] right = { 7, 9, 12 };

            var size = _merge.SortMulti(left, right).Length;
            int expectedSize = 6;

            Assert.That(size, Is.EqualTo(expectedSize));
        }

        [Test]
        public void Given2ArraysOfSize2_Merge_ReturnCorrectArray()
        {
            int[] left = { 10, 3 };
            int[] right = { 7, 12 };

            var result = _merge.SortMulti(left, right);
            int[] expected = { 7, 10, 3, 12 };

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
