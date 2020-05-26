using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueueTest
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void IntersectWithSet()
        {

            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }
        [TestMethod]
        public void UnionWithSet()
        {

            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3 , 4}));
        }

        [TestMethod]
        public void SymmetricExceptWithSet()
        {

            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);
            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }

        [TestMethod]
        public void RemoveSets()
        {

            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.Remove(2);

            Assert.AreEqual(2, set1.Count);
            
        }

        [TestMethod]
        public void RemoveWhereSets()
        {

            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.RemoveWhere( x => x > 1); //Predicate

            Assert.AreEqual(1, set1.Count);

        }

        [TestMethod]
        public void ContainsSets()
        {

            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };


            Assert.IsTrue(set1.Contains(3));

        }
    }
}
