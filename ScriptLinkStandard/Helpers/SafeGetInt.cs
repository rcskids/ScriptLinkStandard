namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Safely converts a string to an integer.
        /// </summary>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static int SafeGetInt(string fieldValue)
        {
            int tempValue = 0;
            if (int.TryParse(fieldValue, out _))
                tempValue = int.Parse(fieldValue);
            return tempValue;
        }
    }
}
