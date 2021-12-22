using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace App1.Extensions
{
    public static class Common
    {
        public static bool IsNullOrEmpty(this IEnumerable list)
        {
            var enumerator = list.GetEnumerator();
            enumerator.Reset();
            var result = list == null || !enumerator.MoveNext();
            enumerator.Reset();

            return result;
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return list == null || !list.Any<T>();
        }

    }
}