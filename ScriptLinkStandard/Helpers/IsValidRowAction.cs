namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a supplied RowAction value is valid.
        /// </summary>
        /// <param name="rowAction"></param>
        /// <returns></returns>
        public static bool IsValidRowAction(string rowAction)
        {
            if (rowAction == "" ||
                rowAction == "ADD" ||
                rowAction == "DELETE" ||
                rowAction == "EDIT")
                return true;
            return false;
        }
    }
}
