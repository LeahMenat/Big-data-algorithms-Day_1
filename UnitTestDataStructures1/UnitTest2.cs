using System;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestDataStructures1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Edge[] edges = { new Edge(0, 1), new Edge(0, 2), new Edge(3, 4) };
            Assert.AreEqual(Graph.CountNumberOfTreesInAForest(edges), 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Edge[] edges1 = { new Edge(0, 1), new Edge(0, 2), new Edge(3, 4), new Edge(2, 3) };
            Assert.AreEqual(Graph.CountNumberOfTreesInAForest(edges1), 1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Edge[] edges2 = { new Edge(0, 1), new Edge(0, 2), new Edge(3, 4), new Edge(5, 6) };
            Assert.AreEqual(Graph.CountNumberOfTreesInAForest(edges2), 3);
        }
        private static bool AreEqualsLists(List<int> l1, List<int> l2)
        {
            int i = 0;
            int[] arr2 = l2.ToArray();
            foreach (int item in l1)
            {
                if (item != arr2[i++])
                    return false;
            }
            return true;
        }
        private static string Print(List<int> l)
        {
            string str = "";
            foreach (var item in l)
            {
                str += item + ", ";
            }
            return str;
        }

        [TestMethod]
        public void TestMethod4()
        { 
            List<int>l= Graph.SteppingNumber(0, 100);
            List<int> listTocopare = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 21,23,32,34,43,45,54,56,65,67,76,78,87,89,98,100 };
            if (l.Count != listTocopare.Count) Assert.Fail("expected to list length: " + listTocopare.Count+", and get: "+l.Count);
            Assert.IsTrue(AreEqualsLists(listTocopare, l), "@expect: {0},actual: {1}", Print(listTocopare), Print(l));
        }
        [TestMethod]
        public void TestMethod5()
        {
            List<int> l=Graph.SteppingNumber(0, 21);
            List<int> listTocopare = new List<int>() { 1, 2,3,4,5,6,7,8,9,10,12,21 };
            if (l.Count != listTocopare.Count) Assert.Fail("expected to list length: " + listTocopare.Count);
            Assert.IsTrue(AreEqualsLists(listTocopare, l), "@expect: {0},actual: {1}", Print(listTocopare), Print(l));
        }
        [TestMethod]
        public void TestMethod6()
        {
            List<int>l= Graph.SteppingNumber(10, 15);
            List<int> listTocopare = new List<int>() { 10, 12 };
            if (l.Count != listTocopare.Count) Assert.Fail("expected to list length: "+listTocopare.Count);
            Assert.IsTrue(AreEqualsLists(listTocopare, l),"@expect: {0},actual: {1}",Print(listTocopare),Print(l));
        }
    }
}
