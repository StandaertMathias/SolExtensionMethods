using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLibExtensions
{
    public static class LibExtensions
    {
        public static bool In<T>(this T o, IEnumerable c)
        {
            foreach (T i in c)
            {
                if (i.Equals(o)) return true;
            }
            return false;
        }

        public static bool IsOdd(this int i)
        {
            return i%2 == 1;
        }
    }
}
