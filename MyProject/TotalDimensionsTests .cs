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
        


            }

            



            [TearDown]
            public void TearDown()
            {

            }

            [Test]
            public void ChangeThiSLaterrrrr()
            {
                #region Arrange
                
                int[] expected = new int[] { 44, 10, 42};

                items = new Dictionary<string, Cuboid>()
                                            {
                                                {"item1", new Cuboid(44, 10, 15) },
                                                {"item2", new Cuboid(43, 10, 14) },
                                                {"item3", new Cuboid(42, 10, 13) },

                                            };
                int numberOfItem = 3;
                TotalDimensions totalDimensions = new TotalDimensions(items);
                #endregion

                #region Act
                newDimensions = totalDimensions.GetTotalDimensionsNeeded(numberOfItem);
                #endregion

                #region Assert
                Assert.AreEqual(expected, newDimensions);
                #endregion
            }




            [Test]
            public void SmallestBoxIsAlwaysChosen() {
                #region Arrange
                
                int numberOfItem = 3;
                int[] expected = new int[] { 33, 22, 27 };
                items = new Dictionary<string, Cuboid>()
                                            {
                                                {"item1", new Cuboid(33, 22, 12) },
                                                {"item2", new Cuboid(32, 21, 14) },
                                                {"item3", new Cuboid(4, 2, 1) }
                                            };
                TotalDimensions totalDimensions = new TotalDimensions(items);
                #endregion

                #region Act
                newDimensions = totalDimensions.GetTotalDimensionsNeeded(numberOfItem);
                #endregion

                #region Assert
                Assert.AreEqual(expected, newDimensions);
                #endregion
            }
        }
    }
}

