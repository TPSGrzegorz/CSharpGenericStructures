using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueueTest
{
    [TestClass]
    public class Stack
    {
        [TestMethod]
        public void TestPeekMethod()
        {

            Stack<int> stack= new Stack<int>();

            stack.Push(11);
            stack.Push(21);
            stack.Push(31);
            stack.Push(41);

            Assert.AreEqual(41, stack.Peek());
        }

        [TestMethod]
        public void TestContainsMethod()
        {

            Stack<int> stack= new Stack<int>();

            stack.Push(11);
            stack.Push(21);
            stack.Push(31);
            stack.Push(41);

            Assert.IsTrue(stack.Contains(31));
        }

        [TestMethod]
        public void TestToArrayMethod()
        {

            Stack<int> stack= new Stack<int>();

            stack.Push(11);
            stack.Push(21);
            stack.Push(31);
            stack.Push(41);

            var table = stack.ToArray();
            stack.Pop();
            Assert.AreEqual(41, table[0]);
            Assert.AreEqual(3, stack.Count);
        }

        [TestMethod]
        public void TestClearMethod()
        {

            Stack<int> stack= new Stack<int>();

            stack.Push(11);
            stack.Push(21);
            stack.Push(31);
            stack.Push(41);

            stack.Clear();

            Assert.AreEqual(0, stack.Count);
        }
    }
}
