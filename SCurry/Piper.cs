using System;
using System.Linq;

namespace SCurry
{
    public static class Piper
    {
        public static Func<T, T> Pipe<T>(params Func<T, T>[] functions) =>
            value => functions
                .Aggregate(
                    value,
                    (current, function) => function(current));
    }
}
