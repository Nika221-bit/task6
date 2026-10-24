using System;
using System.Collections.Generic;

namespace task6
{
    public static class Delegates
    {
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static T CustomFirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public static bool CustomAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CustomAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static int CustomCount<T>(this IEnumerable<T> source, Func<T, bool> predicate = null)
        {
            int count = 0;
            foreach (var item in source)
            {
                if (predicate == null || predicate(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}