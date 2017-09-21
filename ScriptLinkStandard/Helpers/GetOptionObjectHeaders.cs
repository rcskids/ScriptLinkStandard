using ScriptLinkStandard.Interfaces;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static List<string> GetOptionObjectHeaders(IOptionObject optionObject)
        {
            List<string> headers = new List<string>();
            headers.Add("Entity ID: " + optionObject.EntityID);
            headers.Add("Episode Number: " + optionObject.EpisodeNumber);
            headers.Add("Error Code: " + optionObject.ErrorCode);
            headers.Add("Error Message: " + optionObject.ErrorMesg);
            headers.Add("Facility: " + optionObject.Facility);
            headers.Add("Option ID: " + optionObject.OptionId);
            headers.Add("Option Staff ID: " + optionObject.OptionStaffId);
            headers.Add("Option User ID: " + optionObject.OptionUserId);
            headers.Add("System Code: " + optionObject.SystemCode);
            return headers;
        }
        public static List<string> GetOptionObjectHeaders(IOptionObject2 optionObject)
        {
            List<string> headers = new List<string>();
            headers.Add("Entity ID: " + optionObject.EntityID);
            headers.Add("Episode Number: " + optionObject.EpisodeNumber);
            headers.Add("Error Code: " + optionObject.ErrorCode);
            headers.Add("Error Message: " + optionObject.ErrorMesg);
            headers.Add("Facility: " + optionObject.Facility);
            headers.Add("Name Space Name: " + optionObject.NamespaceName);
            headers.Add("Option ID: " + optionObject.OptionId);
            headers.Add("Option Staff ID: " + optionObject.OptionStaffId);
            headers.Add("Option User ID: " + optionObject.OptionUserId);
            headers.Add("Parent Namepace: " + optionObject.ParentNamespace);
            headers.Add("Server Name: " + optionObject.ServerName);
            headers.Add("System Code: " + optionObject.SystemCode);
            return headers;
        }
    }
}
