using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding_Helmet_Exercises
{
    class Exercise12 : IExercise
    {
        int[] Intersection(int[] in1, int[] in2)
        {
            ISet<int> output = new HashSet<int>();
            ISet<int> in1set = new HashSet<int>();

            foreach (var item in in1)
                in1set.Add(item);

            foreach (var item in in2)
                if (in1set.Contains(item))
                    output.Add(item);
            
            return output.ToArray();
        }

        public void Run()
        {
            int[] i1 = new int[]
            {
                0, 0, 1, 1, 2, 3, 4, 5, 5, 6
            };
            int[] i2 = new int[]
            {
                0, 0, 1, 2, 3, 6
            };

            int[] uniques = Intersection(i1, i2);

            Array.ForEach(uniques, Console.WriteLine);
        }
    }
}
