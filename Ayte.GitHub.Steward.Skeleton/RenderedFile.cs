namespace Ayte.GitHub.Steward.Skeleton
{
    public struct RenderedFile
    {
        public string Path;
        public string Discriminator;
        public string Content;

        public RenderedFile WithPath(string path)
        {
            var target = this;
            target.Path = path;
            return target;
        }
    }
}
