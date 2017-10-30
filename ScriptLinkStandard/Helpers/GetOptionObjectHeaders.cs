using ScriptLinkStandard.Interfaces;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static List<string> GetOptionObjectHeaders(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> headers = new List<string>
            {
                "Entity ID: " + optionObject.EntityID,
                "Episode Number: " + optionObject.EpisodeNumber,
                "Error Code: " + optionObject.ErrorCode,
                "Error Message: " + optionObject.ErrorMesg,
                "Facility: " + optionObject.Facility,
                "Option ID: " + optionObject.OptionId,
                "Option Staff ID: " + optionObject.OptionStaffId,
                "Option User ID: " + optionObject.OptionUserId,
                "System Code: " + optionObject.SystemCode
            };
            return headers;
        }
        public static List<string> GetOptionObjectHeaders(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> headers = new List<string>
            {
                "Entity ID: " + optionObject.EntityID,
                "Episode Number: " + optionObject.EpisodeNumber,
                "Error Code: " + optionObject.ErrorCode,
                "Error Message: " + optionObject.ErrorMesg,
                "Facility: " + optionObject.Facility,
                "Namespace Name: " + optionObject.NamespaceName,
                "Option ID: " + optionObject.OptionId,
                "Option Staff ID: " + optionObject.OptionStaffId,
                "Option User ID: " + optionObject.OptionUserId,
                "Parent Namepace: " + optionObject.ParentNamespace,
                "Server Name: " + optionObject.ServerName,
                "System Code: " + optionObject.SystemCode
            };
            return headers;
        }
        public static List<string> GetOptionObjectHeaders(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> headers = new List<string>
            {
                "Entity ID: " + optionObject.EntityID,
                "Episode Number: " + optionObject.EpisodeNumber,
                "Error Code: " + optionObject.ErrorCode,
                "Error Message: " + optionObject.ErrorMesg,
                "Facility: " + optionObject.Facility,
                "Namespace Name: " + optionObject.NamespaceName,
                "Option ID: " + optionObject.OptionId,
                "Option Staff ID: " + optionObject.OptionStaffId,
                "Option User ID: " + optionObject.OptionUserId,
                "Parent Namepace: " + optionObject.ParentNamespace,
                "Server Name: " + optionObject.ServerName,
                "System Code: " + optionObject.SystemCode,
                "SessionToken:" + optionObject.SessionToken
            };
            return headers;
        }
    }
}
