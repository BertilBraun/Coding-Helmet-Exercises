using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding_Helmet_Exercises
{
    class Exercise07 : IExercise
    {
        int Uniques(int[] input)
        {
            IDictionary<int, int> counts = new Dictionary<int, int>();

            foreach (var item in input)
            {
                if (!counts.ContainsKey(item))
                    counts.Add(item, 0);
                counts[item]++;
            }

            return counts.FirstOrDefault(item => item.Value == 1).Key;
        }

        public void Run()
        {
            int[] i = new int[]
            {
                0, 0, 0, 1, 1, 1, 2, 3, 3, 3, 4, 4, 4
            };

            int unique = Uniques(i);

            Console.WriteLine(unique);
        }
    }
}
