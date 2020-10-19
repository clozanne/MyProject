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
    public class StockCheckerTests
    {
        [TestFixture]
        public class SetUpTotalDimensionsTests
        {
            private Mock<IStock> mockStock;
            private StockChecker stockChecker;

            [SetUp]
            public void SetUp()
            {

            }

            [TearDown]
            public void TearDown()
            {

            }


            [Test]
            public void StockChecker_CallsUponInterface_AndReturnsAUsableAnswer_ForIfBoxIsInStock() {
                #region Arrange
                mockStock = new Mock<IStock>();
                stockChecker = new StockChecker();
                Cuboid neededBox = new Cuboid(5, 4, 3);
                mockStock.Setup(r => r.CheckIfBoxIsInStock(neededBox));
                #endregion

                #region Act
                var actual = stockChecker.CheckIfBoxIsInStock(neededBox);
                #endregion

                #region Assert
                Assert.That(actual, Is.TypeOf<bool>());
                #endregion
            }

            [Test]
            public void StockChecker_CallsUponInterface_AndReturnsResult_WhenCalledWith_ABoxSize()
            {
                #region Arrange
                mockStock = new Mock<IStock>();//this should technically go in the setup part
                stockChecker = new StockChecker();
                Cuboid neededBox = new Cuboid(35, 25, 20);

                mockStock.Setup(r => r.CheckIfBoxIsInStock(neededBox)).Returns(false);
                #endregion

                #region Act
                var actual = stockChecker.CheckIfBoxIsInStock(neededBox);
                #endregion

                #region Assert
                Assert.AreEqual(false, actual);
                #endregion
            }
        }
    }
}
