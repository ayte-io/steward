namespace Ayte.GitHub.Steward.Skeleton
{
    public struct SourceFile
    {
        public readonly string[] Identifiers;
        public readonly string Path;
        public readonly string Discriminator;
        public readonly string Content;

        public SourceFile(string[] identifiers, string path, string discriminator, string content)
        {
            Identifiers = identifiers;
            Path = path;
            Discriminator = discriminator;
            Content = content;
        }
    }
}
