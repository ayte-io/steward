using System.Collections.Generic;

namespace Ayte.GitHub.Steward.Core.Utility
{
    public static class Enumerables
    {
        public static IEnumerable<T> Single<T>(T item)
        {
            yield return item;
        }
    }
}
