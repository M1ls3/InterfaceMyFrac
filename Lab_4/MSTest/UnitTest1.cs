using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyFracAdd()
        {
            MyFrac a = new MyFrac(1, 3);
            MyFrac b = new MyFrac(1, 6);
            string expected = a.Add(b).ToString();
            int bools = string.Compare(expected, "1/2");
            Assert.AreEqual(0, bools);
        }
        [TestMethod]
        public void MyFracSubtract()
        {
            MyFrac a = new MyFrac(1, 3);
            MyFrac b = new MyFrac(1, 6);
            string expected = a.Subtract(b).ToString();
            int bools = string.Compare(expected, "1/6");
            Assert.AreEqual(0, bools);
        }
        [TestMethod]
        public void MyFracMultiply()
        {
            MyFrac a = new MyFrac(1, 3);
            MyFrac b = new MyFrac(1, 6);
            string expected = a.Multiply(b).ToString();
            int bools = string.Compare(expected, "1/18");
            Assert.AreEqual(0, bools);
        }
        [TestMethod]
        public void MyFracDivide()
        {
            MyFrac a = new MyFrac(1, 3);
            MyFrac b = new MyFrac(1, 6);
            string expected = a.Divide(b).ToString();
            int bools = string.Compare(expected, "2/1");
            Assert.AreEqual(0, bools);
        }
        [TestMethod]
        public void MyComplexAdd()
        {
            MyComplex a = new MyComplex(1, 3);
            MyComplex b = new MyComplex(1, 6);
            string expected = a.Add(b).ToString();
            int bools = string.Compare(expected, "2+9i");
            Assert.AreEqual(0, bools);
        }
        [TestMethod]
        public void MyComplexSubtract()
        {
            MyComplex a = new MyComplex(1, 3);
            MyComplex b = new MyComplex(1, 6);
            string expected = a.Subtract(b).ToString();
            int bools = string.Compare(expected, "0-3i");
            Assert.AreEqual(0, bools);
        }
        [TestMethod]
        public void MyComplexMultiply()
        {
            MyComplex a = new MyComplex(1, 3);
            MyComplex b = new MyComplex(1, 6);
            string expected = a.Multiply(b).ToString();
            int bools = string.Compare(expected, "-17+9i");
            Assert.AreEqual(0, bools);
        }
        [TestMethod] 
        public void MyComplexDivide()
        {
            MyComplex a = new MyComplex(1, 3);
            MyComplex b = new MyComplex(1, 6);
            string expected = a.Divide(b).ToString();
            int bools = string.Compare(expected, "0+0i");
            Assert.AreEqual(0, bools);
        }
    }
}
