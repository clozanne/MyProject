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
    public class RotateTests
    {
        [TestFixture]
        public class SetUpTotalDimensionsTests
        {

            [SetUp]
            public void SetUp()
            {

                int[] newDimensions = new int[] { 1, 10, 100 };
                Rotate rotate = new Rotate(newDimensions);


            }





            [TearDown]
            public void TearDown()
            {

            }

            [Test]
            public void Rotate_ShouldReturnAnObject_OfTypeCuboid()
            {

                #region Arrange
                int[] newDimensions = new int[] { 1, 10, 100 };
                Rotate rotate = new Rotate(newDimensions);
                #endregion

                #region Act
                var cuboid = rotate.RotateCuboid(newDimensions);
                #endregion

                #region Assert
                Assert.That(cuboid, Is.TypeOf<Cuboid>());
                #endregion
            }

            [Test]
            public void DimensionsOfReturnedCuboid_ShouldBeInDescendingOrder_WhenRotated() {
                #region Arrange
                int[] newDimensions = new int[] { 1, 10, 100 };
                Rotate rotate = new Rotate(newDimensions);
                int[] expected = newDimensions.OrderBy((a) => a).ToArray();
                int expextedLength;
                expextedLength = expected[2];
                #endregion

                #region Act
                int actualLength;
                var cuboid = rotate.RotateCuboid(newDimensions);
                actualLength = cuboid.Length;
                #endregion

                #region Assert
                Assert.AreEqual(actualLength, expextedLength);
                #endregion
            }
        }
    }
}
