using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MyProject;
using NUnit.Framework;
using Newtonsoft.Json;
using System.Globalization;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Reflection;


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
            public void ChooseBox_DoesntReturnsObject_WhenDimensionsTooLarge()
            {
                #region Arrange
                Cuboid totalDimensionsNecessary = new Cuboid(65, 50, 46);
                string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);
                Cuboid box1 = MyProject.ChooseBox.GetBox(1, currentDirectory);
                Cuboid box2 = MyProject.ChooseBox.GetBox(2, currentDirectory);
                Cuboid box3 = MyProject.ChooseBox.GetBox(3, currentDirectory);
                #endregion

                #region Act
                var box4 = chooseBox.GetBox();
                #endregion

                #region Assert
                Assert.IsNull(box4);

                #endregion
            }



            [Test]
            public void GetBox_ReturnsTheCorrect_ObjectType()
            {
                #region Arrange 
                Cuboid totalDimensionsNecessary = new Cuboid(3, 2, 1);
                string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                Cuboid box1 = new Cuboid(0, 0, 0);
                #endregion

                #region Act
                Cuboid box = MyProject.ChooseBox.GetBox(1, currentDirectory);
                #endregion

                #region Assert
                Assert.That(box, Is.TypeOf<Cuboid>());
                #endregion

            }

            [Test]
            public void GetBox_ReturnsObject_ThatCanBeUsedToCheckStock_WhenCalled()
            {
                #region
                Cuboid totalDimensionsNecessary = new Cuboid(3, 2, 1);
                //Cuboid box1 = new Cuboid(35, 25, 20);
                //Cuboid box2 = new Cuboid(45, 35, 16);
                //Cuboid box3 = new Cuboid(61, 46, 45);
                ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);
                string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                Cuboid box1 = MyProject.ChooseBox.GetBox(1, currentDirectory);
                Cuboid box2 = MyProject.ChooseBox.GetBox(2, currentDirectory);
                Cuboid box3 = MyProject.ChooseBox.GetBox(3, currentDirectory);
                #endregion

                #region
                var box = chooseBox.GetBox();
                #endregion

                #region
                Assert.That(box, Is.TypeOf<Cuboid>());
                #endregion

            }
        }
    }
}
