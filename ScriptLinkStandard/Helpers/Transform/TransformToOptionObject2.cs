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
        /// Transforms an <see cref="IOptionObject"/> to <see cref="IOptionObject2"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject2 TransformToOptionObject2(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject2");
            if (!IsValidErrorCode(optionObject.ErrorCode))
                throw new ArgumentException("Error Code is invalid.");
            var optionObject2 = new OptionObject2
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
            return optionObject2;
        }
        /// <summary>
        /// Transforms an <see cref="IOptionObject2015"/> to <see cref="IOptionObject2"/>.
        /// </summary>
        /// <param name="optionObject2015"></param>
        /// <returns></returns>
        public static IOptionObject2 TransformToOptionObject2(IOptionObject2015 optionObject2015)
        {
            if (optionObject2015 == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject2015");
            if (!IsValidErrorCode(optionObject2015.ErrorCode))
                throw new ArgumentException("Error Code is invalid.");
            var optionObject2 = new OptionObject2
            {
                EntityID = optionObject2015.EntityID,
                EpisodeNumber = optionObject2015.EpisodeNumber,
                ErrorCode = optionObject2015.ErrorCode,
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
        /// <summary>
        /// Transforms a serialized string to <see cref="IOptionObject2"/>.
        /// </summary>
        /// <param name="serializedString"></param>
        /// <returns></returns>
        public static IOptionObject2 TransformToOptionObject2(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new ArgumentNullException("Parameter cannot be empty or null", "serializedString");
            try
            {
                return DeserializeObject<OptionObject2>(serializedString);
            }
            catch
            {
                throw new ArgumentException("Serialized string is not in a compatible format.", "serializedString");
            }
        }
    }
}
