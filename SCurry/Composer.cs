using System;
using System.Linq;

namespace SCurry
{
    public static class Composer
    {
        public static Func<T, T> Compose<T>(params Func<T, T>[] functions) =>
            value => functions
                     .Reverse()
                     .Aggregate(
                         value,
                         (current, function) => function(current));
    }
}
