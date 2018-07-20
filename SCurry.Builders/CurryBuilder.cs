using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SCurry.Builders
{
    public static class CurryBuilder
    {
        private const ushort MaxInputArgumentsCount = 16;

        /// <summary>
        /// Generates all extensions.
        /// </summary>
        /// <param name="count">Number of methods starting (with 1) with parameterless function (Func&lt;TResult&gt;).</param>
        /// <returns>All extension methods.</returns>
        public static string GenerateAllFuncExtentions(ushort count = MaxInputArgumentsCount + 1) =>
            ShortRange(0, count)
                .Select(GenerateFuncExtention)
                .Aggregate(new StringBuilder(), AppendLine)
                .ToString();

        public static string ReturnType(ushort level) => "Func<T1, Func<T2, Func<T3, TResult>>>";

        public static string GenerateFuncExtention(ushort count)
        {
            var typeParameters = TypeParameters(count);

            return $"public static {ReturnType(count)} Curry<{typeParameters}>"
                   + $"(this Func<{typeParameters}> func) => {Body(count)};";
        }

        public static string Body(ushort count) => throw new NotImplementedException();

        public static string TypeParameters(ushort count)
        {
            if (count == 0) return "TResult";

            return string.Join(
                       ", ",
                       ShortRange(1, count)
                           .Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}")
                   ) + "TResult";
        }

        private static IEnumerable<ushort> ShortRange(ushort start, ushort count)
        {
            unchecked
            {
                for (var i = start; i < count + start; i++) yield return i;
            }
        }

        private static StringBuilder AppendLine(StringBuilder sb, string method) => sb.AppendLine(method);
    }
}