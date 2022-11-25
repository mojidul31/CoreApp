// See https://aka.ms/new-console-template for more information
using CoreApp.com.test;

Console.WriteLine("Hello, World!");

var str = " Hello   Mojidul   Islam      ";
Console.WriteLine(ProblemAndSolutionOne.RemoveSpaceFromStr(str));
//remove duplicate value from an int array
//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
//int[] nums = { 1, 1, 2 };
int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
Console.WriteLine("Array is "+ProblemAndSolutionOne.RemoveDuplicates(nums));
//var withoutDuplicateValues = ProblemAndSolutionOne.RemoveDuplicates2(nums);
//Array.ForEach(withoutDuplicateValues, x=> Console.WriteLine("[{0}]",',', x));
//Console.WriteLine("[{0}]", string.Join(',', withoutDuplicateValues));
Console.WriteLine("Array Count "+ProblemAndSolutionOne.RemoveDuplicates2(nums));
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
// Find the Height of Stack X to the Power N.
Console.WriteLine("Power result = {0}", ProblemAndSolutionOne.getBaseToThePower(10,5));
//Reverse Words in a String
//string str2 = "the sky is blue";
//string str2 = "  hello world  ";
//string str2 = "a good   example";
string str2 = "EPY2giL";
Console.WriteLine("Reverse String " + ProblemAndSolutionOne.ReverseWords(str2));

int[] numsN = { 2, 5, 7, 11, 15 };
int target = 9;//two array position sum ..2+7=9
//return [0,2]
var dd = ProblemAndSolutionOne.getArrayIndex(numsN, target);
Console.WriteLine("Array position [{0}]", string.Join(", ", dd));
//Sealed classes are used to restrict the inheritance feature of object oriented programming.
//If you try to derive a class from the SealedClass, you will get an error.
SealedClass sealedClass = new SealedClass();
int total = sealedClass.Add(4, 5);
Console.WriteLine("Total = " + total.ToString());
//example of Func
Func<string, string, string> func = ProblemAndSolutionOne.Append;
string fullName = func("Mojidul", "Islam");
Console.WriteLine(fullName);
//example of Action
Action<string, string> funcAction = ProblemAndSolutionOne.AppendPrint;
funcAction("Mojidul", "Islam");


Console.ReadLine();



