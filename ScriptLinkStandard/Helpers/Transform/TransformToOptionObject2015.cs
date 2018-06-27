using Newtonsoft.Json;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject2015 TransformToOptionObject2015(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null", "optionObject2");
            if (!ScriptLinkHelpers.IsValidErrorCode(optionObject.ErrorCode))
                throw new System.ArgumentException("Error Code is invalid.");
            var optionObject2015 = new OptionObject2015
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
            return optionObject2015;
        }
        public static OptionObject2015 TransformToOptionObject2015(IOptionObject2 optionObject2)
        {
            if (optionObject2 == null)
                throw new System.ArgumentException("Parameter cannot be null", "optionObject2");
            if (!ScriptLinkHelpers.IsValidErrorCode(optionObject2.ErrorCode))
                throw new System.ArgumentException("Error Code is invalid.");
            var optionObject2015 = new OptionObject2015
            {
                EntityID = optionObject2.EntityID,
                EpisodeNumber = optionObject2.EpisodeNumber,
                ErrorCode = (double)optionObject2.ErrorCode,
                ErrorMesg = optionObject2.ErrorMesg,
                Facility = optionObject2.Facility,
                NamespaceName = optionObject2.NamespaceName,
                OptionId = optionObject2.OptionId,
                OptionStaffId = optionObject2.OptionStaffId,
                OptionUserId = optionObject2.OptionUserId,
                ParentNamespace = optionObject2.ParentNamespace,
                ServerName = optionObject2.ServerName,
                SystemCode = optionObject2.SystemCode,
                Forms = optionObject2.Forms.Any() ? optionObject2.Forms : new List<FormObject>()
            };
            return optionObject2015;
        }

        public static OptionObject2015 TransformToOptionObject2015(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new System.ArgumentException("Parameter cannot be empty or null", "serializedString");
            try
            {
                OptionObject2015 optionObject = JsonConvert.DeserializeObject<OptionObject2015>(serializedString);
                return optionObject;
            }
            catch
            {
                // Not valid JSON or doesn't match the OptionObject specification
            }
            // Future implementation: XML?
            throw new System.ArgumentException("Serialized string is not in a compatible format.", "serializedString");
        }
    }
}
