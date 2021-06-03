using System;

namespace String_to_Integer__atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
        }
        public class Solution
        {
            public static int MyAtoi(string s)
            {

                if (string.IsNullOrWhiteSpace(s))
                    return 0;


                int sign = 1, Base = 0, i = 0;
                int l;
                l = s.Length;

                // if whitespaces then ignore
                while (s[i] == ' ')
                {
                    if (s[i] != l)
                    {
                        i++;
                    }
                    else { return 0; }


                }

                // sign of number
                if (s[i] == '-' || s[i] == '+')
                {
                    sign = 1 - 2 * (s[i++] == '-' ? 1 : 0);
                }

                // checking for valid input
                while (
                    i < s.Length
                    && s[i] >= '0'
                    && s[i] <= '9')
                {

                    // handling overflow test case
                    if (Base > int.MaxValue / 10 || (Base == int.MaxValue / 10 && s[i] - '0' > 7))
                    {
                        if (sign == 1)
                            return int.MaxValue;
                        else
                            return int.MinValue;
                    }
                    Base = 10 * Base + (s[i++] - '0');
                }
                return Base * sign;
            }
        }
    }
}
