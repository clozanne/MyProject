﻿using System;
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
        //private SetUp setUp;
        //private int numberOfItem;
        //private string line;

        [SetUp]
        public void SetUp()
        {
            //assign arbitrary values to variables

            mockStock = new Mock<IStock>();
           //SetUp setUp = new SetUp();
           // string line = "1";




        }

        [TearDown]
        public void TearDown()
        {
            mockStock = null;
        }



        

        [Test]
        public void ChangeThisTitleLater() {
            #region Arrange
            SetUp setUp = new SetUp();
            string line = "0";

            var ex = Assert.Throws<Exception>(() => setUp.GetTotalNumberOfItems(line));

            Assert.IsTrue(ex.Message.Contains("not"));



            ////var ex = Assert.Throws<BoxException>();
            //#endregion

            //#region Act
            ////setUp.GetTotalNumberOfItems();
            //#endregion

            //#region Assert
            //Assert.That(() => setUp.GetTotalNumberOfItems(), Throws.Exception);
            ////Assert.Fail();
            ////Assert.Throws<BoxException>();
            #endregion
        }

        [Test]
        public void TestException() {
            #region Arrange
            SetUp setUp = new SetUp() ;
            //numberOfItem = 0;
            string line = "-1";
            Exception expectedException = null;

            #endregion

            #region Act
            TestDelegate throwException = () => setUp.GetTotalNumberOfItems(line);
            //setUp.GetTotalNumberOfItems(line);
            //Exception actualException = setUp.GetTotalNumberOfItems(line);
            ////void CallThrowException()
            ////{
            ////    setUp.GetTotalNumberOfItems();
            ////}
            //Action GTNOI = () => setUp.GetTotalNumberOfItems(line);
            #endregion

            #region Assert
            //Assert.Throws(typeof(BoxException), throwException);
            //Assert.Throws(typeof(), throwException);
            //Assert.Throws(typeof(Exception), CallThrowException);
            //Assert.Throws<ArgumentException>(setUp.GetTotalNumberOfItems);
            Assert.IsNull(expectedException);
            //Assert.AreEqual(expectedException, throwException);
            //Assert.Throws<FormatException>(() => setUp.GetTotalNumberOfItems(line));
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
        public void GetAllCuboids_ReturnsDictionaryOfCuboids_WhenPassedAllDimensions_AndNumberOfItems() {
            #region Arrange
            SetUp setUp = new SetUp();
            int numberOfItem = 1;
            int [] dimensions = new int[] { 3, 2, 1 };
            #endregion

            #region Act
            var items = setUp.GetAllCuboids(numberOfItem);
            #endregion

            #region Assert
            Assert.That(items, Is.TypeOf<Dictionary<string, Cuboid>>());
            #endregion
        }

        [Test]
        public void GetLength_GetsLongestDimensions_InTheArray_WhenCalled() {

            #region Arrange
            SetUp setUp = new SetUp();
            int[] dimensionsSorted = new int[] {1, 2, 3 };
            #endregion

            #region Act
            int actual = setUp.GetLength(dimensionsSorted);
            int expected = dimensionsSorted.Max();
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
            #endregion

            #region Act
            int actual = setUp.GetHeight(dimensionsSorted);
            int expected = dimensionsSorted.Min();
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
            #endregion

            #region Act
            int actual = setUp.GetWidth(dimensionsSorted);
            int expected = 2;
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        
        [Test]
        public void GetInput_ReturnsArrayofInts_whenCalled()
        {
            //#region Arrange
            //SetUp setUp = new SetUp();
            //string dimensionsString = "0";
            //TestDelegate hello = setUp.GetInput();
            //WORK OUT HOW TO USE TEST DELEGATES
            //#endregion

            //#region Act
            //setUp.GetInput();
            //#endregion

            //#region Assert
            //Assert.Throws<BoxException>(setUp.GetInput());
            //#endregion
        }


        #region Arrange
        #endregion

        #region Act
        #endregion

        #region Assert
        #endregion

    }
}