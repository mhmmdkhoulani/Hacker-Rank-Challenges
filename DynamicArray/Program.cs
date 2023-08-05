using System.Collections;
using System.Collections.Generic;

namespace DynamicArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = Result.dynamicArray(n, queries);

            Console.WriteLine(String.Join("\n", result));

        }
    }
    class Result
    {

        /*
         * Complete the 'dynamicArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
           
            List<List<int>> computation = new List<List<int>>();
            List<int> answers = new List<int>();
            int lastAnswer = 0;
            for (int i = 0; i < n; i++)
            {
                List<int> arr = new List<int>();
                computation.Add(arr);
            }

            for (int i = 0; i < queries.Count; i++)
            {
                var x = queries[i][1];
                var y = queries[i][2];
                var idx = (x ^ lastAnswer) % n;
                if (queries[i][0] == 1)
                {
                    computation[idx].Add(y);
                   
                }
                else if((queries[i][0] == 2))
                {
                    lastAnswer = computation[idx][y % computation[idx].Count()];
                    answers.Add(lastAnswer);
                }
            }
            return answers;

        }

    }
}