using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueueTest
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void TestAddAfter()
        {

            var list = new LinkedList<string>();

            list.AddFirst("Grzegorz");
            list.AddLast("Tomek");
            list.AddAfter(list.First, "Marek");

            Assert.AreEqual("Marek", list.First.Next.Value);
        }

        [TestMethod]
        public void TestAddBefore()
        {

            var list = new LinkedList<string>();

            list.AddFirst("Grzegorz");
            list.AddLast("Tomek");
            list.AddBefore(list.First, "Marek");

            Assert.AreEqual("Marek", list.First.Value);
        }

        [TestMethod]
        public void TestRemoveLastElement()
        {

            var list = new LinkedList<string>();

            list.AddFirst("Grzegorz");
            list.AddLast("Tomek");
            list.RemoveLast();

            Assert.AreEqual(list.Last.Value, list.First.Value);
        }


        [TestMethod]
        public void TestRemove()
        {

            var list = new LinkedList<string>();

            list.AddFirst("Grzegorz");
            list.AddLast("Tomek");
            list.Remove("Grzegorz");

            Assert.AreEqual(list.First.Value, "Tomek");
        }

        [TestMethod]
        public void TestIfListIncludeElement()
        {

            var list = new LinkedList<string>();

            list.AddFirst("Grzegorz");
            list.AddLast("Tomek");

            Assert.IsTrue(list.Contains("Grzegorz"));
        }


        [TestMethod]
        public void TestClearingList()
        {

            var list = new LinkedList<string>();

            list.AddFirst("Grzegorz");
            list.AddLast("Tomek");
            list.Clear();
            Assert.AreEqual(0,list.Count);
        }
    }
}
