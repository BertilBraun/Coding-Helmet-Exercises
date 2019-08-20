using System;

namespace Coding_Helmet_Exercises
{
    class Exercise11 : IExercise
    {
        bool IsPrime(int input)
        {
            if (input < 0)
                return false;

            for (int i = 2; i < input; i++)
                if (input % i == 0)
                    return false;

            return true;
        }

        public void Run()
        {
            bool ret = IsPrime(12);

            Console.WriteLine(ret);
        }
    }
}
