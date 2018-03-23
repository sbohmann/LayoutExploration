using System;

namespace LayoutExploration
{
    class NumberButtonGridPositions
    {
        internal static int CalculateGridX(int value)
        {
            if (contained(value, 1, 4, 7))
            {
                return 0;
            }
            else if (contained(value, 2, 5, 8, 0))
            {
                return 1;
            }
            else if (contained(value, 3, 6, 9))
            {
                return 2;
            }
            else
            {
                throw new ArgumentException(value.ToString());
            }
        }

        internal static int CalculateGridY(int value)
        {
            if (contained(value, 1, 2, 3))
            {
                return 0;
            }
            else if (contained(value, 4, 5, 6))
            {
                return 1;
            }
            else if (contained(value, 7, 8, 9))
            {
                return 2;
            }
            else if (contained(value, 0))
            {
                return 3;
            }
            else
            {
                throw new ArgumentException(value.ToString());
            }
        }

        static Boolean contained(int value, params int[] set)
        {
            foreach (int valueInSet in set)
            {
                if (value == valueInSet)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
