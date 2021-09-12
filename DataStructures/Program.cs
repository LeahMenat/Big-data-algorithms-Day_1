using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	public class Program
	{
// C# program to calculate
// the sum of f(a[i], aj])


		// Function to calculate the sum
		public static int sum(int[] a, int n)
		{
			// Map to keep a count of occurrences
			IDictionary<int, int> cnt = new Dictionary<int, int>();

			// Traverse in the list from start to end
			// number of times a[i] can be in a pair and
			// to get the difference we subtract pre_sum
			int ans = 0, pre_sum = 0;
			for (int i = 0; i < n; i++)
			{
				ans += (i * a[i]) - pre_sum;
				pre_sum += a[i];

				// If the (a[i]-1) is present then subtract
				// that value as f(a[i], a[i]-1) = 0
				if (cnt.ContainsKey(a[i] - 1))
				{
					ans -= cnt[a[i] - 1];
				}

				// If the (a[i]+1) is present then
				// add that value as f(a[i], a[i]-1)=0
				// here we add as a[i]-(a[i]-1)<0 which would
				// have been added as negative sum, so we add
				// to remove this pair from the sum value
				if (cnt.ContainsKey(a[i] + 1))
				{
					ans += cnt[a[i] + 1];
				}

				// keeping a counter for every element
				if (cnt.ContainsKey(a[i]))
				{
					cnt[a[i]] = cnt[a[i]] + 1;
				}
				else
				{
					cnt[a[i]] = 1;
				}
			}
			return ans;
		}

		// Driver code
		public static void Main(string[] args)
		{
			int[] a = new int[] { 1, 2, 3, 1, 3 };
			int n = a.Length;
			Console.WriteLine(sum(a, n));
			Console.ReadLine();
		}
	}

	// This code is contributed by Shrikant13


}
