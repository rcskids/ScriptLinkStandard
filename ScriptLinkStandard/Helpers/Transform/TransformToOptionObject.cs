using Newtonsoft.Json;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject TransformToOptionObject(IOptionObject2 optionObject2)
        {
            if (optionObject2 == null)
                throw new System.ArgumentException("Parameter cannot be null", "optionObject2");
            if (!ScriptLinkHelpers.IsValidErrorCode(optionObject2.ErrorCode))
                throw new System.ArgumentException("Error Code is invalid.");
            var optionObject = new OptionObject
            {
                EntityID = optionObject2.EntityID,
                EpisodeNumber = optionObject2.EpisodeNumber,
                ErrorCode = (double)optionObject2.ErrorCode,
                ErrorMesg = optionObject2.ErrorMesg,
                Facility = optionObject2.Facility,
                OptionId = optionObject2.OptionId,
                OptionStaffId = optionObject2.OptionStaffId,
                OptionUserId = optionObject2.OptionUserId,
                SystemCode = optionObject2.SystemCode,
                Forms = optionObject2.Forms.Any() ? optionObject2.Forms : new List<FormObject>()
            };
            return optionObject;
        }
        public static IOptionObject TransformToOptionObject(IOptionObject2015 optionObject2015)
        {
            if (optionObject2015 == null)
                throw new System.ArgumentException("Parameter cannot be null", "optionObject2015");
            if (!ScriptLinkHelpers.IsValidErrorCode(optionObject2015.ErrorCode))
                throw new System.ArgumentException("Error Code is invalid.");
            var optionObject = new OptionObject
            {
                EntityID = optionObject2015.EntityID,
                EpisodeNumber = optionObject2015.EpisodeNumber,
                ErrorCode = (double)optionObject2015.ErrorCode,
                ErrorMesg = optionObject2015.ErrorMesg,
                Facility = optionObject2015.Facility,
                OptionId = optionObject2015.OptionId,
                OptionStaffId = optionObject2015.OptionStaffId,
                OptionUserId = optionObject2015.OptionUserId,
                SystemCode = optionObject2015.SystemCode,
                Forms = optionObject2015.Forms.Any() ? optionObject2015.Forms : new List<FormObject>()
            };
            return optionObject;
        }

        public static IOptionObject TransformToOptionObject(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new System.ArgumentException("Parameter cannot be empty or null", "serializedString");
            try
            {
                OptionObject optionObject = JsonConvert.DeserializeObject<OptionObject>(serializedString);
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
