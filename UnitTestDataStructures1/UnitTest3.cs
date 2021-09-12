using System;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDataStructures1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {

            BinaryTree<int> root = new BinaryTree<int>(4,
                new BinaryTree<int>(3,
                    new BinaryTree<int>(2, null, null),
                    new BinaryTree<int>(2, null, null)),
                new BinaryTree<int>(3,
                    new BinaryTree<int>(2, null, null),
                    new BinaryTree<int>(2, null, null)));
            Assert.IsTrue(root.CheckIfAllLeavesAreAtSameLevel());

        }

        [TestMethod]
        public void TestMethod2()
        {
            BinaryTree<int> root = new BinaryTree<int>(4,
              new BinaryTree<int>(3,
                  new BinaryTree<int>(2, null, null),
                  null),
              new BinaryTree<int>(3,
                  new BinaryTree<int>(2, null, null),
                  new BinaryTree<int>(2, null, null)));
            Assert.IsTrue(root.CheckIfAllLeavesAreAtSameLevel());

        }

        [TestMethod]
        public void TestMethod3()
        {
            BinaryTree<int> root = new BinaryTree<int>(4,
                 new BinaryTree<int>(3,
                     new BinaryTree<int>(2, null, null),
                     null),
                 new BinaryTree<int>(3,
                     new BinaryTree<int>(2,
                         new BinaryTree<int>(1, null, null),
                         new BinaryTree<int>(1, null, null)),
                     new BinaryTree<int>(2, null, null)));
            Assert.IsFalse(root.CheckIfAllLeavesAreAtSameLevel());
        }

        [TestMethod]
        public void TestMethod4()
        {
            BinaryTree<int> root = new BinaryTree<int>(3,
              new BinaryTree<int>(2,
                  new BinaryTree<int>(1, null, null),
                  null),
              new BinaryTree<int>(5,
                  new BinaryTree<int>(4, null, null),
                  new BinaryTree<int>(6, null, null)));
            int ans = -1;
            root.FindN_thNodeOfInorderTraversal(3, ref ans);
            Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void TestMethod5()
        {
            BinaryTree<int> root = new BinaryTree<int>(3,
              new BinaryTree<int>(2,
                  new BinaryTree<int>(1, null, null),
                  null),
              new BinaryTree<int>(5,
                  new BinaryTree<int>(4, null, null),
                  new BinaryTree<int>(6, null, null)));
            int ans = -1; 
            root.FindN_thNodeOfInorderTraversal(-1, ref ans);
            Assert.AreEqual(ans, -1);
        }
    }
}
