using System;
namespace MethodOverloadingExercise
{
    internal class Methods
    {
        public Methods()
        {
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool z)
        {
            if (z == true && x + y != 1)
            {
                return $"{x + y} dollars";
            }

            else if (z == true && x + y == 1)
            {
                return $"{x + y} dollar"; 
            }
            else
            {
                return $"{x + y}";
            }
        }
    }
}

