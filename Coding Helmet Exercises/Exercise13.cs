using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding_Helmet_Exercises
{
    class Exercise13 : IExercise
    {
        bool Anagrams(string in1, string in2)
        {
            if (in1 == in2 || in1.Length != in2.Length)
                return false;

            IList<char> chars = new List<char>(in1);

            foreach (var item in in2)
                if (!chars.Remove(item))
                    return false;

            return chars.Count == 0;
        }

        public void Run()
        {
            bool ret = Anagrams("ABC", "DAB");

            Console.WriteLine(ret);
        }
    }
}
