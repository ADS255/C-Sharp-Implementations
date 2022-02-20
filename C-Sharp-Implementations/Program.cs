// See https://aka.ms/new-console-template for more information
// Note (.Net 6 implicit using tags are disabled)
using CSI_Utilities;
using System;
using Sorting_algorithms;

int[] testData= new int[10];
Array.Copy(Test_Data.UnSortedArray,testData,10);

int[] i = BubbleSort.SortDecending(testData);

foreach(int item in i)
{
    Console.WriteLine(item);
}
