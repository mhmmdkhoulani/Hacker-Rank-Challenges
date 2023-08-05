using System;

namespace Array_Rotation
{
    

    class Program
    {
        public static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.rotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));

        }
    }

    class Result
    {

        /*
         * Complete the 'rotateLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER d
         *  2. INTEGER_ARRAY arr
         */

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            var elements = arr.Count;

            int[] temp = new int[d];
            var temp2 = new List<int>(arr);
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = arr[i];
                
            }
            temp2.RemoveRange(0, d );
            var shiftedArray = new int[elements];
            temp2.CopyTo(shiftedArray, 0);
            temp.CopyTo(shiftedArray, temp2.Count);
            Console.WriteLine(shiftedArray);
            return shiftedArray.ToList();
        }

    }
}