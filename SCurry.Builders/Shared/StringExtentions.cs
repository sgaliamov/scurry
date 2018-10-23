using System;

namespace SCurry.Builders.Shared
{
    public static class StringExtentions
    {
        public static bool IsEmpty(this string str) => string.IsNullOrWhiteSpace(str);

        public static string MapIfExists(this string str, Func<string, string> map) =>
            str.IsEmpty() ? str : map(str);

        public static string IfEmpty(this string str, string value) =>
            str.IsEmpty() ? value : str;
    }
}
