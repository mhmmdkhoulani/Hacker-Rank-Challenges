namespace _2d_Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.hourglassSum(arr);

            Console.WriteLine(result);

            
        }
    }
    class Result
    {

        /*
         * Complete the 'hourglassSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int hourglassSum(List<List<int>> arr)
        {
            var result = -63;
            var temp = 0;
            int[][] arrayOfArrays = arr.Select(list => list.ToArray()).ToArray();
            Console.WriteLine("array size" + arrayOfArrays.Length);
            for(int i = 0; i < arrayOfArrays.Length - 2 ; i++)
            {

                for(int j =0 ; j < arrayOfArrays.Length - 2 ; j++)
                {
                    temp = arrayOfArrays[i][j] + arrayOfArrays[i][j + 1]  + arrayOfArrays[i][j + 2]
                            + arrayOfArrays[i + 1][j + 1] +
                           + arrayOfArrays[i + 2][j] + arrayOfArrays[i + 2][j + 1] + arrayOfArrays[i + 2][j + 2];
                    if(temp > result)
                    {
                        result = temp;
                    }
                   
                }
                
            }

            return result;
        }

    }


}