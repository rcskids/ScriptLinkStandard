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
        void DeleteRowObject(RowObject rowObject);
        void DeleteRowObject(string rowId);
        string GetCurrentRowId();
        string GetFieldValue(string fieldNumber);
        string GetFieldValue(string rowId, string fieldNumber);
        List<string> GetFieldValues(string fieldNumber);
        string GetNextAvailableRowId();
        string GetParentRowId();
        bool IsFieldEnabled(string fieldNumber);
        bool IsFieldLocked(string fieldNumber);
        bool IsFieldPresent(string fieldNumber);
        bool IsFieldRequired(string fieldNumber);
        void SetDisabledFields(List<string> fieldNumbers);
        void SetDisabledFields(string fieldNumber);
        void SetFieldValue(string fieldNumber, string fieldValue);
        void SetFieldValue(string rowId, string fieldNumber, string fieldValue);
        void SetLockedFields(List<string> fieldNumbers);
        void SetLockedFields(string fieldNumber);
        void SetOptionalFields(List<string> fieldNumbers);
        void SetOptionalFields(string fieldNumber);
        void SetRequiredFields(List<string> fieldNumbers);
        void SetRequiredFields(string fieldNumber);
        void SetUnlockedFields(List<string> fieldNumbers);
        void SetUnlockedFields(string fieldNumber);
        string ToHtmlString(bool includeHtmlHeaders);
    }
}
