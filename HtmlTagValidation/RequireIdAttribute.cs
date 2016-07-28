using System.Composition;
using System.Text.RegularExpressions;

using Microsoft.DocAsCode.Plugins;

namespace HtmlTagValidation
{
    [Export("require_id_attibute", typeof(ICustomMarkdownTagValidator))]
    public class RequireIdAttribute : ICustomMarkdownTagValidator
    {
        public bool Validate(string tag)
        {
            return Regex.IsMatch(tag, "\\bid\\s+=\\s+\\\"");
        }
    }
}
