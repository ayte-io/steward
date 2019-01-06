using System;
using System.IO;

namespace Ayte.GitHub.Steward.Core.Utility
{
    public static class Paths
    {
        public static string AddBaseNameSuffix(string path, string suffix)
        {
            return TransformBaseName(path, baseName => baseName + suffix);
        }

        public static string AddBaseNamePrefix(string path, string prefix)
        {
            return TransformBaseName(path, baseName => prefix + baseName);
        }

        public static string[] Split(string path)
        {
            return path.Split(Path.PathSeparator);
        }

        public static string TransformBaseName(string path, Func<string, string> transformer)
        {

            var baseName = Path.GetFileNameWithoutExtension(path);
            var segments = Split(path);
            var fileName = transformer.Invoke(baseName);
            if (Path.HasExtension(path))
            {
                fileName = fileName + '.' + Path.GetExtension(path);
            }
            segments[segments.Length - 1] = fileName;
            return Path.Combine(segments);
        }
    }
}
