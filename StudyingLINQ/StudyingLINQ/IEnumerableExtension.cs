using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingLINQ
{
    static class IEnumerableExtension
    {
        public static int Count<T>(this IEnumerable<T> list)
        {
            var count = 0;
            foreach (var item in list)
            {
                count += 1;
            }
            return count;
        }
    }
}
