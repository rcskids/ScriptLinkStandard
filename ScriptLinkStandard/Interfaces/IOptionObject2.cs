using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Interfaces
{
    public interface IOptionObject2
    {
        string EntityID { get; set; }
        double EpisodeNumber { get; set; }
        double ErrorCode { get; set; }
        string ErrorMesg { get; set; }
        string Facility { get; set; }
        List<FormObject> Forms { get; set; }
        string NamespaceName { get; set; }
        string OptionId { get; set; }
        string OptionStaffId { get; set; }
        string OptionUserId { get; set; }
        string ParentNamespace { get; set; }
        string ServerName { get; set; }
        string SystemCode { get; set; }

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

        void SetDisabledFields(List<string> fieldNumbers);
        void SetFieldValue(string fieldNumber, string fieldValue);
        void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue);
        void SetLockedFields(List<string> fieldNumbers);
        void SetOptionalFields(List<string> fieldNumbers);
        void SetRequiredFields(List<string> fieldNumbers);
        void SetUnlockedFields(List<string> fieldNumbers);
        
        string ToHtmlString(bool includeHtmlHeaders);
        OptionObject ToOptionObject();
        OptionObject2 ToReturnOptionObject();
        OptionObject2 ToReturnOptionObject(int errorCode, string errorMessage);
    }
}
