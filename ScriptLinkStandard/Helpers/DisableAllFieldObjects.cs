using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject DisableAllFieldObjects(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject.ToOptionObject2015()).ToOptionObject();
        }
        public static IOptionObject DisableAllFieldObjects(IOptionObject optionObject, List<string> excludedFields)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject.ToOptionObject2015(), excludedFields).ToOptionObject();
        }
        public static IOptionObject2 DisableAllFieldObjects(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject.ToOptionObject2015()).ToOptionObject2();
        }
        public static IOptionObject2 DisableAllFieldObjects(IOptionObject2 optionObject, List<string> excludedFields)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject.ToOptionObject2015(), excludedFields).ToOptionObject2();
        }

        public static IOptionObject2015 DisableAllFieldObjects(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return DisableAllFieldObjects(optionObject, new List<string>());
        }

        public static IOptionObject2015 DisableAllFieldObjects(IOptionObject2015 optionObject, List<string> excludedFields)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (optionObject.Forms.Count == 0)
                throw new ArgumentException("There are no Forms.");
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (optionObject.Forms[i].CurrentRow != null)
                {
                    for (int j = 0; j < optionObject.Forms[i].CurrentRow.Fields.Count; j++)
                    {
                        if (!excludedFields.Contains(optionObject.Forms[i].CurrentRow.Fields[j].FieldNumber))
                            optionObject.Forms[i].CurrentRow.Fields[j].SetAsDisabled();
                    }
                    optionObject.Forms[i].CurrentRow.RowAction = "EDIT";
                }
                for (int k = 0; k < optionObject.Forms[i].OtherRows.Count; k++)
                {
                    for (int l = 0; l < optionObject.Forms[i].OtherRows[k].Fields.Count; l++)
                    {
                        if (!excludedFields.Contains(optionObject.Forms[i].OtherRows[k].Fields[l].FieldNumber))
                            optionObject.Forms[i].OtherRows[k].Fields[l].SetAsDisabled();
                    }
                    optionObject.Forms[i].OtherRows[k].RowAction = "EDIT";
                }
            }
            return optionObject;
        }
    }
}
