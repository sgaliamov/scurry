using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SCurry.Builders
{
    using static CommonBuilder;

    public static class PartialApplicationBuilder
    {
        public static IEnumerable<string> GenerateFuncExtentions(ushort count)
        {
            if (count == 0)
            {
                yield return "public static Func<TResult> Partial<TResult>(this Func<TResult> func) => func;";
                yield break;
            }

            var allTypes = TypeParameters(count, true);

            for (var index = 0; index < Math.Pow(2, count); index++)
            {
                var markers = Markers(count, index);
                var info = BuildInfo(markers);

                var returnType = BuildReturnType(info);
                var callAgruments = info.Select(x => x.CallAgr).Join(", ");
                var bodyArguments = index == 0 ? string.Empty : BuildBodyArguments(info);
                var body = index == 0 ? "func" : BuildBody(info);

                yield return $"public static Func<{returnType}> Partial<{allTypes}>"
                             + $"(this Func<{allTypes}> func, {callAgruments}) => "
                             + $"{bodyArguments}{body};";
            }
        }

        private static string BuildBodyArguments(IEnumerable<Info> info)
        {
            var args = info.Where(x => x.BodyArg != null).Select(x => x.BodyArg).ToArray();

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
        ///     For <paramref name="count" /> = 3:
        ///     000
        ///     100
        ///     010
        ///     110
        ///     ...
        ///     111
        ///     where 0 will be spacer, 1 will be argument.
        /// </summary>
        private static IEnumerable<bool> Markers(ushort count, int index) =>
            new BitArray(new[] { index })
                .OfType<bool>()
                .Take(count);

        private sealed class Info
        {
            public string ReturnType { get; set; }
            public string CallAgr { get; set; }
            public string BodyArg { get; set; }
            public string BodyCallArg { get; set; }
        }
    }
}
