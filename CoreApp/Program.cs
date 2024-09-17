﻿// See https://aka.ms/new-console-template for more information
using CoreApp.com.test;
using System;

Console.WriteLine("Hello, World!");
//Common Child
//string s11 = "ABCD";
//string s12 = "ABDC";
//string s11 = "HARRY";
//string s12 = "SALLY";
//string s11 = "AA";
//string s12 = "BB";
string s11 = "SHINCHAN";
string s12 = "NOHARAAA";
var countStr = ProblemAndSolutionOne.commonChild(s11, s12);
Console.WriteLine("[{0}]", string.Join(',', countStr));

//How to find unique integers from two arrays
int[,,,] array1 = new int[2, 2, 2, 2] {
 {
 {{1, 2}, {3, 4}},
 {{5, 6}, {7, 8}}
 },
 {
 {{9, 10}, {11, 12}},
 {{13, 14}, {15, 16}}
 }
};
int[,,,] array2 = new int[2, 2, 2, 2] {
 {
 {{5, 2}, {13, 14}},
 {{9, 6}, {20, 8}}
 },
 {
 {{3, 10}, {21, 4}},
 {{25, 16}, {7, 1}}
 }
};

int[,,,] array3 = new int[1, 1, 1, 3] { { { { 1, 2, 3 } } } };
int[,,,] array4 = new int[1, 1, 1, 3] { { { { 4, 5, 6 } } } };

int[,,,] array5 = new int[2, 2, 2, 1] {
 {
 {{1}, {2}},
 {{3}, {4}}
 },
 {
 {{5}, {6}},
 {{7}, {8}}
 }
};
int[,,,] array6 = new int[2, 2, 2, 1] {
 {
 {{1}, {2}},
 {{3}, {4}}
 },
 {
 {{5}, {6}},
 {{7}, {8}}
 }
};

int[,,,] array7 = new int[0, 0, 0, 0];
int[,,,] array8 = new int[0, 0, 0, 0];

int[,,,] array9 = new int[2, 2, 1, 2] {
 {
 {{1, 2}},
 {{3, 4}}
 },
 {
 {{5, 6}},
 {{7, 8}}
 }
};
int[,,,] array10 = new int[3, 2, 1, 2] {
 {
 {{5, 9}},
 {{3, 6}}
 },
 {
 {{7, 2}},
 {{8, 4}}
 },
 {
 {{10, 11}},
 {{1, 12}}
 }
};

int[,,,] array11 = new int[1, 1, 1, 5] { { { { 1, 2, 3, 4, 5 } } } };
int[,,,] array12 = new int[1, 1, 1, 6] { { { { 5, 4, 3, 2, 1, 0 } } } };

int[,,,] array13 = new int[3, 3, 3, 3];
int[,,,] array14 = new int[3, 3, 3, 3];
//Initialize both arrays with some large data
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        for (int k = 0; k < 3; k++)
            for (int l = 0; l < 3; l++)
            {
                array13[i, j, k, l] = i * j * k * l;
                array14[i, j, k, l] = i * j * k * l;
            }

var testCase1 = ProblemAndSolutionOne.FindMatchingElements(array1, array2);
Console.WriteLine("[{0}]", string.Join(',', testCase1));

var testCase2 = ProblemAndSolutionOne.FindMatchingElements(array3, array4);
Console.WriteLine("[{0}]", string.Join(',', testCase2));

var testCase3 = ProblemAndSolutionOne.FindMatchingElements(array5, array6);
Console.WriteLine("[{0}]", string.Join(',', testCase3));

var testCase4 = ProblemAndSolutionOne.FindMatchingElements(array7, array8);
Console.WriteLine("[{0}]", string.Join(',', testCase4));

var testCase5 = ProblemAndSolutionOne.FindMatchingElements(array9, array10);
Console.WriteLine("[{0}]", string.Join(',', testCase5));

var testCase6 = ProblemAndSolutionOne.FindMatchingElements(array11, array12);
Console.WriteLine("[{0}]", string.Join(',', testCase6));

