---
theme: cayman
layout: default
title: IScriptLink Interface
---

# IScriptLink Interface

Namespace: ScriptLinkStandard.Interfaces

Assemblies: ScriptLinkStandard.dll

Exposes an object that supports the creation of backwards compatible ScriptLink APIs.

```c#
public interface IScriptLink
```

## Example

The following example shows how to create a master class to handle a request using any OptionObject format.

### Shared Logic Class

With this shared class you replicate your existing logic in a shared class that can be unit tested and prepped for newer OptionObject versions.

```c#
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkDemo.Logic
{
    public class HelloWorldApiLogic : IScriptLink
    {
        public OptionObject ProcessScript(IOptionObject optionObject, string parameter)
        {
            return ProcessScript(optionObject.ToOptionObject2015(), parameter).ToOptionObject();
        }

        public OptionObject2 ProcessScript(IOptionObject2 optionObject, string parameter)
        {
            return ProcessScript(optionObject.ToOptionObject2015(), parameter).ToOptionObject2();
        }

        public OptionObject2015 ProcessScript(IOptionObject2015 optionObject, string parameter)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Info, "Hello, World!");
        }
    }
}
```

### Existing OptionObject API

Point your existing web service to the shared class to prepare for future update from OptionObject to OptionObject2015.

```c#
using ScriptLinkDemo.Logic;
using ScriptLinkStandard.Objects;
using System.Web.Services;

namespace ScriptLinkDemo.Api.v1
{
    /// <summary>
    /// Summary description for HelloWorldApi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HelloWorldApi : System.Web.Services.WebService
    {
        private HelloWorldApiLogic controller = new HelloWorldApiLogic();

        [WebMethod]
        public string GetVersion()
        {
            return "v.1.0.0";
        }

        [WebMethod]
        public OptionObject RunScript(OptionObject optionObject, string parameter)
        {
            return controller.ProcessScript(optionObject, parameter);
        }
    }
}
```

### New OptionObject2015 API

Now you can create the new web service and WSDL for the OptionObject2015 object and deploy whenever ready.

```c#
using ScriptLinkDemo.Logic;
using ScriptLinkStandard.Objects;
using System.Web.Services;

namespace ScriptLinkDemo.Api.v3
{
    /// <summary>
    /// Summary description for HelloWorldApi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HelloWorldApi : System.Web.Services.WebService
    {
        private HelloWorldApiLogic controller = new HelloWorldApiLogic();

        [WebMethod]
        public string GetVersion()
        {
            return "v.3.0.0";
        }

        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
        {
            return controller.ProcessScript(optionObject, parameter);
        }
    }
}
```
