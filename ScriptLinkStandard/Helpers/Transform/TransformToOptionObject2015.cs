using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms an <see cref="IOptionObject"/> to <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject2015 TransformToOptionObject2015(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject2");
            if (!IsValidErrorCode(optionObject.ErrorCode))
                throw new ArgumentException("Error Code is invalid.");
            var optionObject2015 = new OptionObject2015
            {
                EntityID = optionObject.EntityID,
                EpisodeNumber = optionObject.EpisodeNumber,
                ErrorCode = optionObject.ErrorCode,
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
        /// <summary>
        /// Transforms an <see cref="IOptionObject2"/> to <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject2"></param>
        /// <returns></returns>
        public static IOptionObject2015 TransformToOptionObject2015(IOptionObject2 optionObject2)
        {
            if (optionObject2 == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject2");
            if (!IsValidErrorCode(optionObject2.ErrorCode))
                throw new ArgumentException("Error Code is invalid.");
            var optionObject2015 = new OptionObject2015
            {
                EntityID = optionObject2.EntityID,
                EpisodeNumber = optionObject2.EpisodeNumber,
                ErrorCode = optionObject2.ErrorCode,
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
        /// <summary>
        /// Transforms a serialized string to <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="serializedString"></param>
        /// <returns></returns>
        public static IOptionObject2015 TransformToOptionObject2015(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new ArgumentNullException("Parameter cannot be empty or null", "serializedString");
            try
            {
                return DeserializeObject<OptionObject2015>(serializedString);
            }
            catch
            {
                throw new ArgumentException("Serialized string is not in a compatible format.", "serializedString");
            }
        }
    }
}
