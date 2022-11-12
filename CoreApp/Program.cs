// See https://aka.ms/new-console-template for more information
using CoreApp.com.test;

Console.WriteLine("Hello, World!");

var str = " Hello   Mojidul   Islam      ";
Console.WriteLine(ProblemAndSolutionOne.RemoveSpaceFromStr(str));
//remove duplicate value from an int array
//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
//int[] nums = { 1, 1, 2 };
int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
Console.WriteLine(ProblemAndSolutionOne.RemoveDuplicates(nums));
//var withoutDuplicateValues = ProblemAndSolutionOne.RemoveDuplicates2(nums);
//Array.ForEach(withoutDuplicateValues, x=> Console.WriteLine("[{0}]",',', x));
//Console.WriteLine("[{0}]", string.Join(',', withoutDuplicateValues));
Console.WriteLine("Count "+ProblemAndSolutionOne.RemoveDuplicates2(nums));
//How to combine two arrays without duplicate values in C#?
string[] arr1 = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };
string[] arr2 = { "Sparrow", "Peacock", "Dove", "Crow" };
string[] combineArray = ProblemAndSolutionOne.combineTwoArrays(arr1, arr2);
Console.WriteLine("[{0}]",string.Join(',',combineArray));
//How to get a comma-separated string from the integer array
int[] nums1 = { 1, 2, 3, 4 };
//Console.WriteLine("[{0}]", string.Join(',', nums1));
Console.WriteLine("{0}", string.Join(',', nums1));
//How to get second max value from an int array
int [] nums2 = { 1, -20, -13, 40 ,20,25};
Console.WriteLine("Second Largest No. {0}", ProblemAndSolutionOne.getSecondMaxValue(nums2));
// How to get reverse order strig
string name = "Mojidul Islam";
Console.WriteLine("String reverse order= {0}", ProblemAndSolutionOne.getReverseOrderString(name));




