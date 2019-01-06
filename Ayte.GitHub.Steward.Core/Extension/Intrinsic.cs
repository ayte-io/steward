using System.Collections.Generic;

namespace Ayte.GitHub.Steward.Core.Extension
{
    public static class Intrinsic
    {
        public static IEnumerable<T> ToEnumerable<T>(this T anything)
        {
            yield return anything;
        }
    }
}
