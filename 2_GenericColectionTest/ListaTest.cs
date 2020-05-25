using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_GenericColectionTest
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void LlistWeCanAddatTheEnd()
        {
            List<int> listNumber = new List<int> { 1, 2, 3 };

            listNumber.Add(4);

            Assert.AreEqual(4, listNumber[3]);
        }

        [TestMethod]
        public void LlistWeCanAddatSpecificPosition()
        {
            List<int> listNumber = new List<int> { 1, 2, 3 };

            listNumber.Insert(1,8);

            Assert.AreEqual(8, listNumber[1]);
        }

        [TestMethod]
        public void LlistWeCanRemove()
        {
            List<int> listNumber = new List<int> { 1, 2, 3 };

            listNumber.Remove(2);

            Assert.IsTrue(listNumber.SequenceEqual(new[] { 1, 3 }));
        }

        [TestMethod]
        public void LlistWeCanRemoveAt()
        {
            List<int> listNumber = new List<int> { 1, 2, 3 };

            listNumber.RemoveAt(0);

            Assert.IsTrue(listNumber.SequenceEqual(new[] { 2, 3 }));
        }
        [TestMethod]
        public void ListFindIndex()
        {
            List<int> listNumber = new List<int> { 11, 22, 33 };

            Assert.AreEqual(listNumber.IndexOf(33),2);
        }
        [TestMethod]
        public void ListFindIfContain()
        {
            List<int> listNumber = new List<int> { 11, 22, 33 };

            Assert.IsTrue(listNumber.Contains(22));
        }
        [TestMethod]
        public void LlistWeCanAddRangeatTheEnd()
        {
            List<int> listNumber = new List<int> { 1, 2, 3 };

            List<int> addRange = new List<int> { 5, 6, 7 };
            listNumber.AddRange(addRange);

            Assert.IsTrue(listNumber.SequenceEqual(new[] { 1, 2, 3, 5, 6, 7 }));
        }
    }
}