var testCase7 = ProblemAndSolutionOne.FindMatchingElements(array13, array14);
Console.WriteLine("[{0}]", string.Join(',', testCase7));

//append woth dollar
//string ad1 = "gbcebabbfffcdgfeeaadecaeecabbabbgcafeabgecfeffcbafgdegdacefcadabbfdcgcebegbfgeeebfegfacdagbbgeagaaceefcaedceacceebdgebeecedcbdbeebecgcfcgdaaaegfbcbfffccffabbceafaagdedadbfcaedaffbaggebfedegfabefafefgdbafedbggabccaedabfgfgggbcfgeggdcdfeebaedaaccefgegbffaaggdcbbbfdbgaaffbbgcfafccdgcaabccbfbgbabegddagcgfbcdfdaccegbabfedbbdaddebddgegedgaabebfeeggddagaeececcafdgddceddcbdagaecceacgfabgccecgecgcefaafcaedfccdeeceffefadeffefggaeggbbfgcacgfaeefbfbccggcbcgeagcaacdcbegcdaacdgbebdaabddeagafbfagfebfefffcbcgefbcfeggafccabfagegccefe";
string ad2 = "ckbjbibcbdhhkkfkgfkjbdebggcbhjkbeedbehdggegkjikhgibiieafdkiichaifbjfheijadadicacjbhehhgegghbkdkiedafjdddgekdeahgdjebjhkhbcjdfddggkdhjjgaajbihbkgggjcfaejkgdihkhdhdcaaddhddkdkcejehdaieaiciicaabkaahbjjbjegdbefkkkadjgaiegehedjdfebkhebacaaaafhgcfehfhkdkhgjffkgkfahikdkaagchkggjcheejecdcjbkdkhaeiiijadbc";
Console.WriteLine("Append String =>" + ProblemAndSolutionOne.AppendWithDollar(ad2));

//common char in two string then yes
string cs1 = "hi";
string cs2 = "world";
Console.WriteLine("Common String =>" + ProblemAndSolutionOne.CommonSubstring(cs1, cs2));


//check anagram and
string strAnaPalin = "aaabbbb";
Console.WriteLine("check palindrom =>" + ProblemAndSolutionOne.checkPalindrome(strAnaPalin));
Console.WriteLine("palindrom =>" + ProblemAndSolutionOne.RearrageablePalindrom(strAnaPalin));
Console.WriteLine("kkds=>" + ProblemAndSolutionOne.MakeAnagram(strAnaPalin));

//delete anagrams
string s3 = "absdjkvuahdakejfnfauhdsaavasdlkj";
string s4 = "djfladfhiawasdkjvalskufhafablsdkashlahdfa";
Console.WriteLine(ProblemAndSolutionOne.makingAnagrams(s3, s4));

//anagrams
string s1 = "aaabbb";
string s2 = "ab";
Console.WriteLine(ProblemAndSolutionOne.GetMinimumChangeNoToMakeAnagram(s2));

//Palindrom index
var palindromIndex = ProblemAndSolutionOne.PalindromeIndex("aaa");
Console.WriteLine(palindromIndex);

//How to revers a string
var reverseStr = ProblemAndSolutionOne.ReverseString("ABCDEFGH");
Console.WriteLine(reverseStr);

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
//How to find 5th largest salary using LINQ
var highestSalary = ProblemAndSolutionOne.Nthhighestsalary(2);
Console.WriteLine("Array position [{0}]", string.Join(", ", highestSalary));
//Use of Tuple
var nameUsing = ProblemAndSolutionOne.NewTuplePattern("","102","VII");
Console.WriteLine("Tuple Use [{0}]", string.Join(", ", nameUsing));
//Use of Predicate delegate
ProblemAndSolutionOne.PredicateDelegate();
//Sum of array
List<int> arr = new List<int>();
arr.AddRange(new[] { 1, 2, 3, 6, 7, 3, 8 });
var totalArrayElement = ProblemAndSolutionOne.SimpleArraySum(arr);
Console.WriteLine("Total Array Element Sum-"+ totalArrayElement.ToString());

Console.ReadLine();



