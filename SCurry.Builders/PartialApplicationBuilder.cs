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

            var allTypes = TypeParameters(count, true);

            return Enumerable.Range(0, (int)Math.Pow(2, count))
                .Select(index => Markers(index, count))
                .Select(BuildInfo)
                .Select((info, index) =>
                {
                    var returnType = BuildReturnType(info);
                    var callAgruments = BuildCallAgruments(info);
                    var bodyArguments = index == 0 ? string.Empty : BuildBodyArguments(info);
                    var body = index == 0 ? "func" : BuildBody(info);

                    return $"public static Func<{returnType}> Partial<{allTypes}>"
                           + $"(this Func<{allTypes}> func, {callAgruments}) => "
                           + $"{bodyArguments}{body};";
                });
        }

        private static string BuildCallAgruments(IEnumerable<Info> info) => info
            .Where(x => x != null)
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
                BodyCallArg = $"arg{x.number}"
            })
            .ToArray();

        /// <summary>
        ///     For <paramref name="length" /> = 3:
        ///     000
        ///     100
        ///     010
        ///     110
        ///     ...
        ///     111
        ///     where 0 will be spacer, 1 will be argument.
        /// </summary>
        private static bool[] Markers(int value, int length) =>
            new BitArray(new[] { value })
                .OfType<bool>()
                .Take(length)
                .ToArray();

        private sealed class Info
        {
            public string ReturnType { get; set; }
            public string CallAgr { get; set; }
            public string BodyArg { get; set; }
            public string BodyCallArg { get; set; }
        }
    }
}
