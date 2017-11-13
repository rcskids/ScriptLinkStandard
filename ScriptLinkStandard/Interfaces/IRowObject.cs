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

        void AddFieldObject(FieldObject fieldObject);
        void AddFieldObject(string fieldNumber, string fieldValue);
        void AddFieldObject(string fieldNumber, string fieldValue, string enabledValue, string lockedValue, string requiredValue);
        void AddFieldObject(string fieldNumber, string fieldValue, bool enabled, bool locked, bool required);
        string GetFieldValue(string fieldNumber);
        bool IsFieldEnabled(string fieldNumber);
        bool IsFieldLocked(string fieldNumber);
        bool IsFieldPresent(string fieldNumber);
        bool IsFieldRequired(string fieldNumber);
        void RemoveFieldObject(FieldObject fieldObject);
        void RemoveFieldObject(string fieldNumber);
        void RemoveUnmodifiedFieldObjects();
        void SetDisabledFields(List<string> fieldNumbers);
        void SetDisabledFields(string fieldNumber);
        void SetFieldValue(string fieldNumber, string fieldValue);
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
