using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Interfaces
{
    public interface IFormObject
    {
        RowObject CurrentRow { get; set; }
        string FormId { get; set; }
        bool MultipleIteration { get; set; }
        List<RowObject> OtherRows { get; set; }

        void AddRowObject(RowObject rowObject);
        void AddRowObject(string rowId, string parentRowId);
        void AddRowObject(string rowId, string parentRowId, string rowAction);
        string GetCurrentRowId();
        string GetFieldValue(string fieldNumber);
        string GetFieldValue(string rowId, string fieldNumber);
        List<string> GetFieldValues(string fieldNumber);
        string GetParentRowId();
        bool IsFieldEnabled(string fieldNumber);
        bool IsFieldLocked(string fieldNumber);
        bool IsFieldPresent(string fieldNumber);
        bool IsFieldRequired(string fieldNumber);
        void SetFieldValue(string fieldNumber, string fieldValue);
        void SetFieldValue(string rowId, string fieldNumber, string fieldValue);
        string ToHtmlString(bool includeHtmlHeaders);
    }
}
