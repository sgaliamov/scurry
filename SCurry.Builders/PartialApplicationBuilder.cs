using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SCurry.Builders
{
    using static CommonBuilder;

    public static class PartialApplicationBuilder
    {
        public static string[] GenerateFuncExtentions(int count)
        {
            if (count == 0)
            {
                return new[] { "public static Func<TResult> Partial<TResult>(this Func<TResult> func) => func;" };
            }

            var markers = Markers(count);
            var allTypes = TypeParameters(count, true);

            return GenerateExtentions(markers, allTypes, true);
        }

        public static string[] GenerateActionExtentions(int count)
        {
            if (count == 0)
            {
                return new[] { "public static Action Partial(this Action action) => action;" };
            }

            var markers = Markers(count);
            var allTypes = TypeParameters(count, false);

            return GenerateExtentions(markers, allTypes, false);
        }

        private static bool[][] Markers(int count) =>
            Enumerable.Range(1, (int)Math.Pow(2, count) - 1)
                .Select(index => Markers(index, count))
                .ToArray();

        private static string[] GenerateExtentions(
            IEnumerable<bool[]> markers,
            string allTypes,
            bool isFunc)
        {
            var targetType = isFunc ? "Func" : "Action";
            var target = isFunc ? "func" : "action";

            return markers
                .Select(BuildInfo)
                .Select((info, index) =>
                {
                    var returnType = BuildReturnType(info, isFunc);
                    var callArguments = BuildCallArguments(info);
                    var bodyArguments = BuildBodyArguments(info);
                    var body = BuildBody(info, target);

                    return $"public static {targetType}{returnType} Partial<{allTypes}>"
                           + $"(this {targetType}<{allTypes}> {target}, {callArguments}) "
                           + $"=> {bodyArguments}{body};";
                })
                .ToArray();
        }

        private static string BuildCallArguments(IEnumerable<ExtensionInfo> info) => info
            .Reverse()
            .SkipWhile(x => !x.HasArg)
            .Reverse()
            .Select(x => x.CallAgr)
            .Join(", ");

        private static string BuildBodyArguments(IReadOnlyCollection<ExtensionInfo> info)
        {
            if (info.Count == 0)
            {
                return string.Empty;
            }

            var args = info
                .Where(x => x.BodyArg != null)
                .Select(x => x.BodyArg)
                .ToArray();

            return $"({args.Join(", ")}) => ";
        }

        private static string BuildBody(IReadOnlyCollection<ExtensionInfo> info, string target)
        {
            if (info.Count == 0)
            {
                return target;
            }

            var args = info
                .Where(x => x.BodyCallArg != null)
                .Select(x => x.BodyCallArg)
                .ToArray();

            return $"{target}({args.Join(", ")})";
        }

        private static string BuildReturnType(IEnumerable<ExtensionInfo> info, bool isFunc)
        {
            var items = info
                .Where(x => x.ReturnType != null)
                .Select(x => x.ReturnType);

            if (isFunc)
            {
                items = items.Append("TResult");
            }

            var types = items.ToArray();
            if (types.Length == 0)
            {
                return string.Empty;
            }

            return $"<{types.Join(", ")}>";
        }

        private static ExtensionInfo[] BuildInfo(IEnumerable<bool> markers) =>
            markers
                .Select((hasArg, index) => new { hasArg, number = index + 1 })
                .Select(x => new ExtensionInfo
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
    }
}
