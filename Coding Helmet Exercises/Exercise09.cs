using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding_Helmet_Exercises
{
    class Exercise09 : IExercise
    {
        string Trim(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];

                if (input[i] == ' ')
                    while (i < input.Length - 1 && input[i + 1] == ' ')
                        i++;
            }

            return output;
        }

        public void Run()
        {
            string s = " This  is  a  test  String ";

            string ret = Trim(s);

            Console.WriteLine(ret);
        }
    }
}
