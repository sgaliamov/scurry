using System.Globalization;
using System.Linq;

namespace SCurry.Builders
{
    public class Builder
    {
        /// <summary>
        ///     T1, T2, T3, TResult
        /// </summary>
        public string TypeParameters(int count, bool isFunc)
        {
            var types = Enumerable.Range(1, count).Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}");

            if (isFunc)
            {
                types = types.Append("TResult");
            }

            return types.Join(", ");
        }
    }
}
