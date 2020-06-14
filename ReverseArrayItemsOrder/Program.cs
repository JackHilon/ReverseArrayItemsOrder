using System;

namespace ReverseArrayItemsOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            var charArr = Console.ReadLine().ToCharArray();

            for (int i = 0; i < charArr.Length / 2; i++)
            {
                Swap(charArr, i, charArr.Length - 1 - i);
            }

            PrintArray(charArr);
        }
        private static void PrintArray(char[] arr)
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str = str + arr[i].ToString();
            }
            Console.WriteLine(str);
        }

        private static void Swap(char[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
