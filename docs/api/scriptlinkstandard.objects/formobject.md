---
theme: cayman
layout: default
title: FormObject Class
---

# FormObject

Namespace: [ScriptLinkStandard.Objects](./)

Assemblies: ScriptLinkStandard.dll

Defines the FormObject used with the [OptionObject2015](./optionobject2015.md), [OptionObject2](./optionobject2.md), [OptionObject](./optionobject.md). Provides methods for creating and manipulating FormObject objects.

``` c#
public class FormObject : IEquatable<FormObject>, IFormObject
```

Implements [IEquatable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1), [IFormObject](/docs/api/scriptlinkstandard.interfaces/iformobject.md)

## Examples

Most implementations would not require working with the FormObject directly, however here is an example that uses the FormObject to create an [OptionObject2015](./optionobject2015.md) for Unit Testing.

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
  optionObject2015.Forms.Add(optionObject2015);
  
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
| CurrentRow      | Gets or sets the CurrentRow value. |
| FormId          | Gets or Sets the FormId value. |
| MultipleIteration | Gets or sets the MultipleIteration value. Cannot be true for the first FormObject in an [OptionObject2015](./optionobject2015.md), [OptionObject2](./optionobject2.md), or [OptionObject](./optionobject.md). |
| OtherRows       | Gets or set the OtherRows value. Only used when MultipleIteration equals true. |

## Methods

| Method        | Description |
|:----------------|:------------|
| AddRowObject([RowObject](./rowobject.md)) | Adds a [RowObject](./rowobject.md) to a the FormObject. |
| AddRowObject(string, string) | Adds a [RowObject](./rowobject.md) to a FormObject using supplied RowId and ParentRowId. |
| AddRowObject(string, string, string) | Adds a [RowObject](./rowobject.md) to a FormObject using supplied RowId and ParentRowId and setting the RowAction. |
| DeleteRowObject([RowObject](./rowobject.md)) | Removes a [RowObject](./rowobject.md) from a FormObject. |
| DeleteRowObject(string) | Removes a [RowObject](./rowobject.md) from a FormObject by RowId. |
| GetCurrentRowId() | Returns the ID of the [RowObject](./rowobject.md) in the CurrentRow of a FormObject. |
| GetFieldValue(string) | Returns the FieldValue of a [FieldObject](./fieldobject.md) in a FormObject by FieldNumber. |
| GetFieldValue(string, string) | Returns the FieldValue of a [FieldObject](./fieldobject.md) in a FormObject by RowId and FieldNumber. |
| GetFieldValues(string) | Returns a List<string> of FieldValues in a FormObject by FieldNumber. |
| GetParentRowId() | Returns the ParentRowId of the FormObject.CurrentRow. |
| IsFieldEnabled(string) | Returns whether a [FieldObject](./fieldobject.md) in a FormObject is enabled by FieldNumber. |
| IsFieldLocked(string) | Returns whether a [FieldObject](./fieldobject.md) in a FormObject is locked by FieldNumber. |
| IsFieldPresent(string) | Returns whether a [FieldObject](./fieldobject.md) in a FormObject is present by FieldNumber. |
| IsFieldRequired(string) | Returns whether a [FieldObject](./fieldobject.md) in a FormObject is required by FieldNumber. |
| IsRowMarkedForDeletion(string) | Returns whether a [RowObject](./rowobject.md) in a FormObject is marked for deletion by RowId. |
| IsRowPresent(string) | Returns whether a [RowObject](./rowobject.md) in a FormObject is present by RowId. |  
| SetDisabledFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a FormObject as disabled by FieldNumbers. |
| SetDisabledFields(string) | Sets the [FieldObjects](./fieldobject.md) in a FormObject as disabled by FieldNumber. If [FieldObject](./fieldobject.md) is in a multiple iteration FormObject then all occurances will be set as disabled. |
| SetFieldValue(string, string) | Sets the FieldValue of a [FieldObject](./fieldobject.md) in the FormObject.CurrentRow by FieldNumber. |
| SetFieldValue(string, string, string) | Sets the FieldValue a [FieldObject](./fieldobject.md) in the FormObject by RowId and FieldNumber. |
| SetLockedFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a FormObject as locked by FieldNumbers. |
| SetLockedFields(string) | Sets the [FieldObjects](./fieldobject.md) in a FormObject as locked by FieldNumber. If [FieldObject](./fieldobject.md) is in a multiple iteration FormObject then all occurances will be set as locked. |
| SetOptionalFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a FormObject as enabled and not required by FieldNumbers. |
| SetOptionalFields(string) | Sets the [FieldObjects](./fieldobject.md) in a FormObject as enabled and not required by FieldNumber. If [FieldObject](./fieldobject.md) is in a multiple iteration FormObject then all occurances will be set as enabled and not required. |
| SetRequiredFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a FormObject as enabled and required by FieldNumbers. |
| SetRequiredFields(string) | Sets the [FieldObjects](./fieldobject.md) in a FormObject as enabled and required by FieldNumber. If [FieldObject](./fieldobject.md) is in a multiple iteration FormObject then all occurances will be set as enabled and required. |
| SetUnlockedFields(List&lt;string&gt;) | Sets [FieldObjects](./fieldobject.md) in a FormObject as unlocked by FieldNumbers. |
| SetUnlockedFields(string) | Sets the [FieldObjects](./fieldobject.md) in a FormObject as unlocked by FieldNumber. If [FieldObject](./fieldobject.md) is in a multiple iteration FormObject then all occurances will be set as unlocked. |
| ToHtmlString(bool) | Returns the FormObject as an HTML string. The `<html>`, `<head>`, and `<body>` tags can be included if desired. |
| ToJson() | Returns the FormObject as a JSON string. |

## Explicit Interface Implementations

| Implementation                                                                                                           | Description                                                    |
|:-------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------|
| [IEquatable.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals?view=netstandard-1.1)(Object) | Determines whether an object is equal to the current instance. |
| [IEquatable.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1)           | Returns a hash code for the current instance.                  |

## See Also

* [OptionObject](./optionobject.md)
* [OptionObject2](./optionobject2.md)
* [OptionObject2015](./optionobject2015.md)
* [RowObject](./rowobject.md)
* [FieldObject](./fieldobject.md)
