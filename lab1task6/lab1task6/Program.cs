﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace lab1task6
{
    public delegate void SortDelegate(int[] array);
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "file1.txt";

            int[] data = ReadNumbersFromFile(file);

            CheckSortMethod(SelectionSort, StudentSelectionSort, data);

            CheckSortMethod(CocktailSort, StudentCocktailSort, data);
        }

        static void CheckSortMethod(SortDelegate standartSort, SortDelegate studentSort, int[] data)
        {
            int[] standartData = new int[data.Length];
            data.CopyTo(standartData, 0);

            int[] studentData = new int[data.Length];
            data.CopyTo(studentData, 0);

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            standartSort(standartData);
            stopwatch.Stop();
            long standartTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();

            stopwatch.Start();
            studentSort(studentData);
            stopwatch.Stop();
            long studentTime = stopwatch.ElapsedMilliseconds;

            if (standartData.SequenceEqual(studentData) && Math.Abs(standartTime - studentTime) <= standartTime * 0.1)
            {
                Console.WriteLine("Студентський метод пройшов перевірку.");
            }
            else
            {
                Console.WriteLine("Студентський метод не пройшов перевірку.");
            }
        }

        static int[] ReadNumbersFromFile(string filePath)
        {
            string text = File.ReadAllText(filePath);
            int[] numbers = text.Split(' ')
                                .Where(s => !string.IsNullOrEmpty(s))
                                .Select(int.Parse)
                                .ToArray();
            return numbers;
        }

        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                bool swapNeeded = false;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                        swapNeeded = true;
                    }
                }

                if (swapNeeded)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }

        static void StudentSelectionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
                
            }
            System.Threading.Thread.Sleep(4000);

        }

        static void CocktailSort(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length;

            while (swapped == true)
            {
                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;

                swapped = false;
                end--;

                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

                start++;
            }
        }

        static void StudentCocktailSort(int[] array)
        {
            int start = 0, end = array.Length - 1;
            bool swapped = true;
            while (start < end && swapped)
            {
                swapped = false;
                for (int i = start; i < end; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
                swapped = false;
                --end;
                for (int i = end - 1; i >= start; --i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                ++start;
            }
        }
    }
}
