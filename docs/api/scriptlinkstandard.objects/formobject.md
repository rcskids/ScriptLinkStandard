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
| AddRowObject([RowObject](./rowobject.md)) | Adds a RowObject to a the FormObject. |
| more... | to be written |

## Explicit Interface Implementations

| Implementation                                                                                                           | Description                                                    |
|:-------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------|
| [IEquatable.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals?view=netstandard-1.1)(Object) | Determines whether an object is equal to the current instance. |
| [IEquatable.GetHashCode](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netstandard-1.1)           | Returns a hash code for the current instance.                  |

## See Also

* [OptionObject](./optionobject.md)
* [OptionObject2](./optionobject2.md)
* [OptionObject2015](./optionobject2015.md)
