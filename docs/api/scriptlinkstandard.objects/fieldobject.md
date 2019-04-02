---
theme: cayman
layout: default
title: FieldObject Class
---

# FieldObject

Namespace: [ScriptLinkStandard.Objects](./)

Assemblies: ScriptLinkStandard.dll

Defines the FieldObject used with the [OptionObject2015](./optionobject2015.md), [OptionObject2](./optionobject2.md), [OptionObject](./optionobject.md). Provides methods for creating and manipulating FieldObject objects.

``` c#
public class FieldObject : IEquatable<FieldObject>, IFieldObject
```

Implements [IEquatable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1), [IFieldObject](/docs/api/scriptlinkstandard.interfaces/ifieldobject.md)

## Examples

Most implementations would not require working with the FieldObject directly, however here is an example that uses the FieldObject to create an [OptionObject2015](./optionobject2015.md) for Unit Testing.

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
| Enabled         | Gets or sets the Enabled value. The supported case-sensitive values are `N` and `Y`. |
| FieldNumber     | Gets or Sets the FieldNumber value. |
| FieldValue      | Gets or sets the FieldValue value. |
| Lock            | Gets or sets the Lock value. The supported case-sensitive values are `N` and `Y`. |
| Required        | Gets or sets the Required value. The supported case-sensitive values are `N` and `Y`. |

## Methods

| Method        | Description |
|:----------------|:------------|
| Clone() | Creates a copy of the FieldObject. |
| GetFieldValue() | Returns the FieldValue of a FieldObject. |
| IsEnabled() | Returns whether the FieldObject is enabled. |
| IsLocked() | Returns whether the FieldObject is locked. |
| IsModified() | Returns whether the FieldObject has been modified. |
| IsRequired() | Returns whether the FieldObject is required. | 
| SetAsDisabled() | Sets FieldObject as disabled and marks the FieldObject as modified. |
| SetAsEnabled() | Sets FieldObject as enabled and marks the FieldObject as modified. |
| SetAsLocked() | Sets FieldObject as locked and marks the FieldObject as modified. |
| SetAsModified() | Sets FieldObject as modified. |
| SetAsRequired() | Sets FieldObject as required and marks the FieldObject as modified. |
| SetAsUnlocked() | Sets FieldObject as unlocked and marks the FieldObject as modified. |
| SetFieldValue(string) | Sets the FieldValue of a FieldObject and marks the FieldObject as modified. |
| ToHtmlString(bool) | Returns the FieldObject as an HTML string. The `<html>`, `<head>`, and `<body>` tags can be included if desired. |
| ToJson() | Returns the FieldObject as a JSON string. |
| ToXml() | Returns the FieldObject as an XML string. |

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
* [RowObject](./rowobject.md)
