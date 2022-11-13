using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.com.test
{
    public class ProblemAndSolutionOne
    {
		//How to remove unwanted space from a string
		public static string RemoveSpaceFromStr(string str)
		{
			StringBuilder sb = new StringBuilder();
			str = str.Trim();
			for (int i = 0; i < str.Length; i++)
			{
				if (Char.IsWhiteSpace(str[i]))
				{
					if (!Char.IsWhiteSpace(str[i - 1]))
					{
						sb.Append(str[i]);
					}
				}
				else
				{
					sb.Append(str[i]);
				}
			}
			return sb.ToString();
		}

		//How to remove unwanted space from a string
		public static int RemoveDuplicates(int[] nums)
		{
			return nums.Distinct().Count();
		}

		public static int RemoveDuplicates2(int[] nums)
		{
			int uniqueIndex = 1;
			
			//return nums.Distinct().ToArray();
			for (int i = 1; i < nums.Length; i++)
            {
				// We skip to next index if we see a duplicate element
				if (nums[i-1] != nums[i])
                {
					/* Storing the unique element at uniqueIndex index and incrementing the uniqueIndex by 1 */
					nums[uniqueIndex] = nums[i];
					uniqueIndex++;
				}
			}
			Console.WriteLine("New arr "+String.Join(",", nums));			
			return uniqueIndex;
		}

		//How to combine two arrays without duplicate values in C#?
		public static string[] combineTwoArrays(string[] arr1, string[] arr2)
        {
			return arr1.Union(arr2).ToArray();
		}

		//How to get second max value from an int array

		public static int getSecondMaxValue(int[] arr)
        {
			int maxNo = 0;
			int secondMaxNo = 0;
			//for(int i = 0; i < arr.Length; i++)
			// {
			//	if(arr[i] > maxNo)
			// {
			//		secondMaxNo = maxNo;
			//		maxNo = arr[i];
			//	}
			//	else if (arr[i] > secondMaxNo)
			//	{
			//		secondMaxNo = arr[i];
			//	}
			//}
			foreach(int i in arr)
            {
				if (i > maxNo)
				{
					secondMaxNo = maxNo;
					maxNo = i;
				}
				else if (i > secondMaxNo)
				{
					secondMaxNo = i;
				}
			}
			return secondMaxNo;
        }

		// How to get reverse order strig
		public static string getReverseOrderString(string str)
        {
			StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(str))
            {
				for(int i = str.Length-1; i >= 0; i--)
                {
					sb.Append(str[i]);

				}
				return sb.ToString();
            }
			return string.Empty;
        }
		

	}
}
