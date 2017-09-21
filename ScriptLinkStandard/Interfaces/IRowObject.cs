using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Interfaces
{
    public interface IRowObject
    {
        List<FieldObject> Fields { get; set; }
        string ParentRowId { get; set; }
        string RowAction { get; set; }
        string RowId { get; set; }

        string GetFieldValue(string fieldNumber);
        bool IsFieldEnabled(string fieldNumber);
        bool IsFieldLocked(string fieldNumber);
        bool IsFieldPresent(string fieldNumber);
        bool IsFieldRequired(string fieldNumber);
        void RemoveUnmodifiedFieldObjects();
        void SetFieldValue(string fieldNumber, string fieldValue);
        string ToHtmlString(bool includeHtmlHeaders);
    }
}
