using System.Composition;
using System.Text.RegularExpressions;

using Microsoft.DocAsCode.Plugins;

namespace HtmlTagValidation
{
    [Export("require_class_attibute", typeof(ICustomMarkdownTagValidator))]
    public class RequireClassAttribute : ICustomMarkdownTagValidator
    {
        public bool Validate(string tag)
        {
            return Regex.IsMatch(tag, "\\bclass\\s+=\\s+\\\"");
        }
    }
}
