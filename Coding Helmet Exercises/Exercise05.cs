using System;
using System.Linq;
using System.Collections.Generic;

namespace Coding_Helmet_Exercises
{
    class Exercise05 : IExercise
    {
        int[] Uniques(int[] input)
        {
            ISet<int> doubles = new HashSet<int>();
            IList<int> singles = new List<int>();

            foreach (var item in input)
                if (doubles.Add(item))
                    singles.Add(item);
                else
                    singles.Remove(item);

            return singles.ToArray();
        }

        public void Run()
        {
            int[] i = new int[]
            {
                0, 1, 1, 2, 3, 3, 4, 5, 6, 6, 7
            };

            int[] uniques = Uniques(i);

            Array.ForEach(uniques, Console.WriteLine);
        }
    }
}
