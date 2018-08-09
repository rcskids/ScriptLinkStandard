---
theme: cayman
layout: default
title: OptionObject2015 Class
---

# OptionObject2015

Namespace: [ScriptLinkStandard.Objects](./)

Assemblies: ScriptLinkStandard.dll

Defines the web service contract for use with myAvatar ScriptLink. Provides methods creating, manipulating, and searching OptionObject2015 objects.

```c#
public class OptionObject2015 : IEquatable<OptionObject2015>, IOptionObject2015
```

Implements [IEquatable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1), [IOptionObject2015](/docs/api/scriptlinkstandard.interfaces/ioptionobject2015.md)

## Examples

The following code shows how to use OptionObject2015 to construct a web service compatible with myAvatar.

```c#
using ScriptLinkStandard.Objects;
using System.Web.Services;

namespace ScriptLinkDemo.Web.Api
{
    /// <summary>
    /// Summary description for ScriptLinkController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
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
            return optionObject2015.ToReturnOptionObject(3, "Hello, World!");
        }
    }
}
```

## Remarks

OptionObject2015 is the latest definition of the OptionObject for use with myAvatar. It adds the SessionToken property to support calls to myAvatar Web Services.

## Properties

| Property        | Description |
|:----------------|:------------|
| EntityID        | Gets or sets the EntityID value.         |
| EpisodeNumber   | Gets or sets the EpisodeNumber value.    |
| ErrorCode       | Gets or sets the ErrorCode value.        |
| ErrorMesg       | Gets or sets the ErrorMesg value.        |
| Facility        | Gets or sets the Facility value.         |
| Forms           | Gets or sets the List<FormObject> value. |
| NamespaceName   | Gets or sets the NamespaceName value.    |
| OptionId        | Gets or sets the OptionId value.         |
| OptionStaffId   | Gets or sets the OptionStaffId value.    |
| OptionUserId    | Gets or sets the OptionUserId value.     |
| ParentNamespace | Gets or sets the ParentNamespace value.  |
| ServerName      | Gets or sets the ServerName value.       |
| SystemCode      | Gets or sets the SystemCode value.       |
| SessionToken    | Gets or sets the SessionToken value.     |

## Methods

| Method                                        | Description |
|:----------------------------------------------|:------------|
| AddFormObject(FormObject)                     | Adds a FormObject to the OptionObject2015.            |
| AddFormObject(string, bool)                   | Creates a FormObject with specified FormId and adds to the OptionObject2015. The second parameter specifies whether the FormObject should be flagged as a Multiple Iteration form. |
| AddRowObject(string, RowObject)               | Adds a RowObject to the FormObject with the specified FormId. |
| Clone                                         | Creates a shallow copy of the OptionObject2015.            |
| DeleteRowObject(RowObject)                    | Removes the RowObject from the OptionObject2015.            |
| DeleteRowObject(string)                       | Removes a RowObject from the OptionObject2015 by specified RowId.            |
| DisableAllFieldObjects                        | Sets all FieldObjects in the OptionObject2015 to disabled.            |
| DisableAllFieldObjects(List<string>)          | Sets all FieldObjects in the OptionObject2015 to disabled, except for the FieldNumbers specified in List<string>.            |
| GetCurrentRowId(string)                       | Gets the CurrentRow.RowId of the FormObject in the OptionObject2015 by FormId.            |
| GetFieldValue(string)                         | Gets the FieldValue of a specified FieldObject in the OptionObject2015 by FieldNumber.            |
| GetFieldValue(string, string, string)         | Gets the FieldValue of a specified FieldObject in the OptionObject2015 by FormId, RowId, and FieldNumber.            |
| GetFieldValues(string)                        | Returns a list of FieldValues of a specified FieldObject in the OptionObject2015 by FieldNumber.            |
| GetMultipleIterationStatus(string)            | Returns whether a FormObject in the OptionObject2015 is Multiple Iteration by specified FormId.            |
| GetParentRowId(string)                        | Returns the ParentRowId of a FormObject in the OptionObject2015 by FormId.            |
| IsFieldEnabled(string)                        | Returns whether the FieldObject in the OptionObject2015 is enabled by FieldNumber.            |
| IsFieldLocked(string)                         | Returns whether the FieldObject in the OptionObject2015 is locked by FieldNumber.            |
| IsFieldPresent(string)                        | Returns whether the FieldObject in the OptionObject2015 is present by FieldNumber.            |
| IsFieldRequired(string)                       | Returns whether the FieldObject in the OptionObject2015 is required by FieldNumber.            |
| IsFormPresent(string)                         | Returns whether the FormObject in the OptionObject2015 is present by FormId.            |
| IsRowMarkedForDeletion(string)                | Returns whether the RowObject in the OptionObject2015 is marked for deletion by RowId.            |
| IsRowPresent(string)                          | Returns whether the RowObject in the OptionObject2015 is present by RowId.            |
| SetDisabledFields(List<string>)               | Sets the specified FieldObjects as disabled in the OptionObject2015 by FieldNumber.            |
| SetDisabledFields(string)                     | Sets the specified FieldObject as disabled in the OptionObject2015 by FieldNumber.            |
| SetFieldValue(string, string)                 | Sets a FieldValue by FieldNumber in the OptionObject2015.            |
| SetFieldValue(string, string, string, string) | Sets a FieldValue by FormId, RowId, and FieldNumber in the OptionObject2015.            |
| SetLockedFields(List<string>)                 | Sets the specified FieldObjects as locked in the OptionObject2015 by FieldNumber.            |
| SetLockedFields(string)                       | Sets the specified FieldObject as locked in the OptionObject2015 by FieldNumber.            |
| SetOptionalFields(List<string>)               | Sets the specified FieldObjects as optional (enabled, not required) in the OptionObject2015 by FieldNumber.            |
| SetOptionalFields(string)                     | Sets the specified FieldObject as optional (enabled, not required) in the OptionObject2015 by FieldNumber.            |
| SetRequiredFields(List<string>)               | Sets the specified FieldObjects as required in the OptionObject2015 by FieldNumber.            |
| SetRequiredFields(string)                     | Sets the specified FieldObject as required in the OptionObject2015 by FieldNumber.            |
| SetUnlockedFields(List<string>)               | Sets the specified FieldObjects as unlocked in the OptionObject2015 by FieldNumber.            |
| SetUnlockedFields(string)                     | Sets the specified FieldObject as unlocked in the OptionObject2015 by FieldNumber.            |
| ToHtmlString(bool)                            | Returns the OptionObject2015 as an HTML string. The `<html>`, `<head>`, and `<body>` tags can be included if desired.            |
| ToJson                                        | Returns the OptionObject2015 as a JSON string.           |
| ToOptionObject                                | Returns a copy of the OptionObject2015 as an OptionObject.            |
| ToOptionObject2                               | Returns a copy of the OptionObject2015 as an OptionObject2.            |
| ToReturnOptionObject                          | Creates and returns the returnOptionObject with all required properties and modified values.            |
| ToReturnOptionObject(int, string)             | Creates and returns the returnOptionObject with all required properties and modified values and specified the ErrorCode and ErrorMesg.            |

## Explicit Interface Implementations

| Implementation                                                                                                           | Description                                                    |
|:-------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------|
| [IEquatable.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals?view=netstandard-1.1)(Object) | Determines whether an object is equal to the current instance. |
| [IEquatable.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1)           | Returns a hash code for the current instance.                  |

## See Also

* [OptionObject](./optionobject.md)
* [OptionObject2](./optionobject2.md)

