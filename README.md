# ScriptLinkStandard

ScriptLinkStandard is a Class Library designed to assist developers in creating SOAP web services that can be consumed by Netsmart's myAvatar solution using ScriptLink.

This library is written for [.NET Standard 1.1](https://docs.microsoft.com/en-us/dotnet/standard/net-standard). Subject to change prior to release.

## Contents
* [Installation](https://github.com/rcskids/ScriptLinkStandard#installation)
* [Documentation](https://github.com/rcskids/ScriptLinkStandard#documentation)
* [Contributing](https://github.com/rcskids/ScriptLinkStandard#contributing)
* [Creators](https://github.com/rcskids/ScriptLinkStandard#creators)
* [Copyright and license](https://github.com/rcskids/ScriptLinkStandard#copyright-and-license)

## Installation

### NuGet
The goal of this project is to make the library available in NuGet for easy install and update. This will be available upon release.

### Manual Installation
1. Download the [latest release](https://github.com/rcskids/ScriptLinkStandard/releases).
2. Extract the compressed file.
3. Open your solution in Visual Studio.
4. For each project in the solution that will use the library (e.g., your web app and unit test projects)
	1. Select Project > Add Reference... from the menu bar (or right-click on the project and select Add > Reference...).
	2. In the Reference Manager, select Browse...
	3. Navigate the location of the ScriptLinkStandard.dll that you just extracted.
	4. Select the ScriptLinkStandard.dll file and click Add.
	5. Select OK.
5. You can now reference the ScriptLinkStandard library throughout your project with `@using` tags.

```c#
@using ScriptLinkStandard.Helpers
@using ScriptLinkStandard.Interfaces
@using ScriptLinkStandard.Objects
```

## Documentation

### Compatibility
Initial testing has been completed demonstrating compatibility of the library with various .NET implementations.

.NET Framework | Compatible
-------------- | ----------
4.6.2 | Untested
4.6.1 | Yes
4.6 | Yes
4.5.2 | Yes
4.5.1 | Yes
4.5 | Yes

Check out the Microsoft Docs for more information on [.NET Standard compatibility](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

ScriptLink APIs based on ScriptLinkStandard can be run on Windows Server 2008 or later. More information can be found on [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/framework/get-started/system-requirements).

### ScriptLinkStandard.Objects
The ScriptLinkStandard.Objects namespace contains the object definitions and will be the most commonly used namespace in your projects.

The objects include:
* OptionObject2015
* OptionObject2 (legacy)
* OptionObject (legacy)
* FormObject
* RowObject
* FieldObject

Each object includes a variety of methods designed to help manage or modify the received OptionObject, OptionObject2, or OptionObject2015. For example,
* To get a FieldValue from an OptionObject without Multiple Iteration tables, you can write `string value = optionObject.GetFieldValue(fieldNumber);`.
* To set a FieldValue in an OptionObject without Multiple Iteration tables, you can write `optionObject.SetFieldValue(fieldNumber, fieldValue);`.
* To set a FieldObject as Required in an OptionObject, you can write `optionObject.SetRequiredFields(fieldNumbers);` using a List<string> containing the FieldNumber(s) to require. This also works for enabling, disabling, locking, and unlocking.
* Using the above method to set the values or other properties of a FieldObject automatically marks the RowObject as edited. This allows you to write `return optionObject.ToReturnOptionObject();` return only the modified contents of the OptionObject.
* To create the returning OptionObject with an ErrorCode and ErrorMesg, you can use `return optionObject.ToReturnOptionObject(errorCode, errorMessage);`.

### ScriptLinkStandard.Helpers
The ScriptLinkStandard.Helpers namespace contains a number of common methods used when handling OptionObjects. Many of these helpers are already available on the objects, but some conditions may require the helper instead. Here are some examples of the helpers:
* To get the FieldValue from an OptionObject without Multiple Iteration tables, you can write `string value = ScriptLinkHelpers.GetFieldValue(fieldNumber);`.
* To get all the FieldValues from a Multiple Iteration tables, you can write `List<string> values = ScriptLinkHelpers.GetFieldValues(fieldNumber);`.
* To safely get an integer from the provided OptionObject, you can write `int value = ScriptLinkHelpers.SafeGetInt(optionObject.GetFieldValue(fieldNumber));`.
* To verify an Error Code is valid, you can write `bool isValid = ScriptLinkHelpers.IsValidErrorCode(errorcode);`.

### ScriptLinkStandard.Interfaces
The ScriptLinkStandard.Interfaces namespace contains the interfaces used to govern the relationship between the objects and the helpers. These would typically be used in more advanced scenarios and typical usage would not require use of this namespace.

#### Custom Objects
One of the advanced uses of this namespace would be to create your own objects that work with the ScriptLinkHelpers.

```c#
public class CustomOptionObject2015 : IOptionObject2015
{
	// Your implementation
}
```

#### Separating the API Interface from the Logic
Another interface has been created to inform the construction of the APIs and the supporting logic. Here is a HelloWorld example.

**HelloWorld.asmx.cs**
```c#
public class HelloWorld : System.Web.Services.WebService
{
    HelloWorldScript script = new HelloWorldScript();

    [WebMethod]
    public string GetVersion()
    {
        return script.GetVersion();
    }

    [WebMethod]
    public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string parameters)
    {
        return script.ProcessScript(optionObject2015, parameters);
    }
}
```

**HelloWorldScript.cs**
```c#
public class HelloWorldScript : IScriptLink
{
    public string GetVersion()
    {
        return "1.0.0";
    }

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
        return optionObject.ToReturnOptionObject(3, "Hello World!");
    }
}
```

By design, the IScriptLink interface requires you to account for both the legacy OptionObject and OptionObject2 as well as the current OptionObject2015. In the example above, the legacy OptionObject and OptionObject2 are converted to an OptionObject2015 and handled by the OptionObject2015 logic to minimize duplicate code. This code design could still be done without the interface allowing you to write for only the OptionObject type you prefer to use.

## Contributing
To be written

## Creators
Scott Olson Jr
* https://twitter.com/scottolsonjr
* https://github.com/scottolsonjr

Luis Quicano
* https://github.com/luivis07

## Copyright and license
[myAvatar](https://www.ntst.com/Solutions-We-Offer/products/myavatar.aspx) is a trademark of [Netsmart Technologies, Inc.](http://www.ntst.com)

ScriptLinkStandard is released under the [MIT License](https://github.com/rcskids/ScriptLinkStandard/blob/master/LICENSE.md).
