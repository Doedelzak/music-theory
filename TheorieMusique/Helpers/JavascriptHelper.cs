using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;

namespace TheorieMusique.Helpers
{
    public static class JavascriptHelper
    {
        public static HtmlString ToJs(this List<string> value, string variableName)
        {
            return new HtmlString($"var {variableName} = {JsonConvert.SerializeObject(value)};");
        }
    }
}
