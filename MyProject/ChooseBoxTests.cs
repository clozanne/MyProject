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
    public class ChooseBoxTests
    {
        [TestFixture]
        public class SetUpTotalDimensionsTests
        {

            [SetUp]
            public void SetUp()
            {

            }

            [TearDown]
            public void TearDown()
            {

            }

            [Test]
            public void ChooseBox_ReturnsObject_ThatCanBeUsedToCheckStock_WhenCalled()
            {
                #region Arrange
                Cuboid totalDimensionsNecessary = new Cuboid(3, 2, 1);
                ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);
                #endregion

                #region Act
                var box = chooseBox.SelectBox();
                #endregion

                #region Assert
                Assert.That(box, Is.TypeOf<Box1>());
                #endregion
            }


            [Test]
            public void ChooseBox_ReturnsObject_ThatCanBeUsedToCheckStock_WhenCalled_Medium()
            {
                #region Arrange
                Cuboid totalDimensionsNecessary = new Cuboid(44, 34, 15);
                ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);
                #endregion

                #region Act
                var box2 = chooseBox.SelectBox();
                #endregion

                #region Assert
                Assert.That(box2, Is.TypeOf<Box2>());
                #endregion

            }


            [Test]
            public void ChooseBox_ReturnsObject_ThatCanBeUsedToCheckStock_WhenCalled_large()
            {
                #region Arrange
                Cuboid totalDimensionsNecessary = new Cuboid(60, 45, 44);
                ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);
                #endregion

                #region Act
                var box3 = chooseBox.SelectBox();
                #endregion

                #region Assert
                Assert.That(box3, Is.TypeOf<Box3>());
               
                #endregion

            }

            [Test]
            public void ChooseBox_DoesntReturnsObject_WhenDimensionsTooLarge()
            {
                #region Arrange
                Cuboid totalDimensionsNecessary = new Cuboid(65, 50, 46);
                ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);
                #endregion

                #region Act
                var box4 = chooseBox.SelectBox();
                #endregion

                #region Assert
                Assert.IsNull(box4);

                #endregion
            }

            [Test]
            public void ChooseSmallestBox_ChangeThisLater(/*[Range ((0), (2), (1))] Cuboid totalDimensionsNecessary*/)
            {
                #region Arrange
                Cuboid totalDimensionsNecessary = new Cuboid(3, 2, 1);
                ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);
                #endregion

                #region Act
                var box = chooseBox.SelectBox();
                #endregion

                #region Assert
                Assert.That(box, Is.TypeOf<Box1>());
                #endregion

            }
        }
    }
}
