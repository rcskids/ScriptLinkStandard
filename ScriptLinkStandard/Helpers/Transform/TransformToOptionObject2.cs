using Newtonsoft.Json;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject2 TransformToOptionObject2(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null", "optionObject2");
            if (!ScriptLinkHelpers.IsValidErrorCode(optionObject.ErrorCode))
                throw new System.ArgumentException("Error Code is invalid.");
            var optionObject2 = new OptionObject2
            {
                EntityID = optionObject.EntityID,
                EpisodeNumber = optionObject.EpisodeNumber,
                ErrorCode = (double)optionObject.ErrorCode,
                ErrorMesg = optionObject.ErrorMesg,
                Facility = optionObject.Facility,
                OptionId = optionObject.OptionId,
                OptionStaffId = optionObject.OptionStaffId,
                OptionUserId = optionObject.OptionUserId,
                SystemCode = optionObject.SystemCode,
                Forms = optionObject.Forms.Any() ? optionObject.Forms : new List<FormObject>()
            };
            return optionObject2;
        }
        public static IOptionObject2 TransformToOptionObject2(IOptionObject2015 optionObject2015)
        {
            if (optionObject2015 == null)
                throw new System.ArgumentException("Parameter cannot be null", "optionObject2015");
            if (!ScriptLinkHelpers.IsValidErrorCode(optionObject2015.ErrorCode))
                throw new System.ArgumentException("Error Code is invalid.");
            var optionObject2 = new OptionObject2
            {
                EntityID = optionObject2015.EntityID,
                EpisodeNumber = optionObject2015.EpisodeNumber,
                ErrorCode = (double)optionObject2015.ErrorCode,
                ErrorMesg = optionObject2015.ErrorMesg,
                Facility = optionObject2015.Facility,
                NamespaceName = optionObject2015.NamespaceName,
                OptionId = optionObject2015.OptionId,
                OptionStaffId = optionObject2015.OptionStaffId,
                OptionUserId = optionObject2015.OptionUserId,
                ParentNamespace = optionObject2015.ParentNamespace,
                ServerName = optionObject2015.ServerName,
                SystemCode = optionObject2015.SystemCode,
                Forms = optionObject2015.Forms.Any() ? optionObject2015.Forms : new List<FormObject>()
            };
            return optionObject2;
        }

        public static IOptionObject2 TransformToOptionObject2(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new System.ArgumentException("Parameter cannot be empty or null", "serializedString");
            try
            {
                OptionObject2 optionObject = JsonConvert.DeserializeObject<OptionObject2>(serializedString);
                return optionObject;
            }
            catch
            {
                // Not valid JSON or doesn't match the OptionObject2 specification
            }
            // Future implementation: XML?
            throw new System.ArgumentException("Serialized string is not in a compatible format.", "serializedString");
        }
    }
}
