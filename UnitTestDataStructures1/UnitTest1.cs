using System;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestDataStructures1
{
    [TestClass]//test the Hash class
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 3, 4, 2, 3, 16, 3, 15, 16, 15, 15, 16, 2, 3, 3, 15 };
            int a = 0, b = 0, c = 0;
            Hash.FindTopThreeRepeatedInArray(arr, ref a, ref b, ref c);
            Assert.IsTrue(a == 3 && b == 15 && c == 16, "The fun find the top three repeated in the array");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { 3, 4, 2, 3, 16, 3, 15, 16, 15, 15, 16, 2, 3 };
            int[] arr1 = { 3, 4, 3, 16, 3, 15, 16, 15, 15, 4, 16, 2, 3 };
            Assert.IsFalse(Hash.CheckIfTwoArraysAreEqualOrNot(arr, arr1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = { 3, 4, 2, 3, 16, 3, 15, 16, 15, 15, 16, 2, 3 };
            Assert.IsTrue(Hash.CheckIfTwoArraysAreEqualOrNot(arr, arr));
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] arr2 = { 1, 1, 1 };
            List<int[]> l = Hash.CountOfIndexPairsWithEqualElementsInInArray(arr2);
            string failmessage = "One or more pair is missed";
            int counter = 3;
            foreach (var item in l)
            {
                if (item[0] == 0 && item[1] == 1) counter--;
                else
                if (item[0] == 0 && item[1] == 2) counter--;
                else
                if (item[0] == 1 && item[1] == 2) counter--; else Assert.Fail(failmessage);

            }
            Assert.AreEqual(0, counter, "There are more pairs then the expected");
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] arr = { 1, 1, 9, 9, 9 };
            List<int[]> l = Hash.CountOfIndexPairsWithEqualElementsInInArray(arr);
            string failmessage = "One or more pair is missed";
            int counter = 4;
            foreach (var item in l)
            {
                if (item[0] == 0 && item[1] == 1) counter--;
                else
                if (item[0] == 2 && item[1] == 3) counter--;
                else
                if (item[0] == 2 && item[1] == 4) counter--;
                else
                if (item[0] == 3 && item[1] == 4) counter--;
                else Assert.Fail(failmessage);

            }
            Assert.AreEqual(0, counter, "There are more pairs then the expected");
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5 };
            List<int[]> l = Hash.CountOfIndexPairsWithEqualElementsInInArray(arr);
            Assert.AreEqual(0, l.Count);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(Hash.Sumf_ai_ajPairsArrayNIntegers(new int[] { 6, 6, 4, 4 }), -8);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(Hash.Sumf_ai_ajPairsArrayNIntegers(new int[] { 1, 2, 3, 1, 3 }), 4);
        }
    }
}
