---
theme: cayman
layout: default
title: OptionObject Class
---

# OptionObject

Namespace: ScriptLinkStandard.Objects

Assemblies: ScriptLinkStandard.dll

Defines the web service contract for use with myAvatar ScriptLink. Provides methods creating, manipulating, and searching OptionObject objects.

```c#
public class OptionObject : IEquatable<OptionObject>, IOptionObject
```

Implements [IEquatable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1), [IOptionObject](/docs/api/scriptlinkstandard.interfaces/ioptionobject.md)

## Examples

The following code shows how to use OptionObject to construct a web service compatible with myAvatar.

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
        public OptionObject RunScript(OptionObject optionObject, string parameters)
        {
            return optionObject.ToReturnOptionObject(3, "Hello, World!");
        }
    }
}
```

## Remarks

OptionObject has been superceded by OptionObject2 and OptionObject2015. It is recommended to migrate to OptionObject2015.

OptionObject is the original definition of the OptionObject for use with myAvatar.

## Properties

| Property        | Description |
|:----------------|:------------|
| EntityID        | Gets or sets the EntityID value.         |
| EpisodeNumber   | Gets or sets the EpisodeNumber value.    |
| ErrorCode       | Gets or sets the ErrorCode value.        |
| ErrorMesg       | Gets or sets the ErrorMesg value.        |
| Facility        | Gets or sets the Facility value.         |
| Forms           | Gets or sets the List<FormObject> value. |
| OptionId        | Gets or sets the OptionId value.         |
| OptionStaffId   | Gets or sets the OptionStaffId value.    |
| OptionUserId    | Gets or sets the OptionUserId value.     |
| SystemCode      | Gets or sets the SystemCode value.       |

## Methods

| Method                                        | Description |
|:----------------------------------------------|:------------|
| AddFormObject(FormObject)                     | Adds a FormObject to the OptionObject.            |
| AddFormObject(string, bool)                   | Creates a FormObject with specified FormId and adds to the OptionObject. The second parameter specifies whether the FormObject should be flagged as a Multiple Iteration form. |
| AddRowObject(string, RowObject)               | Adds a RowObject to the FormObject with the specified FormId. |
| Clone                                         | Creates a shallow copy of the OptionObject.            |
| DeleteRowObject(RowObject)                    | Removes the RowObject from the OptionObject.            |
| DeleteRowObject(string)                       | Removes a RowObject from the OptionObject by specified RowId.            |
| DisableAllFieldObjects                        | Sets all FieldObjects in the OptionObject to disabled.            |
| DisableAllFieldObjects(List<string>)          | Sets all FieldObjects in the OptionObject to disabled, except for the FieldNumbers specified in List<string>.            |
| GetCurrentRowId(string)                       | Gets the CurrentRow.RowId of the FormObject in the OptionObject by FormId.            |
| GetFieldValue(string)                         | Gets the FieldValue of a specified FieldObject in the OptionObject by FieldNumber.            |
| GetFieldValue(string, string, string)         | Gets the FieldValue of a specified FieldObject in the OptionObject by FormId, RowId, and FieldNumber.            |
| GetFieldValues(string)                        | Returns a list of FieldValues of a specified FieldObject in the OptionObject by FieldNumber.            |
| GetMultipleIterationStatus(string)            | Returns whether a FormObject in the OptionObject is Multiple Iteration by specified FormId.            |
| GetParentRowId(string)                        | Returns the ParentRowId of a FormObject in the OptionObject by FormId.            |
| IsFieldEnabled(string)                        | Returns whether the FieldObject in the OptionObject is enabled by FieldNumber.            |
| IsFieldLocked(string)                         | Returns whether the FieldObject in the OptionObject is locked by FieldNumber.            |
| IsFieldPresent(string)                        | Returns whether the FieldObject in the OptionObject is present by FieldNumber.            |
| IsFieldRequired(string)                       | Returns whether the FieldObject in the OptionObject is required by FieldNumber.            |
| IsFormPresent(string)                         | Returns whether the FormObject in the OptionObject is present by FormId.            |
| IsRowMarkedForDeletion(string)                | Returns whether the RowObject in the OptionObject is marked for deletion by RowId.            |
| IsRowPresent(string)                          | Returns whether the RowObject in the OptionObject is present by RowId.            |
| SetDisabledFields(List<string>)               | Sets the specified FieldObjects as disabled in the OptionObject by FieldNumber.            |
| SetDisabledFields(string)                     | Sets the specified FieldObject as disabled in the OptionObject by FieldNumber.            |
| SetFieldValue(string, string)                 | Sets a FieldValue by FieldNumber in the OptionObject.            |
| SetFieldValue(string, string, string, string) | Sets a FieldValue by FormId, RowId, and FieldNumber in the OptionObject.            |
| SetLockedFields(List<string>)                 | Sets the specified FieldObjects as locked in the OptionObject by FieldNumber.            |
| SetLockedFields(string)                       | Sets the specified FieldObject as locked in the OptionObject by FieldNumber.            |
| SetOptionalFields(List<string>)               | Sets the specified FieldObjects as optional (enabled, not required) in the OptionObject by FieldNumber.            |
| SetOptionalFields(string)                     | Sets the specified FieldObject as optional (enabled, not required) in the OptionObject by FieldNumber.            |
| SetRequiredFields(List<string>)               | Sets the specified FieldObjects as required in the OptionObject by FieldNumber.            |
| SetRequiredFields(string)                     | Sets the specified FieldObject as required in the OptionObject by FieldNumber.            |
| SetUnlockedFields(List<string>)               | Sets the specified FieldObjects as unlocked in the OptionObject by FieldNumber.            |
| SetUnlockedFields(string)                     | Sets the specified FieldObject as unlocked in the OptionObject by FieldNumber.            |
| ToHtmlString(bool)                            | Returns the OptionObject as an HTML string. The `<html>`, `<head>`, and `<body>` tags can be included if desired.            |
| ToJson                                        | Returns the OptionObject as a JSON string.           |
| ToOptionObject2                               | Returns a copy of the OptionObject as an OptionObject2.            |
| ToOptionObject2015                            | Returns a copy of the OptionObject as an OptionObject2015.            |
| ToReturnOptionObject                          | Creates and returns the returnOptionObject with all required properties and modified values.            |
| ToReturnOptionObject(int, string)             | Creates and returns the returnOptionObject with all required properties and modified values and specified the ErrorCode and ErrorMesg.            |

## Explicit Interface Implementations

| Implementation                                                                                                           | Description                                                    |
|:-------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------|
| [IEquatable.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals?view=netstandard-1.1)(Object) | Determines whether an object is equal to the current instance. |
| [IEquatable.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1)           | Returns a hash code for the current instance.                  |

## See Also

* [OptionObject2](./optionobject2.md)
* [OptionObject2015](./optionobject2015.md)

