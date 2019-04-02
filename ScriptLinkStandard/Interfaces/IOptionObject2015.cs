using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Interfaces
{
    public interface IOptionObject2015
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
        string SessionToken { get; set; }

        void AddFormObject(FormObject formObject);
        void AddFormObject(string formId, bool multipleIteration);
        void AddRowObject(string formId, RowObject rowObject);
        OptionObject2015 Clone();
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
        OptionObject ToOptionObject();
        OptionObject2 ToOptionObject2();
        OptionObject2015 ToReturnOptionObject();
        OptionObject2015 ToReturnOptionObject(int errorCode, string errorMessage);
        string ToXml();
    }
}
