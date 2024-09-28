using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CoreApp.com.test
{
    public class ProblemAndSolutionOne
    {
        internal static int knapsackTest(List<Item> items, int capacity)
        {
            int[,] matrix = new int[items.Count+1, capacity+1];
            for (int itemIndex = 0; itemIndex <= items.Count; itemIndex++)
            {
                var currentItem = itemIndex == 0 ? null : items[itemIndex - 1];
                for (int currentCapacity = 0; currentCapacity <= capacity; currentCapacity++)
                {
                    if (currentItem == null || currentCapacity == 0)
                    {
                        matrix[itemIndex, currentCapacity] = 0;
                    }
                    else if (currentItem.Weight <= currentCapacity)
                    {
                        matrix[itemIndex, currentCapacity] = Math.Max(
                            currentItem.Value + matrix[itemIndex - 1, currentCapacity - currentItem.Weight],
                            matrix[itemIndex - 1, currentCapacity]);
                    }
                    else
                    {
                        matrix[itemIndex, currentCapacity] =
                            matrix[itemIndex - 1, currentCapacity];
                    }                    
                }
            }
            return matrix[items.Count, capacity];
        }
        public static List<Item> sample_item()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { Value = 60, Weight = 10 });
            items.Add(new Item { Value = 100, Weight = 20 });
            items.Add(new Item { Value = 120, Weight = 30 });
            return items;
        }
        internal static void bfs_traversal(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while(queue.Count > 0)
            {
                node = queue.Dequeue();
                Console.WriteLine(node.data+"");

                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        internal static void bfs_traversal_second(Node node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.data + "");
            bfs_traversal_second(node.left);
            bfs_traversal_second(node.right);
        }
        public static Node sample_tree(){
            Node root =
                new Node("A", new Node("B", new Node("C"), new Node("D")),
                new Node("E", new Node("F"), new Node("G", new Node("H"), null)));
            return root;
        }
        internal static int binarySearch(int[] a, int startIndex, int lastIndex, int val)
        {
            int mid = 0;
            if(lastIndex >= startIndex)
            {
                mid = (lastIndex + startIndex) / 2;
                if (a[mid] == val)
                {
                    return mid + 1;  /* if the item to be searched is present at middle */
                }
                /* if the item to be searched is smaller than middle, then it can only be in left subarray */
                else if (a[mid] < val)
                {
                    return binarySearch(a, mid + 1, lastIndex, val);
                }
                /* if the item to be searched is greater than middle, then it can only be in right subarray */
                else
                {
                    return binarySearch(a, startIndex, mid - 1, val);
                }
            }
            return -1;
        }
        internal static int[] ascOrderArr(int[] arr)
        {
           int tmpMax=0, n = arr.Length;
           for(int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if (arr[i] > arr[j])//if (arr[i] < arr[j]) //for descending order
                    {
                        tmpMax = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmpMax;
                    }
                }
            }
           return arr;
        }
        internal static string morganAndString(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0, j = 0;//Index into each string
            while (i < a.Length && j < b.Length)
            {
                switch (TieResult(a, b, i, j))
                {
                    case -1:
                    case 0:
                        var aa = a[i];
                        while (i < a.Length && aa == a[i])
                        {
                            sb.Append(aa);
                            i++;
                        }
                        break;
                    case 1:
                        var bb = b[j];
                        while (j < b.Length && bb == b[j])
                        {
                            sb.Append(bb);
                            j++;
                        }
                        break;
                }
            }

            sb.Append(a.Substring(i));
            sb.Append(b.Substring(j));
            /*
            while (i < a.Length && j < b.Length) {
                if (a[i] < b[j])
                {
                    sb.Append(a[i]);
                    i++;
                }
                else if (a[i] > b[j])
                {

                    sb.Append(b[j]);
                    j++;
                }
                else
                {
                    if (i < j)
                    {
                        sb.Append(a[i]);
                        i++;
                    }
                    else if (i > j)
                    {
                        sb.Append(b[j]);
                        j++;
                    }
                    else
                    {
                        //sb.Append(a[i]);
                        //i++;
                        sb.Append(b[j]);
                        j++;
                    }
                   }
                }
                //We reached the end of 1 string
                //Add rest of string 1
                while (i < a.Length)
                {
                    sb.Append(a[i]);
                    i++;
                }
                //Add rest of string 2
                while (j < b.Length)
                {
                    sb.Append(b[j]);
                    j++;
                }
                */

                return sb.ToString();
        }

        internal static int TieResult(string a, string b, int i, int j)
        {
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    return -1;
                if (a[i] > b[j])
                    return 1;
                i++;
                j++;
            }
            return i< a.Length ? -1 : 1;
        }
        internal static object steadyGene(string gene)
        {
            Dictionary<char,int> list = new Dictionary<char,int>();
            list.Add('A', 0); list.Add('C', 0); list.Add('G', 0); list.Add('T', 0);
            
            int n = gene.Length;
            int i = 0, j = n - 1;
            while (j >= i)
            {
                if (list[gene[j]] == n/4)
                {
                    j++;
                    break;
                }
                list[gene[j]]++;
                j--;
            }

            if (j < 0) return 0;

            int minLength = j;

            while (j < n)
            {
                list[gene[i]]++;
                while ((j < n) && (list[gene[i]] > n/4)) 
                {
                    list[gene[j]]--;
                    j++;
                }
                int len = j - i - 1;
                minLength = Math.Min(minLength, len);
                i++;
            }
            return minLength;
        }
        internal static int commonChild(string s1, string s2)
        {                  
            int[] memArr = new int[s2.Length + 1];
            for (int i = 1; i<=s1.Length; i++)
            {
                int prevNo = 0;
                for (int j = 1; j <= s2.Length; j++)
                {
                    int temp = memArr[j];
                    if (s1[i-1] == s2[j-1])
                    {
                        memArr[j] = prevNo + 1;
                    }
                    else
                    {
                        memArr[j] = Math.Max(memArr[j], memArr[j-1]);
                    }
                    prevNo = temp;
                }
            }
            return memArr[s2.Length];
    }
        internal static List<int> FindMatchingElements(int[,,,] array1, int[,,,] array2)
        {
            if (array1.Length < 1 && array2.Length < 1)
                return new List<int>();
            var list = new List<int>();
            //SortedSet maintains ascending order and does not store duplicate elements.
            //var l1 = new SortedSet<int>();
            //var l2 = new SortedSet<int>();
            var l1 = new HashSet<int>();
            var l2 = new HashSet<int>();
            foreach (var element in array1)
            {
                l1.Add(element);
            }

            foreach (var element in array2)
            {
                l2.Add(element);
            }

            foreach(var i in l1)
            {
                if (l2.Contains(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
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

        //int palindrome
        public static bool IsIntPalindrome(int x)
        {            
            int[] nums = x.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            int len = nums.Length;
            int[] res = new int[len];             
            foreach (int i in nums)
            {
                res[len - 1] = i;
                len--;
            }
            return nums.SequenceEqual(res);
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

        internal static string reverseStr(string revStr)
        {
            if(revStr == null)
                return string.Empty;
            int len = revStr.Length;
            /*
            StringBuilder sb = new StringBuilder();
            for(int i = len; i > 0; i--)
            {
                sb.Append(revStr[i-1]);
            }
            return sb.ToString();
            */
            //another way
            int j = len-1;
            var str = revStr.ToCharArray();
            for(int i = 0; i <= len; i++)
            {
                if (i > j)
                    break;
                char c = str[i];
                str[i] = str[j];
                str[j] = c;
                j--;
            }
            return new string(str);
        }

        internal static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for(int i=0; i< nums.Length; i++)
            {
                for(int j=i+1; j< nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }
            return result;
        }

        internal static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = null;
            ListNode curr = null;
            int carry = 0;

            l1 = ReverseList(l1);
            l2 = ReverseList(l2);

            // Iterate till either num1 is not empty or num2 is
            // not empty or carry is greater than 0
            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = carry;

                // If num1 linked list is not empty, add it to sum
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                // If num2 linked list is not empty, add it to sum
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                // Create a new node with sum % 10 as its value
                ListNode newNode = new ListNode(sum % 10);

                // Store the carry for the next nodes
                carry = sum / 10;

                // If this is the first node, then make this node
                // as the head of the resultant linked list
                if (res == null)
                {
                    res = newNode;
                    curr = newNode;
                }
                else
                {

                    // Append new node to resultant linked list
                    // and move to the next node
                    curr.next = newNode;
                    curr = curr.next;
                }
            }

            // Reverse the resultant linked list to get the
            // required linked list
            return res;
            //return ReverseList(res);
        }

        private static ListNode ReverseList(ListNode head)
        {

            // Initialize three pointers: curr, prev and next
            ListNode curr = head;
            ListNode prev = null;
            ListNode next;

            // Traverse all the nodes of Linked List
            while (curr != null)
            {

                // Store next
                next = curr.next;

                // Reverse current node's next pointer
                curr.next = prev;

                // Move pointers one position ahead
                prev = curr;
                curr = next;
            }

            // Return the head of reversed linked list
            return prev;
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            //null checking
            if (l1 == null && l2 == null) return null;  
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            // create a new list to store the merged list
            ListNode mergedList = new ListNode();
            /*
            ListNode cur = mergedList;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            cur.next = l1 == null ? l2 : l1;
            return mergedList.next;
            */

            
            if (l1.val > l2.val)
            { //comparing and merging
                mergedList = l2;
                l2 = l2.next;
            }
            else
            {
                mergedList = l1;
                l1 = l1.next;
            }

            mergedList.next = MergeTwoLists(l1, l2);
            return mergedList;            
        }

        public static int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNosDic = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                char currentRomanChar = s[i];
                romanNosDic.TryGetValue(currentRomanChar, out int num);
                //right roman char >left roman char => true else false
                //true = sum-left or false = sum + left
                if (i + 1 < s.Length && romanNosDic[s[i + 1]] > romanNosDic[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            return sum;
        }

        public static string IntToRoman(int num)
        {
            string romanResult = "";
            Dictionary<string, int> romanNumbersDictionary = new() {
            {
                "I",
                1
                }, {
                    "IV",
                    4
                }, {
                    "V",
                    5
                }, {
                    "IX",
                    9
                }, {
                    "X",
                    10
                }, {
                    "XL",
                    40
                }, {
                    "L",
                    50
                }, {
                    "XC",
                    90
                }, {
                    "C",
                    100
                }, {
                    "CD",
                    400
                }, {
                    "D",
                    500
                }, {
                    "CM",
                    900
                }, {
                    "M",
                    1000
                }
            };

            foreach (var item in romanNumbersDictionary.Reverse())
            {
                if (num <= 0) break;
                while (num >= item.Value)
                {
                    romanResult += item.Key;
                    num -= item.Value;
                }
            }
            return romanResult;
        }

        internal static string LongestCommonPrefix(string[] strs)
        {
            // If the array is empty, return "-1"
            if (strs == null || strs.Length == 0)
                return string.Empty;

            // Sort the array of strings
            Array.Sort(strs);

            // Get the first and last strings after sorting
            string first = strs[0];
            string last = strs[strs.Length - 1];
            int minLength = Math.Min(first.Length, last.Length);

            int i = 0;
            // Find the common prefix between the first and last
            // strings
            while (i < minLength && first[i] == last[i])
            {
                i++;
            }

            // Check if there's no common prefix
            if (i == 0)
                return string.Empty;

            // Return the common prefix
            return first.Substring(0, i);
            /*
            string res = String.Empty;
            for(int i=1;i<strs.Length; i++)
            {                
                if(i >= 2)
                {
                    if (res.Length < 1) return string.Empty;
                    if ((i + 1) <= strs.Length)
                    {
                        var temp1 = strs[i].ToCharArray();
                        for (int j = 0; j < temp1.Length; j++)
                        {
                            if (temp1[j] != res[j])
                            {
                                int len = res.Length - j;
                                res = res.Substring(0, len);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    var temp1 = strs[i-1].ToCharArray();
                    var temp2 = strs[i].ToCharArray();
                    for (int j = 0; j < temp1.Length; j++)
                    {
                        if (temp1.Length > j && temp2.Length>j && temp1[j] == temp2[j])
                        {
                            res = res+temp1[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return res;
            */
        }

        public static bool IsValid(string s)
        {
            //Last in, First out
            Stack<char> stack = new Stack<char>();

            foreach (char ch in s.ToCharArray())
            {
                switch (ch)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(ch);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            return false;
                        }
                        break;

                }
            }
            return stack.Count == 0;
        }

        internal static int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int element = nums[i];
                if (nums[i] != val){
                    nums[k] = nums[i];
                    k++;
                }
                //else
                //{
                //    int numIdx = Array.IndexOf(nums, val);
                //    List<int> tmp = new List<int>(nums);
                //    tmp.RemoveAt(numIdx);
                //    nums = tmp.ToArray();
                //}
            }

            return k;
        }

        internal static int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            return -1;
        }
    }
}
