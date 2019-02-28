using ScriptLinkStandard.Objects;

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
            if (rowAction == RowAction.Add ||
                rowAction == RowAction.Delete ||
                rowAction == RowAction.Edit ||
                rowAction == RowAction.None)
                return true;
            return false;
        }
    }
}
