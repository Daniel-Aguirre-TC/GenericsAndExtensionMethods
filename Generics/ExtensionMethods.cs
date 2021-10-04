using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Generics
{
    public static class ExtensionMethods
    {


        public static string  Pluralize(this string s)
        {
            return s.ToLower().EndsWith('y') ? s.Remove(s.Length - 1) + "ies" : s + "s";
        }

        public static T[] SortArray<T>(this T[] array)
        {
            return array.OrderBy(x => x).ToArray();
        }

    }
}
