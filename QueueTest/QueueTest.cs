using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueueTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void TestPeekMethod()
        {

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(11);
            queue.Enqueue(21);
            queue.Enqueue(31);
            queue.Enqueue(41);

            Assert.AreEqual(11, queue.Peek());
        }

        [TestMethod]
        public void TestContainsMethod()
        {

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(11);
            queue.Enqueue(21);
            queue.Enqueue(31);
            queue.Enqueue(41);

            Assert.IsTrue(queue.Contains(31));
        }

        [TestMethod]
        public void TestToArrayMethod()
        {

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(11);
            queue.Enqueue(21);
            queue.Enqueue(31);
            queue.Enqueue(41);

            var table = queue.ToArray();
            queue.Dequeue();
            Assert.AreEqual(11, table[0]);
            Assert.AreEqual(3, queue.Count);
        }

        [TestMethod]
        public void TestClearMethod()
        {

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(11);
            queue.Enqueue(21);
            queue.Enqueue(31);
            queue.Enqueue(41);

            queue.Clear();

            Assert.AreEqual(0, queue.Count);
        }
    }
}
