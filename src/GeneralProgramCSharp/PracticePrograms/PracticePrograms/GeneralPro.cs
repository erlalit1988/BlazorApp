using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    //public class A
    //{
    //    public virtual void AMethod()
    //    {
    //        Console.WriteLine("A method call");
    //    }
    //}
    //public class B : A
    //{
    //    public override void AMethod()
    //    {
    //        Console.WriteLine("B method call");
    //    }
    //}
    //public class C : B
    //{
    //    public virtual void CMethod()
    //    {
    //        Console.WriteLine("C method call");
    //    }
    //}
    //public class D : C
    //{
    //    public override void CMethod()
    //    {
    //        Console.WriteLine("D method call");
    //    }
    //}
    public class GeneralPro
    {
        public static int Print2larggest(int[] arr, int arr_size)
        {
            int i, first, second;
            //There should be atleast two elements
            if (arr_size < 2)
            {
                Console.WriteLine($"Invalid Input");
                return 0;
            }

            first = second = int.MinValue;
            for (i = 0; i < arr_size; i++)
            {
                //if current element is smaller than first then update 
                //both first and second
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }

                //if arr[i] is in between first and second then update second
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }
            if (second == int.MinValue)
            {
                Console.WriteLine($"There is no second largest element ");
                return 0;
            }
            else
            {
                return second;
            }

        }

        public static string SwapNeighbourChar(string input)
        {

            char[] arrStirng = input.ToCharArray();
            StringBuilder sb = new();

            for (int i = 0; i < arrStirng.Length; i++)
            {
                if (i != arrStirng.Length - 1)
                {
                    sb.Append(arrStirng[i + 1]);

                    sb.Append(arrStirng[i]);

                }
                else
                {
                    sb.Append(arrStirng[i]);
                }

                i = i + 1;
            }
            return sb.ToString();
        }
        public static bool IsPrimeNum(int input)
        {
            bool isprime = false;
            for (int i = 2; i <= input; i++)
            {
                if ((input % i) is 0 && input != i)
                {
                    isprime = false;
                    return isprime;
                }
                else if (input == i)
                {
                    isprime = true;
                    return isprime;
                }
            }
            return isprime;
        }
        public static void NewMethod1(int noOfRows)
        {
            /* Program to print Pattern with Numbers
             * 1
             * 2 2
             * 3 3 3
             * 4 4 4 4
             * 5 5 5 5 5
             */
            for (int row = 1; row <= noOfRows; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");

                }
                Console.WriteLine();
            }
        }
        public static void NewMethod2(int noOfRows)
        {
            /* Program to print Pattern with Numbers
            * 1
            * 1 2
            * 1 2 3
            * 1 2 3 4
            * 1 2 3 4 5
            */
            for (int row = 1; row <= noOfRows; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }
        }
        public static void NewMethod3(int noOfRows)
        {
            /* Program to print Pattern Floyd's Triangle
            * 1
            * 2 3
            * 4 5 6
            * 7 8 9 10
            * 11 12 13 14 15
            */
            int counter = 1;

            for (int row = 1; row <= noOfRows; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(counter + " ");
                    counter++;

                }
                Console.WriteLine();
            }
        }
        public static void NewMethod4(int noOfRows)
        {
            /* Program to print Pattern with Numbers
             * 1
             * 1 1
             * 1 1 1
             * 1 1 1 1
             * 1 1 1 1 1
             */
            int counter = 1;
            for (int row = 1; row <= noOfRows; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(counter + " ");

                }
                Console.WriteLine();
            }
        }

    }
}
