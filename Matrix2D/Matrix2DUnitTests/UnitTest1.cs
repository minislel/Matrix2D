using Matrix2DLib;
namespace Matrix2DUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1,2,3,4)]
        [DataRow(0,0,0,0)]
        [DataRow(1,0,0,1)]
        public void ConstructorTestsWithParameters(int a, int b, int c, int d)
        {
            var m1 = new Matrix2D(a, b, c, d);
        }
        [TestMethod]
        public void ConstructorTestsNoParameters()
        {
            var m1 = new Matrix2D();
        }
        [TestMethod]
        [DataRow(1, 0, 0, 1)]
        public void AreEqualWithIDTest(int a, int b, int c, int d)
        { 
            var m1 = new Matrix2D ( a, b, c, d );
            Assert.AreEqual(m1, Matrix2D.Id);
        }
        [TestMethod]
        [DataRow(0, 0, 0, 0)]
        public void AreEqualWithZeroTest(int a, int b, int c, int d)
        {
            var m1 = new Matrix2D(a, b, c, d);
            Assert.AreEqual(m1, Matrix2D.Zero);
        }
        [TestMethod]
        [DataRow(1, 2, 3, 4, "[[1, 2], [3, 4]]")]
        [DataRow(66, 43, 2, 0, "[[66, 43], [2, 0]]")]
        [DataRow(1, 0, 0, 1, "[[1, 0], [0, 1]]")]
        public void ToStringTest(int a, int b, int c, int d, string expectedString)
        {
            var m1 = new Matrix2D(a, b, c, d);
            Assert.AreEqual (expectedString, m1.ToString ());
        }
        [TestMethod]
        [DataRow("[[1, 0], [0, 1]]")]
        public void ToStringTestWithID(string expectedString)
        {
            Assert.AreEqual(expectedString, Matrix2D.Id.ToString());
        }
        [TestMethod]
        [DataRow("[[0, 0], [0, 0]]")]
        public void ToStringTestWithZero(string expectedString)
        {
            Assert.AreEqual(expectedString, Matrix2D.Zero.ToString());
        }

    }
}