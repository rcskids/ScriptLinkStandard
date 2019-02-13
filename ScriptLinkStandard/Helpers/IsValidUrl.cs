using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a string is a valid URL for use with error code 5.
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public static bool IsValidUrl(string strUrl)
        {
            return Uri.IsWellFormedUriString(strUrl, UriKind.Absolute);
        }
    }
}
