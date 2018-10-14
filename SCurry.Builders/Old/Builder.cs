using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SCurry.Builders
{
    public abstract class Builder
    {
        protected const int MaxInputArgumentsCount = 16;

        /// <summary>
        ///     T1, T2, T3, TResult
        /// </summary>
        protected static string TypeParameters(int count, bool isFunc)
        {
            var types = Enumerable.Range(1, count).Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}");

            if (isFunc)
            {
                types = types.Append("TResult");
            }

            return types.Join(", ");
        }

        protected string[] GenerateExtentions(string name, int argsCount, bool isFunc)
        {
            var markers = Markers(argsCount);
            var allTypes = TypeParameters(argsCount, isFunc);
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

                    return $"public static {returnType} {name}<{allTypes}>"
                           + $"(this {targetType}<{allTypes}> {target}, {callArguments}) "
                           + $"=> {bodyArguments}{body};";
                })
                .ToArray();
        }

        protected abstract ExtensionParameters CreateExtensionParameters(bool hasArg, int number);

        private bool[][] Markers(int argsCount) =>
            Enumerable.Range(1, (int)Math.Pow(2, argsCount) - 1)
                .Select(index => Markers(index, argsCount))
                .ToArray();

        private string BuildCallArguments(IEnumerable<ExtensionParameters> info) => info
            .Reverse()
            .SkipWhile(x => !x.HasArg)
            .Reverse()
            .Select(x => x.CallAgr)
            .Join(", ");

        protected abstract string BuildBodyArguments(IReadOnlyCollection<ExtensionParameters> info);

        private string BuildBody(IReadOnlyCollection<ExtensionParameters> info, string target)
        {
            var args = info
                .Where(x => x.BodyCallArg != null)
                .Select(x => x.BodyCallArg)
                .ToArray();

            return $"{target}({args.Join(", ")})";
        }

        private string BuildReturnType(IEnumerable<ExtensionParameters> info, bool isFunc)
        {
            var target = isFunc ? "Func" : "Action";

            var items = info
                .Where(x => x.ReturnType != null)
                .Select(x => x.ReturnType);

            if (isFunc)
            {
                items = items.Append("TResult");
            }

            var types = items.ToArray();
            if (types.Length == 0 && !isFunc)
            {
                return target;
            }

            return $"{target}<{types.Join(", ")}>";
        }

        private ExtensionParameters[] BuildInfo(IEnumerable<bool> markers) =>
            markers
                .Select((hasArg, index) => new { hasArg, number = index + 1 })
                .Select(x => CreateExtensionParameters(x.hasArg, x.number))
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
