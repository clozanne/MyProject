using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MyProject;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SetUpTests
    {
        private Mock<IStock> mockStock;

        private string line;

        [SetUp]
        public void SetUp()
        {

            mockStock = new Mock<IStock>();

        }

        [TearDown]
        public void TearDown()
        {
            mockStock = null;
        }

        [Test]

        public void CheckforExceptionThrown_WithUserInput()
        {
            #region Arrange
            SetUp setUp = new SetUp();
            line = "0";
            #endregion

            #region Act
            setUp.GetTotalNumberOfItems(line);
            #endregion

            #region Assert
            Assert.Throws(typeof(BoxException),
            delegate { throw new BoxException(); });
            #endregion

        }


        [Test]
        public void TestException_InGetTotalNumberOfItems() {
            #region Arrange
            SetUp setUp = new SetUp();

            string line = "-1";
            Exception expectedException = null;

            #endregion

            #region Act
            TestDelegate throwException = () => setUp.GetTotalNumberOfItems(line);

            #endregion

            #region Assert
            Assert.IsNull(expectedException);
            #endregion
        }



        [Test]
        public void ReturnSorted_Sorts_InAscendingOrder() {

            #region Arrange
            SetUp setUp = new SetUp();
            int[] dimensions = new int[]{3, 2, 1};
            int[] expectedDimensions = new int[] {1, 2, 3};
            #endregion

            #region Act
            int[] actualDimensions = setUp.ReturnSorted(dimensions);
            #endregion

            #region Assert
            Assert.AreEqual(actualDimensions, expectedDimensions);
            #endregion
        }





        [Test]
        public void GetLength_GetsLongestDimensions_InTheArray_WhenCalled() {

            #region Arrange
            SetUp setUp = new SetUp();
            int[] dimensionsSorted = new int[] {1, 2, 3 };
            int expected = dimensionsSorted.Max();
            #endregion

            #region Act
            int actual = setUp.GetLength(dimensionsSorted);
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }

        [Test]
        public void GetHeight_GetsShortestDimensions_InTheArray_WhenCalled()
        {

            #region Arrange
            SetUp setUp = new SetUp();
            int[] dimensionsSorted = new int[] { 1, 2, 3 };
            int expected = dimensionsSorted.Min();
            #endregion

            #region Act
            int actual = setUp.GetHeight(dimensionsSorted);
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }

        [Test]
        public void GetWidth_GetsCentraDimension_InTheArray_WhenCalled()
        {

            #region Arrange
            SetUp setUp = new SetUp();
            int[] dimensionsSorted = new int[] { 1, 2, 3 };
            int expected = dimensionsSorted.ElementAt(1);

            #endregion

            #region Act
            int actual = setUp.GetWidth(dimensionsSorted);
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }




    }
}
