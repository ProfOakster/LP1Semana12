using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(
            IEnumerable<T> items, T mark
            ) where T : struct, IComparable<T>
        {
            foreach (T item in items)
            {
                if (item.CompareTo(mark) < 0)
                    yield return item;
            }
        }
    }
}