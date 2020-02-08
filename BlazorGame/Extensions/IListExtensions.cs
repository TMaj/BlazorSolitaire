using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGame.Extensions
{
    public static class IListExtensions
    {
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            var count = list.Count();
            var random = new Random();

            for (var i = count; i > 0; --i)
            {
                var indexToReplace = random.Next(0, i);
                var temp = list[0];
                list[0] = list[indexToReplace];
                list[indexToReplace] = temp;
            }

            return list;
        }

        public static IList<T> Apply<T>(this IList<T> list, Action<T> func) 
        {
            foreach (var item in list)
            {
                func(item);
            }

            return list;
        }

        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null ? true : list.Count == 0;
        }
    }
}
