using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SCurry.Builders
{
    using static CommonBuilder;

    public static class PartialApplicationBuilder
    {
        public static IEnumerable<string> GenerateFuncExtentions(int count)
        {
            if (count == 0)
            {
                return new[] { "public static Func<TResult> Partial<TResult>(this Func<TResult> func) => func;" };
            }

            var markers = Enumerable.Range(1, (int)Math.Pow(2, count) - 1)
                .Select(index => Markers(index, count))
                .ToArray();

            var allTypes = TypeParameters(count, true);

            return GenerateFuncExtentions(markers, allTypes);
        }

        private static IEnumerable<string> GenerateFuncExtentions(
            IEnumerable<bool[]> markers,
            string allTypes)
        {
            return markers
                .Select(BuildInfo)
                .Select((info, index) =>
                {
                    var returnType = BuildReturnType(info);
                    var callArguments = BuildCallArguments(info);
                    var fullBody = $"{BuildBodyArguments(info)}{BuildBody(info)}";

                    return $"public static Func<{returnType}> Partial<{allTypes}>"
                           + $"(this Func<{allTypes}> func, {callArguments}) => {fullBody};";
                });
        }

        private static string BuildCallArguments(IEnumerable<Info> info) => info
            .Reverse()
            .SkipWhile(x => !x.HasArg)
            .Reverse()
            .Select(x => x.CallAgr)
            .Join(", ");

        private static string BuildBodyArguments(IEnumerable<Info> info)
        {
            var args = info
                .Where(x => x.BodyArg != null)
                .Select(x => x.BodyArg)
                .ToArray();

            return $"({args.Join(", ")}) => ";
        }

        private static string BuildBody(IEnumerable<Info> info)
        {
            var args = info.Select(x => x.BodyCallArg).ToArray();

            return $"func({args.Join(", ")})";
        }

        private static string BuildReturnType(IEnumerable<Info> info) => info
            .Where(x => x.ReturnType != null)
            .Select(x => x.ReturnType)
            .Append("TResult")
            .Join(", ");

        private static Info[] BuildInfo(IEnumerable<bool> markers) => markers
            .Select((hasArg, index) => new { hasArg, number = index + 1 })
            .Select(x => new Info
            {
                ReturnType = x.hasArg ? null : $"T{x.number}",
                CallAgr = x.hasArg ? $"T{x.number} arg{x.number}" : $"_ gap{x.number}",
                BodyArg = x.hasArg ? null : $"arg{x.number}",
                BodyCallArg = $"arg{x.number}",
                HasArg = x.hasArg
            })
            .ToArray();

        /// <summary>
        ///     For <paramref name="length" /> = 3:
        ///     [0, 0, 0]
        ///     [1, 0, 0]
        ///     [0, 1, 0]
        ///     [1, 1, 0]
        ///     ...
        ///     [1, 1, 1]
        ///     where 0 will be spacer, 1 will be argument.
        /// </summary>
        private static bool[] Markers(int value, int length) =>
            new BitArray(new[] { value })
                .OfType<bool>()
                .Take(length)
                .ToArray();

        private struct Info
        {
            public string ReturnType;
            public string CallAgr;
            public string BodyArg;
            public string BodyCallArg;
            public bool HasArg;
        }
    }
}
