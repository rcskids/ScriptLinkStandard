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

        FormObject Clone();

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

        void SetDisabledField(string fieldNumber);
        void SetDisabledFields(List<string> fieldNumbers);
        void SetFieldValue(string fieldNumber, string fieldValue);
        void SetFieldValue(string rowId, string fieldNumber, string fieldValue);
        void SetLockedField(string fieldNumber);
        void SetLockedFields(List<string> fieldNumbers);
        void SetOptionalField(string fieldNumber);
        void SetOptionalFields(List<string> fieldNumbers);
        void SetRequiredField(string fieldNumber);
        void SetRequiredFields(List<string> fieldNumbers);
        void SetUnlockedField(string fieldNumber);
        void SetUnlockedFields(List<string> fieldNumbers);

        string ToHtmlString(bool includeHtmlHeaders);
        string ToJson();
    }
}
