using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool IsValidUrl(string strUrl)
        {
            return Uri.IsWellFormedUriString(strUrl, UriKind.Absolute);
        }
    }
}
