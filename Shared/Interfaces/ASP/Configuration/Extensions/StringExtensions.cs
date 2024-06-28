namespace si730pc2u202119447.API.Shared.Interfaces.ASP.Configuration.Extensions;
using System.Text.RegularExpressions;
public static partial class StringExtensions
{
    public static string ToKebabCase(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        return KebabCaseRegex().Replace(text, "-$1").Trim().ToLower();
    }

    [GeneratedRegex("(?<!ˆ)([A-Z][a-z]|(?<=[a-z])[A-Z])", RegexOptions.Compiled)]
    private static partial Regex KebabCaseRegex();
}
