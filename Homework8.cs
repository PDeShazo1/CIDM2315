namespace Homework8;
class Program
{
   // -------------Question1-------------
//   static void ArraySum(int[] int_array)
//     {
//         int sum = 0;
//         for (int i = 0; i < int_array.Length; i++)
//         {
//             sum += int_array[i];
//         }

//         Console.WriteLine("The sum of int_array is: " + sum);
//     }
//     public static void Main(string[] args)
//     {
//         int[] int_array = {11, 23, 31, 42, 53};
//         ArraySum(int_array);
//     }
// }

//----------------Question2--------------
// static void PrintAllOddNumber(int[,] array_2d)
//     {
//         for (int i = 0; i < array_2d.GetLength(0); i++)
//         {
//             for (int j = 0; j < array_2d.GetLength(1); j++)
//             {
//                 if (array_2d[i, j] % 2 != 0)
//                 {
//                     Console.Write(array_2d[i, j] + " ");
//                 }
//             }
//         }
//         Console.WriteLine();
//     }
//     public static int ElementSum(int[,] array_2d)
//     {
//         int sum = 0;
//         for (int i = 0; i < array_2d.GetLength(0); i++)
//         {
//             for (int j = 0; j < array_2d.GetLength(1); j++)
//             {
//                 sum += array_2d[i, j];
//             }
//         }
//         return sum;
//     }
//     public static int[,] DoubleArray(int[,] array_2d)
//     {
//         int[,] result = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
//         for (int i = 0; i < array_2d.GetLength(0); i++)
//         {
//             for (int j = 0; j < array_2d.GetLength(1); j++)
//             {
//                 result[i, j] = array_2d[i, j] * 2;
//             }
//         }
//         return result;
//     }
//     public static void Main(string[] args)
//     {
//         int[,] array_2d = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
//         Console.WriteLine("Q1: Print all odd numbers:");
//         PrintAllOddNumber(array_2d);
//         Console.WriteLine("Q2: The sum of array elements: " + ElementSum(array_2d));
//         Console.WriteLine("Q3: The new 2d array:");
//         int[,] result = DoubleArray(array_2d);
//         for (int i = 0; i < array_2d.GetLength(0); i++)
//         {
//             for (int j = 0; j < array_2d.GetLength(1); j++)
//             {
//                 Console.Write(result[i, j] + " ");
//             }
//         }
//         Console.WriteLine();
//     }
 }