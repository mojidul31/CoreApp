using System.Text;

namespace CoreApp.com.test
{
    public class ProblemAndSolutionOne
    {
        internal static int AppendWithDollar(string s)
        {
            char[] chars1 = s.ToCharArray();
            char[] newChars = new char[26];
            int res = 0;
            int j = 0;
            for(int i= 0; i < chars1.Length; i++)
            {
                if (i == 0)
                {
                    newChars[i] = chars1[i];
                    j++;
                    res++;
                }
                if (i > 0)
                {
                    if (!newChars.Contains(chars1[i]))
                    {
                        newChars[j] = chars1[i];
                        res++;
                        j++;
                    }
                }
            }
            return res;
        }

        internal static string CommonSubstring(string s1, string s2)
        {

            char[] chars1 = s1.ToCharArray();
            char[] chars2 = s2.ToCharArray();
            foreach (char c in chars1)
            {
                if (chars2.Contains(c))
                    return "YES";                    
            }
            return "NO";
        }
        public static string RearrageablePalindrom(string str)
		{
            int[] IntArr = new int[26];
            for (int i = 0; i < 26; i++)
            {
                IntArr[i] = 0;
            }
            //IntArr.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            for (int i = 0; i < str.Length; i++)
            {
                IntArr[str[i] - 'a']++;
            }
            //IntArr.ToList().ForEach(i => Console.WriteLine("S"+i.ToString()));
            int sum = 0;
            for (int i = 0; i < 26; i++)
            {
                sum = sum + (IntArr[i] % 2);
            }

            if (sum >= 2)
                return "NO";
            else
                return "YES";
        }
        public static bool checkPalindrome(string str)
        {

            int n = str.Length;

            // Counting number of characters 
            // that should be changed.
            int count = 0;

            for (int i = 0; i < n / 2; ++i)

                if (str[i] != str[n - i - 1])
                    ++count;

            // If count of changes is less than
            // or equal to 1
            return (count <= 1);
        }
        public static bool getPalindromStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
        public static string MakeAnagram(string s)
        {
            int len = s.Length;
            int div = len / 2;
            string s1 = s.Substring(0, div);
            int last = len - div;
            string s2 = s.Substring(div, last);
            char[] s1Array = s1.ToCharArray();
            char[] s2Array = s2.ToCharArray();
			List<char> list = new List<char>();

            Array.Sort(s1Array);
            Array.Sort(s2Array);

            int i = 0, j = 0;

            // Compare characters in sorted arrays
            while (i < s1Array.Length && j < s2Array.Length)
            {
                if (s1Array[i] == s2Array[j])
                {
                    list.Add(s1Array[i]);
                    i++;
                    j++;
					
                }
                else if (s1Array[i] < s2Array[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
			return new string(list.ToArray());
        }

        //Example.
        /// <summary>
        /// The only characters that match are the string so we have to remove  from  and  from  for a total of  deletions.
        /// </summary>
        /// <param name="s">abc, mbd</param>
        /// <returns>4</returns>
        public static int makingAnagrams(string s1, string s2)
		{
			int delCount = 0;
			int i=0, j = 0;

            char[] s1Array = s1.ToCharArray();
            char[] s2Array = s2.ToCharArray();
            Array.Sort(s1Array);
            Array.Sort(s2Array);
			Console.WriteLine(new string(s1Array));
			Console.WriteLine(new string(s2Array));

            while (i < s1Array.Length && j < s2Array.Length)
            {
                if (s1Array[i] == s2Array[j])
                {
                    i++;
                    j++;
                }
                else if (s1Array[i] < s2Array[j])
                {
                    i++;
                    delCount++;
                }
                else
                {
                    j++;
                    delCount++;
                }
            }
            delCount += (s1Array.Length - i) + (s2Array.Length - j);            
			return delCount;
        }


        //An anagram of a string is another string that contains the same characters,
		//only the order of characters can be different. 
        public static int GetMinimumChangeNoToMakeAnagram(string s)
		{
			int count = s.Length;
			if (count % 2 == 0)
			{
                int len = s.Length;
                int div = len / 2;
                string s1 = s.Substring(0, div);
                int last = len - div;
                string s2 = s.Substring(div, last);
				return CountManipulations(s1,s2);
            }
			else
			{
				return -1;
			}
		}
		public static int CountManipulations(string s1, string s2)
        {
            // Convert strings to character arrays and sort them
            char[] s1Array = s1.ToCharArray();
            char[] s2Array = s2.ToCharArray();

            Array.Sort(s1Array);
            Array.Sort(s2Array);

            int i = 0, j = 0, count = 0;

            // Compare characters in sorted arrays
            while (i < s1Array.Length && j < s2Array.Length)
            {
                if (s1Array[i] == s2Array[j])
                {
                    i++;
                    j++;
                }
                else if (s1Array[i] < s2Array[j])
                {
                    i++;
                    count++;
                }
                else
                {
                    j++;
                    count++;
                }
            }

            // Count the remaining characters in both arrays
            count += (s1Array.Length - i) + (s2Array.Length - j);
            return count / 2;
        }

        //A palindromic number is a number (such as 16461) that remains the same when its digits are reversed.
        //palindrom index test

        public static int PalindromeIndex(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end && s[start] == s[end])
            {
                start++;
                end--;
            }
            if (start >= end) return -1; // already a palindrome
            // We need to delete here
            if (IsPalindrome(s, start + 1, end)) return start;
            if (IsPalindrome(s, start, end - 1)) return end;
            return -1;
        }
        public static bool IsPalindrome(string s, int start, int end)
        {
            while (start < end && s[start] == s[end])
            {
                start++;
                end--;
            }
            return start >= end;
        }
        //How to reverse a string

        public static string ReverseString(string s)
		{
			return Reverse(s);
		}
		private static string Reverse(string s)
		{
			char[] chars = s.ToCharArray();
			Array.Reverse(chars);
			return new string(chars);
		}

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

        //How to remove duplicate from an int array
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

		//TuplePattern
		public static string NewTuplePattern(string name, string id, string department)
		//{
			//if(name == "Mojidul")
			//{
			//	if(id == "101" && department == "CSE")
			//	{
			//		return "Md. Mojidul Islam";
			//	}

			//}else if(name == "Nayeem")
			//{
		 //             if (id == "102" && department == "VII")
		//             {
		//                 return "Md. Nayeem Islam";
		//             }
		//         }
			//return "Invalid Name";
			
			//Another way
			=>(name, id, department) switch {
				  ("Mojidul","101","CSE") => "Md. Mojidul Islam",
                  ("Nayeem", "102", "VII") => "Md. Nayeem Islam",
                  (_,_,_) => "Invalid Name"
			  };

		//}

		//predicate delegate
		public static void PredicateDelegate()
		{
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Define the predicate delegate
            Predicate<int> isEven = x => x % 2 == 0;

            // Use the predicate delegate to filter the list
            List<int> evenNumbers = numbers.FindAll(isEven);

            // Output the even numbers
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static int SimpleArraySum(List<int> ar)
        {
			int sum = 0;
			if(ar.Any())
			{
                sum = ar.Sum();
				//foreach(int i in ar)
				//{
				//	sum += i;
				//}
			}
			return sum;
        }

        
    }

    

}
