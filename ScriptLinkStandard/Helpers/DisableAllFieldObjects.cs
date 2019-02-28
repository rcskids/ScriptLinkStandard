using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Sets all <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> to disabled.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject DisableAllFieldObjects(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject.ToOptionObject2015()).ToOptionObject();
        }
        /// <summary>
        /// Sets all <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> to disabled, except for the FieldNumbers specified in List.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="excludedFields"></param>
        /// <returns></returns>
        public static IOptionObject DisableAllFieldObjects(IOptionObject optionObject, List<string> excludedFields)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject.ToOptionObject2015(), excludedFields).ToOptionObject();
        }
        /// <summary>
        /// Sets all <see cref="IFieldObject"/> in the <see cref="IOptionObject2"/> to disabled.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject2 DisableAllFieldObjects(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject.ToOptionObject2015()).ToOptionObject2();
        }
        /// <summary>
        /// Sets all <see cref="IFieldObject"/> in the <see cref="IOptionObject2"/> to disabled, except for the FieldNumbers specified in List.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="excludedFields"></param>
        /// <returns></returns>
        public static IOptionObject2 DisableAllFieldObjects(IOptionObject2 optionObject, List<string> excludedFields)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject.ToOptionObject2015(), excludedFields).ToOptionObject2();
        }
        /// <summary>
        /// Sets all <see cref="IFieldObject"/> in the <see cref="IOptionObject2015"/> to disabled.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject2015 DisableAllFieldObjects(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject, new List<string>());
        }
        /// <summary>
        /// Sets all <see cref="IFieldObject"/> in the <see cref="IOptionObject2015"/> to disabled, except for the FieldNumbers specified in List.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="excludedFields"></param>
        /// <returns></returns>
        public static IOptionObject2015 DisableAllFieldObjects(IOptionObject2015 optionObject, List<string> excludedFields)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (optionObject.Forms.Count == 0)
                throw new NullReferenceException("There are no Forms.");
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (optionObject.Forms[i].CurrentRow != null)
                {
                    for (int j = 0; j < optionObject.Forms[i].CurrentRow.Fields.Count; j++)
                    {
                        if (!excludedFields.Contains(optionObject.Forms[i].CurrentRow.Fields[j].FieldNumber))
                            optionObject.Forms[i].CurrentRow.Fields[j].SetAsDisabled();
                    }
                    optionObject.Forms[i].CurrentRow.RowAction = RowAction.Edit;
                }
                for (int k = 0; k < optionObject.Forms[i].OtherRows.Count; k++)
                {
                    for (int l = 0; l < optionObject.Forms[i].OtherRows[k].Fields.Count; l++)
                    {
                        if (!excludedFields.Contains(optionObject.Forms[i].OtherRows[k].Fields[l].FieldNumber))
                            optionObject.Forms[i].OtherRows[k].Fields[l].SetAsDisabled();
                    }
                    optionObject.Forms[i].OtherRows[k].RowAction = RowAction.Edit;
                }
            }
            return optionObject;
        }
    }
}
