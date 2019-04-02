namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a given ErrorCode is valid
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public static bool IsValidErrorCode(string errorCode)
        {
            if (int.TryParse(errorCode, out int convertedErrorCode))
                return IsValidErrorCode(convertedErrorCode);
            return false;
        }
        /// <summary>
        /// Returns whether a given ErrorCode is valid
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public static bool IsValidErrorCode(double errorCode)
        {
            if (errorCode >= 0 && errorCode <= 6)
                return true;
            return false;
        }
    }
}
