namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Used to parse the received parameter.
        /// </summary>
        /// <param name="delimitedParameter"></param>
        /// <returns></returns>
        public static string[] SplitDelimitedParameter(string delimitedParameter)
        {
            string[] splitString = SplitDelimitedParameter(delimitedParameter, ',');
            return splitString;
        }
        /// <summary>
        /// Used to parse the received parameter based on provided delimiter.
        /// </summary>
        /// <param name="delimitedParameter"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string[] SplitDelimitedParameter(string delimitedParameter, char delimiter)
        {
            string[] splitString = delimitedParameter.Split(delimiter);
            return splitString;
        }
    }
}
