using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Interfaces
{
    public interface IOptionObject
    {
        string EntityID { get; set; }
        double EpisodeNumber { get; set; }
        double ErrorCode { get; set; }
        string ErrorMesg { get; set; }
        string Facility { get; set; }
        List<FormObject> Forms { get; set; }
        string OptionId { get; set; }
        string OptionStaffId { get; set; }
        string OptionUserId { get; set; }
        string SystemCode { get; set; }

        void AddFormObject(FormObject formObject);
        void AddFormObject(string formId, bool multipleIteration);
        void AddRowObject(string formId, RowObject rowObject);
        OptionObject Clone();
        void DeleteRowObject(RowObject rowObject);
        void DeleteRowObject(string rowId);
        void DisableAllFieldObjects();
        void DisableAllFieldObjects(List<string> excludedFieldObjects);
        string GetCurrentRowId(string formId);
        string GetFieldValue(string fieldNumber);
        string GetFieldValue(string formId, string rowId, string fieldNumber);
        List<string> GetFieldValues(string fieldNumber);
        bool GetMultipleIterationStatus(string formId);
        string GetParentRowId(string formId);
        
        bool IsFieldEnabled(string fieldNumber);
        bool IsFieldLocked(string fieldNumber);
        bool IsFieldPresent(string fieldNumber);
        bool IsFieldRequired(string fieldNumber);
        bool IsFormPresent(string formId);
        bool IsRowMarkedForDeletion(string rowId);
        bool IsRowPresent(string rowId);

        void SetDisabledField(string fieldNumber);
        void SetDisabledFields(List<string> fieldNumbers);
        void SetFieldValue(string fieldNumber, string fieldValue);
        void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue);
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
        OptionObject2 ToOptionObject2();
        OptionObject2015 ToOptionObject2015();
        OptionObject ToReturnOptionObject();
        OptionObject ToReturnOptionObject(int errorCode, string errorMessage);
        string ToXml();
    }
}
