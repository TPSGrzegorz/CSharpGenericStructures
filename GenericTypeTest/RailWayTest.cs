using System; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Railway;

namespace GenericTypeTest
{
    [TestClass]
    public class RailWayTest
    {
        [TestMethod]
        public void NewRailWayIsEmpty()
        {
            var railWay = new WheelRailway<double>();

            Assert.IsTrue(railWay.IsEmpty);
        }
        [TestMethod]
        public void IsThreeElementsRailwayFull()
        {
            var railWay = new WheelRailway<double>(capacity: 3);

            railWay.Write(3.6);
            railWay.Write(2.4);
            railWay.Write(1);


            Assert.IsTrue(railWay.IsFull);
        }

        [TestMethod]
        public void FirstInFirstOut()
        {
            var railWay = new WheelRailway<string>(capacity: 3);

            var value1 = "3.6";
            var value2 = "2.4";

            railWay.Write(value1);
            railWay.Write(value2);

            Assert.AreEqual(value1, railWay.Read());
            Assert.AreEqual(value2, railWay.Read());

            Assert.IsTrue(railWay.IsEmpty);
        }
        [TestMethod]
        public void OverrideIfFull()
        {
            var railWay = new WheelRailway<double>(capacity: 3);

            var value1 = new[] { 1.2, 2.4, 3.6, 4.8, 5.3, 6.8 };

            foreach (var item in value1)
            {
                railWay.Write(item);
            }

            Assert.IsTrue(railWay.IsFull);
            Assert.IsFalse(railWay.IsEmpty);

            Assert.AreEqual(value1[3], railWay.Read());
            Assert.AreEqual(value1[4], railWay.Read());
            Assert.AreEqual(value1[5], railWay.Read());

            Assert.IsTrue(railWay.IsEmpty);
        }
        [TestMethod]
        public void CapacityTest()
        {
            var railWay = new WheelRailway<int>(capacity: 3);

            var value1 = 1;
            var value2 = 2;

            railWay.Write(value1);

            Assert.AreEqual(4, railWay.Capacity);
            railWay.Write(value2);

            Assert.AreEqual(4, railWay.Capacity);

            Assert.IsTrue(!railWay.IsEmpty);
        }

    }
}
