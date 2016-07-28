using System.Collections.Immutable;
using System.Composition;

using Microsoft.DocAsCode.Common;
using Microsoft.DocAsCode.Plugins;

namespace MetadataValidation
{
    [Export(typeof(IInputMetadataValidator))]
    public class WeDoNotCareMood : IInputMetadataValidator
    {
        public void Validate(string sourceFile, ImmutableDictionary<string, object> metadata)
        {
            if (metadata.ContainsKey("mood"))
            {
                Logger.LogWarning("We don't care mood!", file: sourceFile);
            }
        }
    }
}
