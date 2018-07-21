using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SCurry.Builders
{
    public static class CurryBuilder
    {
        public const ushort MaxInputArgumentsCount = 16;


        /// <summary>
        ///     Generate all extensions.
        /// </summary>
        /// <param name="maxCount">Number of arguments for the longest function.</param>
        /// <returns>String with all extension methods are separated with EOL.</returns>
        public static string GenerateAllFuncExtentions(ushort maxCount = MaxInputArgumentsCount) =>
            ShortRange(0, (ushort)(maxCount + 1))
                .Select(GenerateFuncExtention)
                .Aggregate(new StringBuilder(), AppendLine)
                .ToString();

        public static string ReturnType(ushort count)
        {
            if (count == 0) return "Func<TResult>";

            return ShortRange(1, count)
                .Select(x => $"Func<T{x}, ")
                .Append("TResult")
                .Concat(ShortRange(0, count).Select(_ => ">"))
                .Aggregate(new StringBuilder(), Append)
                .ToString();
        }

        public static string GenerateFuncExtention(ushort count)
        {
            var types = TypeParameters(count);

            return $"public static {ReturnType(count)} Curry<{types}>"
                   + $"(this Func<{types}> func) => {Body(count)};";
        }

        public static string Body(ushort count) => throw new NotImplementedException();

        public static string[] TypeParameters(ushort count) =>
            ShortRange(1, count)
                .Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}")
                .Append("TResult")
                .ToArray();

        private static IEnumerable<ushort> ShortRange(ushort start, ushort count)
        {
            for (var i = start; i < count + start; i++) yield return i;
        }

        private static StringBuilder AppendLine(StringBuilder sb, string value) => sb.AppendLine(value);
        private static StringBuilder Append(StringBuilder sb, string value) => sb.Append(value);
    }
}