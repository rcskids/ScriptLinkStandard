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
        void SetFieldValue(string fieldNumber, string fieldValue);
        string ToHtmlString(bool includeHtmlHeaders);
    }
}
