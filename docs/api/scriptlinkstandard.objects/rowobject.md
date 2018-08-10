---
theme: cayman
layout: default
title: RowObject Class
---

# RowObject

Namespace: [ScriptLinkStandard.Objects](./)

Assemblies: ScriptLinkStandard.dll

Defines the RowObject used with the [OptionObject2015](./optionobject2015.md), [OptionObject2](./optionobject2.md), [OptionObject](./optionobject.md). Provides methods for creating and manipulating RowObject objects.

``` c#
public class RowObject : IEquatable<RowObject>, IRowObject
```

Implements [IEquatable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1), [IRowObject](/docs/api/scriptlinkstandard.interfaces/irowobject.md)

## Examples

Most implementations would not require working with the RowObject directly, however here is an example that uses the RowObject to create an [OptionObject2015](./optionobject2015.md) for Unit Testing.

``` c#
[TestMethod]
public void GetMyFieldValue_Returns_Y()
{
  // Arrange
  // This script is expected to return the ErrorCode "3" and the value "Y" in the ErrorMesg.
  string expected = "Y";
  
  // Initiate script to Test (based on the IScriptLink interface)
  GetMyFieldValueScript script = new GetMyFieldValueScript();
  string parameter = "";
  
  // Create OptionObject2015
  FieldObject fieldObject = new FieldObject("123.45", expected);
  
  RowObject rowObject = new RowObject("1||1");
  rowObject.Fields.Add(fieldObject);
  
  FormObject formObject = new FormObject("1", rowObject);
  
  OptionObject2015 optionObject2015 = new optionObject2015
  {
    EntityID = "123456",
    EpisodeNumber = "2",
    Facility = "1",
    NamespaceName = "AVPM",
    OptionId = "USER00",
    ParentNamespace = "AVPM",
    ServerName = "AV01",
    SystemCode = "UAT",
    SessionToken = "a2s3d4f5g6"
  }
  optionObject2015.Forms.Add(formObject);
  
  // Act
  OptionObject2015 returnOptionObject = script.ProcessScript(optionObject, parameter);
  
  // Assert
  Assert.AreEqual("3", returnOptionObject.ErrorCode);
  Assert.AreEqual(expected, returnOptionObject.ErrorMesg);
}
```

## Properties

| Property        | Description |
|:----------------|:------------|
| Fields          | Gets or sets the Fields value. |
| ParentRowId     | Gets or Sets the ParentRowId value. |
| RowAction       | Gets or sets the RowAction value. The supported case-sensitive values are blank, `ADD`, `EDIT`, and `DELETE`. |
| RowId           | Gets or set the RowId value. |

## Methods

| Method        | Description |
|:----------------|:------------|
| AddFieldObject([FieldObject](./fieldobject.md)) | Adds a [FieldObject](./fieldobject.md) to a the RowObject. |
| AddFieldObject(string, string) | Adds a [FieldObject](./fieldobject.md) to a RowObject using supplied FieldNumber and FieldValue. |
| AddFieldObject(string, string, string, string, string) | Adds a [FieldObject](./fieldobject.md) to a RowObject using supplied FieldNumber and FieldValue and setting the Enabled, Locked, and Required values (e.g., `Y` or `N`). |
| AddFieldObject(string, string, bool, bool, bool) | Adds a [FieldObject](./fieldobject.md) to a RowObject using supplied FieldNumber and FieldValue and setting the Enabled, Locked, and Required values. |
| GetFieldValue(string) | Returns the FieldValue of a [FieldObject](./fieldobject.md) in a RowObject by FieldNumber. |
| IsFieldEnabled(string) | Returns whether a [FieldObject](./fieldobject.md) in a RowObject is enabled by FieldNumber. |
| IsFieldLocked(string) | Returns whether a [FieldObject](./fieldobject.md) in a RowObject is locked by FieldNumber. |
| IsFieldPresent(string) | Returns whether a [FieldObject](./fieldobject.md) in a RowObject is present by FieldNumber. |
| IsFieldRequired(string) | Returns whether a [FieldObject](./fieldobject.md) in a RowObject is required by FieldNumber. |
| RemoveFieldObject([FieldObject](./fieldobject.md)) | Removes a [FieldObject](./fieldobject.md) from a RowObject. |
| RemoveFieldObject(string) | Removes a [FieldObject](./fieldobject.md) from a RowObject by FieldNumber. |
| RemoveUnmodifiedFieldObjects() | Removes [FieldObjects](./fieldobject.md) from RowObject that have not been modified. |  
| SetDisabledFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a RowObject as disabled by FieldNumbers. |
| SetDisabledFields(string) | Sets the [FieldObjects](./fieldobject.md) in a RowObject as disabled by FieldNumber. If [FieldObject](./fieldobject.md) is in a multiple iteration FormObject then all occurances will be set as disabled. |
| SetFieldValue(string, string) | Sets the FieldValue of a [FieldObject](./fieldobject.md) in the RowObject by FieldNumber. |
| SetLockedFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a RowObject as locked by FieldNumbers. |
| SetLockedFields(string) | Sets the [FieldObject](./fieldobject.md) in a RowObject as locked by FieldNumber. |
| SetOptionalFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a RowObject as enabled and not required by FieldNumbers. |
| SetOptionalFields(string) | Sets the [FieldObject](./fieldobject.md) in a RowObject as enabled and not required by FieldNumber. |
| SetRequiredFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a RowObject as enabled and required by FieldNumbers. |
| SetRequiredFields(string) | Sets the [FieldObject](./fieldobject.md) in a RowObject as enabled and required by FieldNumber. |
| SetUnlockedFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a RowObject as unlocked by FieldNumbers. |
| SetUnlockedFields(string) | Sets the [FieldObject](./fieldobject.md) in a RowObject as unlocked by FieldNumber. |
| ToHtmlString(bool) | Returns the RowObject as an HTML string. The `<html>`, `<head>`, and `<body>` tags can be included if desired. |
| ToJson() | Returns the RowObject as a JSON string. |

## Explicit Interface Implementations

| Implementation                                                                                                           | Description                                                    |
|:-------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------|
| [IEquatable.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals?view=netstandard-1.1)(Object) | Determines whether an object is equal to the current instance. |
| [IEquatable.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1)           | Returns a hash code for the current instance.                  |

## See Also

* [OptionObject](./optionobject.md)
* [OptionObject2](./optionobject2.md)
* [OptionObject2015](./optionobject2015.md)
* [FormObject](./formobject.md)
* [FieldObject](./fieldobject.md)
