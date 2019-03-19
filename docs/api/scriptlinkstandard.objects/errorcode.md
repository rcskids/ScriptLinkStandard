---
theme: cayman
layout: default
title: ErrorCode Class
---

# ErrorCode

Namespace: [ScriptLinkStandard.Objects](./)

Assemblies: ScriptLinkStandard.dll

Defines the ErrorCode class.

``` c#
public class ErrorCode
```

## Examples

The example below shows the use of ErrorCode.Info to display an informational "Hello, World!" message to user.

```c#
public class ScriptLinkController : System.Web.Services.WebService
{
    [WebMethod]
    public string GetVersion()
    {
        return "v.0.0.1";
    }

    [WebMethod]
    public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string parameters)
    {
        return optionObject2015.ToReturnOptionObject(ErrorCode.Info, "Hello, World!");
    }
}
```

## Properties

| Properties | Code | Description |
|:-----------|:-----|:------------|
| None | 0 | Returns no message. This is the equivalent of a successful return. |
| Error | 1 | Returns provided message with an Ok button. Stops script processing. |
| OkCancel | 2 | Returns provided message with Ok and Cancel buttons. Stops script processing, if Cancel is selected. |
| Info | 3 | Returns provided message with an Ok button. |
| YesNo | 4 | Returns provided message with Yes and No buttons. Stops script processing, if No is selected. |
| OpenUrl | 5 | Opens provided Url in default web browser. |
| OpenForm | 6 | Returns a message with Ok and Cancel buttons. Opens specified form(s) if OK selected. Can only be used at Form Load and on Field events. |

## See Also

* [OptionObject](./optionobject.md)
* [OptionObject2](./optionobject2.md)
* [OptionObject2015](./optionobject2015.md)
