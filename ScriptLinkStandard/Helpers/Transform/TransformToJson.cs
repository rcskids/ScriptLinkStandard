using Newtonsoft.Json;
using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static string TransformToJson(IOptionObject optionObject)
        {
            return JsonConvert.SerializeObject(optionObject);
        }

        public static string TransformToJson(IOptionObject2 optionObject)
        {
            return JsonConvert.SerializeObject(optionObject);
        }

        public static string TransformToJson(IOptionObject2015 optionObject)
        {
            return JsonConvert.SerializeObject(optionObject);
        }
    }
}
