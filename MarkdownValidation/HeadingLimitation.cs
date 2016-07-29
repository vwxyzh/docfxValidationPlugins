using System.Collections.Immutable;
using System.Composition;

using Microsoft.DocAsCode.Common;
using Microsoft.DocAsCode.MarkdownLite;

namespace MarkdownValidation
{
    [Export("heading_limitation", typeof(IMarkdownTokenValidatorProvider))]
    public class HeadingLimitation : IMarkdownTokenValidatorProvider
    {
        public ImmutableArray<IMarkdownTokenValidator> GetValidators()
        {
            return ImmutableArray.Create(
                MarkdownTokenValidatorFactory.FromLambda<MarkdownHeadingBlockToken>(
                    token =>
                    {
                        if (token.Depth > 4)
                        {
                            Logger.LogError("Invalid heading", line: token.SourceInfo.LineNumber.ToString());
                        }
                    }));
        }
    }
}
