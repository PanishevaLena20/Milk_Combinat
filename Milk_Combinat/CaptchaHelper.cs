using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Combinat
{
    public static class CaptchaHelper
    {
        private static readonly Random random = new Random();

        public static List<int> GenerateShuffledOrder()
        {
            List<int> order = new List<int> { 0, 1, 2, 3 };
            return order.OrderBy(x => random.Next()).ToList();
        }

        public static bool IsPuzzleComplete(List<int> currentOrder)
        {
            if (currentOrder == null || currentOrder.Count != 4)
                return false;

            for (int i = 0; i < 4; i++)
            {
                if (currentOrder[i] != i)
                    return false;
            }
            return true;
        }
    }
}
