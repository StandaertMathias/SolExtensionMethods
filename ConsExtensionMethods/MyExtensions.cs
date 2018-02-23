using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsExtensionMethods
{
    static class MyExtensions
    {
        public static bool IsValidEmailAddress(this string s) {
            Regex regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return regex.IsMatch(s);
        }
    }
}
