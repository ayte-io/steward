using System;
using System.Collections.Generic;
using System.Linq;
using Ayte.GitHub.Steward.Core.Utility;

namespace Ayte.GitHub.Steward.Skeleton
{
    public enum ConflictResolutionStrategy
    {
        Concatenate,
        Suffix,
        Prefix,
        UseFirst,
        UseLast,
        Restrict
    }
    
    public static class ConflictResolutionStrategyMethods
    {
        public static IEnumerable<RenderedFile> Resolve(
            this ConflictResolutionStrategy strategy, 
            IList<RenderedFile> files
        )
        {
            if (files.Count == 0)
            {
                return files;
            }
            switch (strategy)
            {
                case ConflictResolutionStrategy.Concatenate:
                    var target = new RenderedFile();
                    var content = files.Aggregate("", (carrier, file) => carrier + file.Content);
                    target.Path = files[0].Path;
                    target.Content = content;
                    return Enumerables.Single(target);
                case ConflictResolutionStrategy.Suffix:
                    return files.Select(file => file.WithPath(Paths.AddBaseNameSuffix(file.Path, file.Discriminator)));
                case ConflictResolutionStrategy.Prefix:
                    return files.Select(file => file.WithPath(Paths.AddBaseNamePrefix(file.Path, file.Discriminator)));
                case ConflictResolutionStrategy.UseFirst:
                    return Enumerables.Single(files[0]);
                case ConflictResolutionStrategy.UseLast:
                    return Enumerables.Single(files[files.Count - 1]);
                case ConflictResolutionStrategy.Restrict:
                    throw new RestrictionException("Got several produced files, while expected only one: " + files);
                default:
                    throw new Exception("Whoops, somebody has forgotten to add processing for strategy " + strategy);
            }
        }
    }

    public class RestrictionException : Exception
    {
        public RestrictionException(string message) : base(message)
        {
            
        }
    }
}