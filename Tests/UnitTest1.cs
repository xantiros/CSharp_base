using CSharp_base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ID499Tests()
        {
            Assert.AreEqual(4, Excercises.ID499_Tests(2, 2));
            Assert.AreEqual(1, Excercises.ID499_Tests(1289312391, 0));
            Assert.AreEqual(1, Excercises.ID499_Tests(1, 2321323123));
            Assert.AreEqual(2, Excercises.ID499_Tests(2, 324324345));
            Assert.AreEqual(1, Excercises.ID499_Tests(3, 435435436));
            Assert.AreEqual(4, Excercises.ID499_Tests(4, 9080237));
            Assert.AreEqual(5, Excercises.ID499_Tests(5, 2163062));
            Assert.AreEqual(6, Excercises.ID499_Tests(6, 96123412));
            Assert.AreEqual(7, Excercises.ID499_Tests(7, 921638125));
            Assert.AreEqual(2, Excercises.ID499_Tests(8, 2128963591));
            Assert.AreEqual(9, Excercises.ID499_Tests(9, 21538123));
            Assert.AreEqual(0, Excercises.ID499_Tests(0, 182931253));

            Assert.AreEqual(1, Excercises.ID499_Tests(0, 0));
            Assert.AreEqual(1, Excercises.ID499_Tests(3, 0));
            Assert.AreEqual(0, Excercises.ID499_Tests(0, 5));
            Assert.AreEqual(0, Excercises.ID499_Tests(10, 1));
            Assert.AreEqual(1, Excercises.ID499_Tests(1, 44));
            Assert.AreEqual(6, Excercises.ID499_Tests(2, 12));
            Assert.AreEqual(3, Excercises.ID499_Tests(3, 5));
            Assert.AreEqual(9, Excercises.ID499_Tests(99999999, 3));
            Assert.AreEqual(1, Excercises.ID499_Tests(11111111, 99999999));
            Assert.AreEqual(1, Excercises.ID499_Tests(22222, 0));

        }
    }
}
