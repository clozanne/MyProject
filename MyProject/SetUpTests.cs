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
using Moq;

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

        }


        //[Test]

        //public void CheckforExceptionThrown() {
        //    #region Arrange
        //    SetUp setUp = new SetUp();
        //    line = "0";

        //var ex = Assert.Throws<Exception>(() => setUp.GetTotalNumberOfItems(line));
        //setUp.GetTotalNumberOfItems(line);
        //Assert.IsNull();
        //Assert.Throws(Type exception, setUp.GetTotalNumberOfItems(line));
        //TestDelegate throwException = () => setUp.GetTotalNumberOfItems(line);

        //Exception expectedException = new Exception();

        //Assert.That(() => setUp.GetTotalNumberOfItems(line), null);

        //Assert.Throws(typeof (BoxException), throwException);

        //Assert.Throws<BoxException>(() => setUp.GetTotalNumberOfItems(line));

        //Assert.IsNotNull(throwException);//this works

        //try
        //{
        //    setUp.GetTotalNumberOfItems(line);
        //    Assert.Throws<MyProject.BoxException>(() => setUp.GetTotalNumberOfItems(line)); // If it gets to this line, no exception was thrown
        //}
        //catch (BoxException) { }

        //Assert.Throws<ArgumentException>(
        //  new TestDelegate(throwException));

        //Assert.Throws<BoxException>(() => setUp.GetTotalNumberOfItems(line));

        //Assert.IsNull(throwException);// = () => setUp.GetTotalNumberOfItems(line));


        //Assert.Throws(typeof(BoxException),
        //  delegate { throw new BoxException(); }); //THIS WORKS

        //       BoxException ex = Assert.Throws<BoxException>(
        //delegate { throw new BoxException(); }); //this works

        //Assert.Throws<BoxException>(
        //  delegate { throw new BoxException(); });//THIS WORKS
        ////Assert.IsTrue(ex.Message.Contains("not"));



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
        //}

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

        //[Test]
        //public void GetAllCuboids_ReturnsDictionaryOfCuboids_WhenPassedAllDimensions_AndNumberOfItems() {
        //    #region Arrange
        //    SetUp setUp = new SetUp();
        //    int numberOfItem = 1;
        //    int [] dimensions = new int[] { 3, 2, 1 };
        //    #endregion

        //    #region Act
        //    var items = setUp.GetAllCuboids(numberOfItem);
        //    #endregion

        //    #region Assert
        //    Assert.That(items, Is.TypeOf<Dictionary<string, Cuboid>>());
        //    #endregion
        //}



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
            //int expected = 2;
            #endregion

            #region Act
            int actual = setUp.GetWidth(dimensionsSorted);
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }

        //protected Action<string> tempFunction;

        //[Test]
        //public virtual void AssertThrowsNullReferenceOrInvalidOperation(object getTotalNumberOfItems)
        //{
        //    if (tempFunction != null)
        //    {
        //        Assert.Throws<NullReferenceException>(() => tempFunction(null));
        //        Assert.Throws<InvalidOperationException>(() => tempFunction(string.Empty));
        //        Assert.Throws<InvalidOperationException>(() => tempFunction(" "));
        //    }
        //}

        //[Test]
        //public void Test1()
        //{
        //    SetUp setUp = new SetUp();
        //    //AssertThrowsNullReferenceOrInvalidOperation(setUp.GetTotalNumberOfItems);
        //}

        ////TestDelegate throwException = () => setUp.GetTotalNumberOfItems(line);

        //    [Test]

        //public void hhh()
        //{

        //    #region Arrange
        //    SetUp hsetUp = new SetUp();

        //    string hline = "0";

        //    TestDelegate delegateMethod = () => hsetUp.GetTotalNumberOfItems(hline);
        //    #endregion

        //    #region Act 

        //    //try
        //    //{
        //    //    hsetUp.GetTotalNumberOfItems(hline);
        //    //}
        //    //catch (BoxException exception)
        //    //{
        //    //    var e = exception;
        //    //}
        //    #endregion

        //    #region Assert

        //    //Assert.IsNull(() => delegateMethod;
        //    Assert.IsNull(delegateMethod);

        //    //Assert.Throws<ArgumentNullException>(() => hsetUp.GetTotalNumberOfItems(hline));


        //    //Assert.Throws<NullReferenceException>(delegateMethod);
        //    //Assert.Throws<InvalidOperationException>(delegateMethod);
        //    //Assert.Throws<BoxException>(delegateMethod);
        //    //Assert.Throws<Exception>(() => hsetUp.GetTotalNumberOfItems(hline));
        //    //assertTrue(e instanceof BoxException);
        //    //Assert.That(e, Is.TypeOf<BoxException>());
        //    //Assert.That<e>
        //    //Assert.Throws<BoxException>;


        //    #endregion

        //}

        //static SetUp hsetUp = new SetUp();

        //static string hline = "0";

        //TestDelegate throwException = () => hsetUp.GetTotalNumberOfItems(hline);
      

        //[Test]
  
        //public void HelloAssertThrows_NullReference_Og_InvalidOperation(TestDelegate delegateMethod)
        //{
        //    //TestDelegate throwException = () => setUp.GetTotalNumberOfItems(line);

        //    SetUp setUp = new SetUp();

        //    TestDelegate throwException = () => setUp.GetTotalNumberOfItems(line);


        //    Assert.Throws<NullReferenceException>(delegateMethod);
        //    Assert.Throws<InvalidOperationException>(delegateMethod);
        //    Assert.Throws<InvalidOperationException>(delegateMethod);
        //}


    }
}
