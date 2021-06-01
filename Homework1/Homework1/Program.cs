using System;
using System.Collections.Generic;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // HW1: Task 1

            var firstAClass = (excellentMarkStudents: 10, goodMarkStudents: 14, mediocreStudents: 4);
            var firstBClass = (excellentMarkStudents: 8, goodMarkStudents: 12, mediocreStudents: 5);
            var firstVClass = (excellentMarkStudents: 12, goodMarkStudents: 7, mediocreStudents: 8);

            int getAllExcellentMarkStudents(params (int excellentMarkStudents, int goodMarkStudents, int mediocreStudents)[] classes)
            {
                int result = 0;

                foreach (var item in classes)
                {
                    result += item.excellentMarkStudents;
                }

                return result;
            }

            int getAllGoodMarkStudents(params (int excellentMarkStudents, int goodMarkStudents, int mediocreStudents)[] classes)
            {
                int result = 0;

                foreach (var item in classes)
                {
                    result += item.goodMarkStudents;
                }

                return result;
            }

            int getAllMediocreStudents(params (int excellentMarkStudents, int goodMarkStudents, int mediocreStudents)[] classes)
            {
                int result = 0;

                foreach (var item in classes)
                {
                    result += item.mediocreStudents;
                }

                return result;
            }

            (double, double, double) GetPercentageOfStudentProgress((int excellentMarkStudents, int goodMarkStudents, int mediocreStudents) classOfStudents)
            {
                double totalNumberOfStudentsInClass = classOfStudents.excellentMarkStudents + classOfStudents.goodMarkStudents + classOfStudents.mediocreStudents;

                double percentageOfExcellentMarkStudents = classOfStudents.excellentMarkStudents * 100 / totalNumberOfStudentsInClass;
                double percentageOfGoodMarkStudents = classOfStudents.goodMarkStudents * 100 / totalNumberOfStudentsInClass;
                double percentageOfMediocreStudents = classOfStudents.mediocreStudents * 100 / totalNumberOfStudentsInClass;

                return (Math.Round(percentageOfExcellentMarkStudents, 1), Math.Round(percentageOfGoodMarkStudents, 1), Math.Round(percentageOfMediocreStudents, 1));

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 1 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"A number of all excellent mark students: {getAllExcellentMarkStudents(firstAClass, firstBClass, firstVClass)}");
            Console.WriteLine($"A number of all good mark students: {getAllGoodMarkStudents(firstAClass, firstBClass, firstVClass)}");
            Console.WriteLine($"A number of all mediocre students: {getAllMediocreStudents(firstAClass, firstBClass, firstVClass)}");

            Console.WriteLine($"A percentage of excellent mark students in firstAClass: {(GetPercentageOfStudentProgress(firstAClass)).Item1} %");
            Console.WriteLine($"A percentage of good mark students in firstAClass: {(GetPercentageOfStudentProgress(firstAClass)).Item2} %");
            Console.WriteLine($"A percentage of mediocre students in firstAClass: {(GetPercentageOfStudentProgress(firstAClass)).Item3} %");


            // HW1: Task 2

            bool IsEven(int n)
            {
                return (n & 1) == 0 ? true : false;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 2 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsEven(arr[i]))
                {
                    Console.WriteLine($"Number {arr[i]} is even");
                }
                else
                {
                    Console.WriteLine($"Number {arr[i]} is odd");
                }
            }


            // HW1: Task 3

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 3 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            double GetAverage(double a, double b, double c)
            {

                if ((b < a && a < c) || (b > a && a > c))
                {
                    return a;

                }
                if ((a < b && b < c) || (a > b && b > c))
                {
                    return b;
                }
                return c;
            }

            Console.WriteLine("Enter three numbers (use a comma (',') to separate the fractional part): ");
            string[] nums = Console.ReadLine().Split(' ');
            Console.WriteLine($"Number {GetAverage(double.Parse(nums[0]), double.Parse(nums[1]), double.Parse(nums[2]))} is the average");


            // HW1: Task 4

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 4 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            int[] BubbleSort(int[] arr)
            {
                int temp;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
                return arr;
            }

            int[] GetUniqueNums(int[] array)
            {
                arr = BubbleSort(array);
                int count = arr.Length;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == arr[i + 1]) count--;
                }

                int[] result = new int[count];

                int j = 0;

                result[j] = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] == arr[i - 1]) continue;

                    result[++j] = arr[i];
                }
                return result;
            }

            int[] sourceArr = { 1, 2, 3, 4, 57, 5, 4, 6, 4, 7, 6, 5, 8 };

            int[] finalArr = GetUniqueNums(sourceArr);
            foreach (int i in finalArr)
            {
                Console.WriteLine(i);
            }

            // HW1: Task 5

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 5 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            double[,] GetTransposedMatrix(double[,] matrix)
            {
                double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        result[i, j] = matrix[j, i];
                    }
                }
                return result;
            }

            double[,] matrix = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            double[,] trMatrix = GetTransposedMatrix(matrix);

            Console.WriteLine("Transposed matrix: ");

            for (int i = 0; i < trMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < trMatrix.GetLength(1); j++)
                {
                    Console.Write(trMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            // HW1: Task 6

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 6 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            double GetRoundedNumber(double num, int n)
            {
                string[] strArr = num.ToString().Split(',');

                if (strArr.Length == 1 || strArr[1].Length <= n) return num;

                return Double.Parse(strArr[0] + ',' + strArr[1].Substring(0, n));
            }

            Console.WriteLine($"Round the number 1.13456 to 2 decimal places: {GetRoundedNumber(1.13456, 2)}"); // 1,13
            Console.WriteLine($"Round the number 1.1 to 2 decimal places: {GetRoundedNumber(1.1, 2)}");         // 1,1
            Console.WriteLine($"Round the number 100 to 2 decimal places: {GetRoundedNumber(100, 2)}");         // 100


            // HW1: Task 7

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 7 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            // Y = 100 * tg(x) * √x / x
            // Y = 2 * sin(x) - 4

            double Y1(double x)
            {
                return 100 * Math.Tan(x) * Math.Sqrt(x) / x;
            }

            double Y2(double x)
            {
                return 2 * Math.Sin(x) - 4;
            }

            for (double i = -2; i < 2; i += 0.2)
            {
                Console.WriteLine(Y1(i));
            }

            Console.WriteLine("=======================");

            for (double i = -2; i < 2; i += 0.2)
            {
                Console.WriteLine(Y2(i));
            }


            // HW1: Task 8

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 8 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            string GetSubString(string str, char simbol)
            {
                if (!str.Contains(simbol))
                {
                    return "";
                }
                else
                {
                    string[] strArr = str.Split(simbol);
                    return strArr[1];
                }
            }

            Console.WriteLine(GetSubString("я-нехочу-делать-дз", '-')); // "нехочу"


            // HW1: Task 9

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 9 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            string GetIndexesOfWord(string str, string word)
            {
                int beginIndex = str.IndexOf(word);
                return $"{beginIndex} - {beginIndex + word.Length - 1}";
            }

            Console.WriteLine(GetIndexesOfWord("Lorem ipsum dolor sit amet", "ipsum")); // 6 - 10


            // HW1: Task 10

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== HW1: Task 10 ==================");
            Console.ForegroundColor = ConsoleColor.White;

            int[] GetRepeatedNums(int[] array)
            {
                int[] arr = BubbleSort(array);
                int count = 0;
                
                for (int i = 2; i < arr.Length; i++)
                {
                    if (arr[i] == arr[i-1] && arr[i] != arr[i-2]) count++;
                }

                int[] result = new int[count];

                int j = 0;

                for (int i = 2; i < arr.Length; i++)
                {
                    if (arr[i] == arr[i - 1] && arr[i] != arr[i - 2])
                    {
                        result[j++] = arr[i];                       
                    }
                }
                return result;
            }

            int[] sourceArray = { 1, 2, 2, 3, 4, 5, 5, 5, 6 };
            int[] repeatedNumsArray = GetRepeatedNums(sourceArray);

            Console.WriteLine("Source array:");

            foreach (int i in sourceArray)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nRepeated nums array:");

            foreach (int i in repeatedNumsArray)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            //int[] ConcatIntArrays(int[] a, int[] b)
            //{
            //    if (a.Length == 0) return b;
            //    if (b.Length == 0) return a;


            //    int[] result = new int[a.Length + b.Length];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        result[i] = a[i];
            //    }

            //    for (int i = a.Length; i < result.Length; i++)
            //    {
            //        result[i] = b[i - a.Length];
            //    }

            //    return result;
            //}

        }
    }
}
