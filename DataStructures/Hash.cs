using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class Hash
    {
        public static Dictionary<int, int> fillInCountingDictionary(int[] arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (int p in arr)
            {
                if (d.ContainsKey(p))
                    d[p]++;
                else
                    d.Add(p, 1);
            }
            return d;
        }

        public static void FindTopThreeRepeatedInArray(int[] arr, ref int a1, ref int b1, ref int c1)
        {
            KeyValuePair<int, int> a, b, c;
            a = new KeyValuePair<int, int>(int.MinValue, int.MinValue);
            b = new KeyValuePair<int, int>(int.MinValue, int.MinValue);
            c = new KeyValuePair<int, int>(int.MinValue, int.MinValue);
            Dictionary<int, int> d = fillInCountingDictionary(arr);
            foreach (var p in d.Keys)
            {
                if (d.ContainsKey(p) && d[p] > a.Value)
                {
                    c = b;
                    b = a;
                    a = new KeyValuePair<int, int>(p, d[p]);
                }

                else if (d.ContainsKey(p) && d[p] > b.Value)
                {
                    c = b;
                    b = new KeyValuePair<int, int>(p, d[p]);
                }
                else if (d.ContainsKey(p) && d[p] > c.Value)
                {
                    c = new KeyValuePair<int, int>(p, d[p]);
                }
            }
            Console.WriteLine(" a: " + a.Key + " " + a.Value + " b: " + b.Key + " " + b.Value + " c: " + c.Key + " " + c.Value);
            a1 = a.Key;
            b1 = b.Key;
            c1 = c.Key;
        }


        public static bool CheckIfTwoArraysAreEqualOrNot(int[] a, int[] b)
        {
            Dictionary<int, int> aDict = fillInCountingDictionary(a);
            foreach (var item in b)
            {
                if (aDict.ContainsKey(item))
                    aDict[item]--;
                else
                    return false;
            }
            foreach (var item in aDict)
            {
                if (item.Value != 0)
                    return false;
            }
            return true;
        }

        public static Dictionary<int, List<int>> fillInListIndexesDictionary(int[] arr)
        {
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!d.ContainsKey(arr[i]))
                    d.Add(arr[i], new List<int>());
                d[arr[i]].Add(i);
            }
            return d;
        }

        public static void printAllEqualIndexes(List<int> l, ref List<int[]> indexPairsWithEqualElements)
        {
            int[] arr = l.ToArray();//to increace the complicity
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    indexPairsWithEqualElements.Add(new int[]{ arr[i], arr[j] });
                    Console.WriteLine(@"( {0}, {1} )", arr[i], arr[j]);
                }
            }
        }
        public static List<int[]> CountOfIndexPairsWithEqualElementsInInArray(int[] arr)
        {
            Dictionary<int, List<int>> d = fillInListIndexesDictionary(arr);
            List<int[]> l = new List<int[]>();
            foreach (var item in d)
            {
                if (item.Value.Count > 1)
                    printAllEqualIndexes(item.Value, ref l);
            }
            return l;
        }

        public static int Sumf_ai_ajPairsArrayNIntegers(int[] arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int ans = 0;
            int preSum = 0;//סכום עד לשלב זה
            for (int i = 0; i < arr.Length; i++)
            {
                ans += arr[i] * i - preSum;
                preSum += arr[i];

                if (d.ContainsKey(arr[i] - 1))
                    ans -= d[arr[i] - 1];

                if (d.ContainsKey(arr[i] + 1))
                    ans += d[arr[i] + 1];

                if (d.ContainsKey(arr[i]))
                    d[arr[i]]++;
                else
                    d[arr[i]]=1;
            }
            return ans;
        }
    }
}
