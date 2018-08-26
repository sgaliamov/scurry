using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SCurry.Builders
{
    using static CommonBuilder;
    using _ = Spacer.SpacerInstance;

    public static class PartialApplicationBuilder
    {
        public static Func<T1, T3, TResult> Partial<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> func,
            _ s1,
            T2 arg2,
            _ s3) => (arg1, arg3) => func(arg1, arg2, arg3);

        public static IEnumerable<string> GenerateFuncExtentions(ushort count)
        {
            var types = TypeParameters(count, true);

            for (var i = 0; i < Math.Pow(2, count); i++)
            {
                var markers = Markers(count, i);
                var returnType = ReturnType(markers);
                var callAgruments = CallAgruments(markers);
                var bodyArguments = BodyArguments(markers);
                var body = Body("func", count);

                yield return $"public static {returnType} Partial<{types}>"
                             + $"(this Func<{types}> func, {callAgruments}) => "
                             + $"{bodyArguments}{body};";
            }
        }

        /// <summary>
        ///     For <paramref name="count" /> = 3:
        ///     000
        ///     100
        ///     010
        ///     110
        ///     ...
        ///     111
        ///     where 0 will be spacer, 1 will be argument.
        /// </summary>
        private static bool[] Markers(ushort count, int i) =>
            new BitArray(new[] {i})
                .OfType<bool>()
                .Take(count)
                .ToArray();

        private static string BodyArguments(bool[] markers) => throw new NotImplementedException();

        private static string CallAgruments(bool[] markers) => throw new NotImplementedException();

        private static string ReturnType(bool[] markers) => throw new NotImplementedException();
    }
}
