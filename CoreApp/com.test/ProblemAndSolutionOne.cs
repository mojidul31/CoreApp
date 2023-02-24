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

		// Find the Height of Stack X to the Power N.
		public static int getBaseToThePower(int baseNo, int powerNo)
        {
			if (baseNo == 0)
            {
				return 0;
			}				
			if (powerNo == 0)
            {
				return 1;
			}
			int bPx = getBaseToThePower(baseNo, powerNo-1);
			return baseNo * bPx;
        }

		//Reverse Words in a String

		public static string ReverseWords(string s)
		{
			s = s.Trim();
			string s1 = string.Empty;
			string s2 = string.Empty;
			for (int i = s.Length - 1; i >= 0; i--)
			{
				if (Char.IsLetter(s[i]) || Char.IsNumber(s[i]))
                {
					s1 += s[i];
					if(i == 0)
                    {
						for (int j = s1.Length - 1; j >= 0; j--)
						{
							s2 += s1[j];
						}
					}
                }
                else
                {
                    if (!string.IsNullOrEmpty(s1))
                    {
						for (int j = s1.Length - 1; j >= 0; j--)
						{
							s2 += s1[j];
						}
						s2 += ' ';
						s1 = string.Empty;
					}					
				}
            }
			return s2;
		}

		public static int[] getArrayIndex(int[] intArr, int targetNo)
        {
			int firstNo, secondNo = 0;
			int tempSum = 0;
			int[] result = null;
			for (int i = 0; i < intArr.Length; i++)
			{
				firstNo = intArr[i];
				for (int j = i+1; j < intArr.Length; j++)
				{
					secondNo = intArr[j];
					tempSum = firstNo + secondNo;
					if (tempSum == targetNo)
                    {
						result = new int[2];
						result[0] = i;
						result[1] = j;
					}
				}
			}
			return result;
		}

		public static string Append(string firstName, string lastName)
		{
			return firstName +' '+ lastName;
		}

		public static void AppendPrint(string firstName, string lastName)
		{
			string fullName = firstName + lastName;
			Console.WriteLine($"{fullName}");
		}

        //Highest salary Using Method Syntax in LINQ
        public static double Nthhighestsalary(int NthNumber_Salary)
        {
            DataInfo obj = new DataInfo();
			var empList = obj.GetEmployeeRecord();
			var ee = empList.OrderByDescending(x=>x.salary).Select(x=>x.salary).Distinct().Take(NthNumber_Salary)
				.Skip(NthNumber_Salary-1).FirstOrDefault();
            Console.WriteLine("3rd Highest Salary is: " + ee);
			return ee;
        }

        


    }

    

}
