using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MyProject;
using NUnit.Framework;

namespace Tests
{
    class TotalDimensionsTests
    {
        [TestFixture]
        public class SetUpTotalDimensionsTests
        {
            private Mock<IStock> mockStock;
            public Dictionary<string, Cuboid> items = new Dictionary<string, Cuboid>();
            public int[] newDimensions;
            public int numberOfItems;


            [SetUp]
            public void SetUp()
            {
                items = new Dictionary<string, Cuboid>()
                                            {
                                                {"item1", new Cuboid(44, 10, 15) },
                                                {"item2", new Cuboid(43, 10, 14) },
                                                {"item3", new Cuboid(42, 10, 13) },

                                            };
                numberOfItems = 3;


            }

            



            [TearDown]
            public void TearDown()
            {

            }

            [Test]
            public void GetTotalDimensionsNeeded_ReturnsTheSmallestVolume_WhenCalled()
            {
                #region Arrange
                TotalDimensions totalDimensions = new TotalDimensions(items);
                int[] expected = new int[] { 44, 30, 15};
                #endregion

                #region Act
                newDimensions = totalDimensions.GetTotalDimensionsNeeded(numberOfItems);
                #endregion

                #region Assert
                Assert.AreEqual(expected, newDimensions);
                #endregion
            }

            //Claire : test here that no matter what is passed in the smallest volume is always produced
            //do random ways of getting the dimensions, label as 'smallestway' 'largestway' and then check actual way is the smallest way

        }
    }
}

