using Matrix2DLib;
namespace Matrix2DUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1, 2, 3, 4)]
        [DataRow(0, 0, 0, 0)]
        [DataRow(1, 0, 0, 1)]
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
            var m1 = new Matrix2D(a, b, c, d);
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
            Assert.AreEqual(expectedString, m1.ToString());
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
        [TestMethod]
        [DataRow(1, 2, 3, 4, 1, 2, 3, 4)]
        [DataRow(66, 43, 2, 0, 66, 43, 2, 0)]
        [DataRow(1, 0, 0, 1, 1, 0, 0, 1)]
        public void EqualsTestTrue(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var m2 = new Matrix2D(e, f, g, h);
            Assert.IsTrue(m1.Equals(m2));
        }
        [TestMethod]
        [DataRow(1, 2, 3, 4, 1, 2, 6, 4)]
        [DataRow(66, 43, 2, 0, 66, 44, 2, 0)]
        [DataRow(1, 0, 0, 1, 1, 0, 3, 1)]
        public void EqualsTestFalse(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var m2 = new Matrix2D(e, f, g, h);
            Assert.IsFalse(m1.Equals(m2));
        }
        [TestMethod]
        [DataRow(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8)]
        [DataRow(0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1)]
        [DataRow(50, 50, 50, 50, 20, 20, 20, 20, 70, 70, 70, 70)]
        public void AdditionTest(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var m2 = new Matrix2D(e, f, g, h);
            var m3 = m1 + m2;
            var expected = new Matrix2D(i, j, k, l);
            Assert.AreEqual(expected, m3);
        }
        [TestMethod]
        [DataRow(2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1)]
        [DataRow(73, 43, 5, -2, 20, 20, 20, 20, 53, 23, -15, -22)]
        public void SubtractionTest(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var m2 = new Matrix2D(e, f, g, h);
            var m3 = m1 - m2;
            var expected = new Matrix2D(i, j, k, l);
            Assert.AreEqual(expected, m3);
        }
        [TestMethod]
        [DataRow(1, 2, 3, 4, 5, 6, 7, 8, 19, 22, 43, 50)]
        [DataRow(5, 6, 7, 8, 1, 2, 3, 4, 23, 34, 31, 46)]
        public void MultiplicationTest(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var m2 = new Matrix2D(e, f, g, h);
            var m3 = m1 * m2;
            var expected = new Matrix2D(i, j, k, l);
            Assert.AreEqual(expected, m3);
        }
        [TestMethod]
        [DataRow(1, 1, 1, 1, 2, 2, 2, 2, 2)]
        [DataRow(2, 4, 6, 8, 20, 40, 60, 80, 10)]
        public void MultiplicationTest(int a, int b, int c, int d, int e, int f, int g, int h, int i)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var m3 = m1 * i;
            var expected = new Matrix2D(e, f, g, h);
            Assert.AreEqual(expected, m3);
        }
        [TestMethod]
        [DataRow(1, 1, 1, 1, 2, 2, 2, 2, 2)]
        [DataRow(2, 4, 6, 8, 20, 40, 60, 80, 10)]
        public void MultiplicationTestInverted(int a, int b, int c, int d, int e, int f, int g, int h, int i)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var m3 = i * m1;
            var expected = new Matrix2D(e, f, g, h);
            Assert.AreEqual(expected, m3);
        }
        [TestMethod]
        [DataRow(1, 2, 4, 6, -1, -2, -4, -6)]
        [DataRow(-1, -2, -3, -4, 1, 2, 3, 4)]
        public void InversionTest(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var expected = new Matrix2D(e, f, g, h);
            Assert.AreEqual(expected, -m1);
        }
        [TestMethod]
        [DataRow(1, 2, 3, 4, 1, 3, 2, 4)]
        [DataRow(-1, 7, 4, 3, -1, 4, 7, 3)]
        public void TranspositionTest(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var expected = new Matrix2D(e, f, g, h);
            Assert.AreEqual(expected, m1.Transpose());
        }
        [TestMethod]
        [DataRow(1, 2, 3, 4, -2)]
        [DataRow(100, 2, -78, 44, 4556)]
        public void DetTest(int a, int b, int c, int d, int e)
        {
            var m1 = new Matrix2D(a, b, c, d);
            Assert.AreEqual(m1.Det(), e);
        }
        [TestMethod]
        [DataRow(1, 2, 3, 4, -2)]
        [DataRow(100, 2, -78, 44, 4556)]
        public void DeterminantTest(int a, int b, int c, int d, int e)
        {
            var m1 = new Matrix2D(a, b, c, d);
            Assert.AreEqual(Matrix2D.Determinant(m1), e);
        }
        [TestMethod]
        [DataRow(1, 2, 3, 4)]
        [DataRow(0,0,0,0)]
        [DataRow(55,6,-212,0)]
        
        public void ExplicitConversionTest(int a, int b, int c, int d)
        {
            var m1 = new Matrix2D(a, b, c, d);
            var m2 = (int[,])m1;
            var expected = new int [,] { { a, b }, { c, d } };
            Assert.IsTrue(m2[0,0] == expected[0,0] && m2[0,1] == expected[0,1] && m2[1,0] == expected[1,0] && m2[1, 1] == expected[1, 1]);
        }












    }
}