using System.Collections.Generic;

namespace Ayte.GitHub.Steward.Skeleton
{
    public struct SourceFileCollection
    {
        public Dictionary<string, string> Mapping;
        public readonly Meta Metadata;

        public SourceFileCollection(Dictionary<string, string> mapping, Meta metadata)
        {
            Mapping = mapping;
            Metadata = metadata;
        }
        
        public struct Meta
        {
            public readonly ConflictResolutionStrategy ConflictResolutionStrategy;
            public readonly MetadataDefaults Defaults;

            public Meta(ConflictResolutionStrategy conflictResolutionStrategy, MetadataDefaults defaults)
            {
                ConflictResolutionStrategy = conflictResolutionStrategy;
                Defaults = defaults;
            }
            
            public struct MetadataDefaults
            {
                public readonly bool Included;
                public readonly string[] Variants;

                public MetadataDefaults(bool included, string[] variants)
                {
                    Included = included;
                    Variants = variants;
                }
            }
        }
    }
}
