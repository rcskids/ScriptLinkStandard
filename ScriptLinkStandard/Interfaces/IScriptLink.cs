using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Interfaces
{
    public interface IScriptLink
    {
        string GetVersion();
        OptionObject ProcessScript(IOptionObject optionObject, string parameter);
        OptionObject2 ProcessScript(IOptionObject2 optionObject, string parameter);
        OptionObject2015 ProcessScript(IOptionObject2015 optionObject, string parameter);
    }
}