using System.Text.RegularExpressions;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a given string is a valid OpenForm string.
        /// </summary>
        /// <param name="openFormString"></param>
        /// <returns></returns>
        public static bool IsValidOpenFormString(string openFormString)
        {
            if (openFormString == null || openFormString == "")
                return false;
            string pattern = @"^((\s*)\[(PM|CWS|MSO)\][A-Z]+[0-9]+)((\s*)&(\s*)\[(PM|CWS|MSO)\][A-Z]+[0-9]+)*((\s*)\|(\s*)([^\|\t\n\r])*)?((\s*)\|(\s*)\d+)?((\s*)\|(\s*)([1-9][0-9]*)+|(\s*)\|(\s*))?$";
            if (Regex.IsMatch(openFormString, pattern))
                return true;
            return false;
        }
    }
}
