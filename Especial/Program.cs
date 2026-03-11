using System;

namespace Especial
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine(GetSpecial(5));
        }

        private static int GetSpecial(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return 2 * GetSpecial(n - 2) + GetSpecial(n- 1);
            }
        }
    }
}
