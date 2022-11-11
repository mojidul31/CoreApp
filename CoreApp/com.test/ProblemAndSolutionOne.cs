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
			int currentNum = nums[0];
			List<int> result = new List<int>();
			result.Add(currentNum);
			bool isFound = false;
			
			//return nums.Distinct().ToArray();
			for (int i = 1; i < nums.Length; i++)
            {
				if(currentNum == nums[i] && !isFound)
                {
					isFound = true;
                }
                else if(currentNum != nums[i])
				{
					result.Add(nums[i]);					
					currentNum = nums[i];
					isFound = false;
                }
            }
            int[] res = new int[result.Count];
			res = result.ToArray();
			//show new array
			//Console.WriteLine(String.Join(",", res));
			//show count
			//Console.WriteLine("ssd " + res.Length);
			return res.Length;
		}

		//How to combine two arrays without duplicate values in C#?
		public static string[] combineTwoArrays(string[] arr1, string[] arr2)
        {
			return arr1.Union(arr2).ToArray();
		}
		

	}
}
