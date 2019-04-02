---
theme: cayman
layout: default
title: ScriptLinkHelpers Class
---

# ScriptLinkHelpers

Namespace: [ScriptLinkStandard.Helpers](./)

Assemblies: ScriptLinkStandard.dll

Provides methods to help with the handling of OptionObjects.

```c#
public partial class ScriptLinkHelpers
```

## Examples

The following code samples demonstrate using the ScriptLinkHelpers class.

### IsValidErrorCode
There is a limited set of error codes that are valid for use with ScriptLink.
```c#
double errorCode = 3;
if (ScriptLinkHelpers.IsValidErrorCode(errorCode))
{
  optionObject.ErrorCode = errorCode;
}
```

### IsValidOpenFormString
There is a specific format that the OpenForm string must be in to be used with ScriptLink.
```c#
string errorMessage = '[PM]PATIENT500|Open Financial Eligibility?|123456|1';
if (ScriptLinkHelpers.IsValidOpenFormString(errorMessage))
{
  optionObject.ErrorMesg = errorMessage;
}
```

### IsValidRowAction
There is a limited set of error codes that are valid for use with ScriptLink.
```c#
string rowAction = "EDIT";
if (ScriptLinkHelpers.IsValidRowAction(rowAction))
{
  rowObject.RowAction = rowAction;
}
```

### IsValidUrl
There is a limited set of error codes that are valid for use with ScriptLink.
```c#
double errorCode = 5;
string url = "http://www.rcskids.org";
if (ScriptLinkHelpers.IsValidErrorCode(errorCode) && ScriptLinkHelpers.IsValidUrl(url))
{
  optionObject.ErrorCode = errorCode;
  optionObject.ErrorMesg = url;
}
```

## Methods

The following methods are exclusively available using the ScriptLinkHelpers class.

| Method | Description |
| - | - |
| GetOptionObjectHeaders(IOptionObject) | Returns a List<string> of the OptionObject properties and values. |
| GetOptionObjectHeaders(IOptionObject2) | Returns a List<string> of the OptionObject2 properties and values. |
| GetOptionObjectHeaders(IOptionObject2015) | Returns a List<string> of the OptionObject2015 properties and values. |
| IsValidErrorCode(double) | Returns whether a double value is a valid ScriptLink error code. |
| IsValidErrorCode(string) | Returns whether a string value can be converted to a valid ScriptLink error code. |
| IsValidOpenFormString(string) | Returns whether a string is a valid OpenForm string for use with error code 6. |
| IsValidRowAction(string) | Returns whether a string value is a valid ScriptLink Row Action. |
| IsValidUrl(string) | Returns whether a string is a valid URL for use with error code 5. |
| SafeGetInt(string) | Converts a string to an int. Returns 0 if not able to convert string. |
| SetFieldObject(IOptionObject, string, string) | Sets a FieldObject based on specified FieldAction by FieldNumber. |
| SetFieldObject(IOptionObject2, string, string) | Sets a FieldObject based on specified FieldAction by FieldNumber. |
| SetFieldObject(IOptionObject2015, string, string) | Sets a FieldObject based on specified FieldAction by FieldNumber. |
| SetFieldObject(IFormObject, string, string) | Sets a FieldObject based on specified FieldAction by FieldNumber. |
| SetFieldObject(IRowObject, string, string) | Sets a FieldObject based on specified FieldAction by FieldNumber. |
| SetFieldObjects(IOptionObject, string, List<FieldObject>) | Sets FieldObjects based on specified FieldAction by List of FieldObjects. |
| SetFieldObjects(IOptionObject, string, List<string>) | Sets FieldObjects based on specified FieldAction by List of FieldNumbers. |
| SetFieldObjects(IOptionObject2, string, List<FieldObject>) | Sets FieldObjects based on specified FieldAction by List of FieldObjects. |
| SetFieldObjects(IOptionObject2, string, List<string>) | Sets FieldObjects based on specified FieldAction by List of FieldNumbers. |
| SetFieldObjects(IOptionObject2015, string, List<FieldObject>) | Sets FieldObjects based on specified FieldAction by List of FieldObjects. |
| SetFieldObjects(IOptionObject2015, string, List<string>) | Sets FieldObjects based on specified FieldAction by List of FieldNumbers. |
| SetFieldObjects(IFormObject, string, List<string>) | Sets FieldObjects based on specified FieldAction by List of FieldNumbers. |
| SetFieldObjects(IRowObject, string, List<string>) | Sets FieldObjects based on specified FieldAction by List of FieldNumbers. |
| SplitDelimitedParameters(string) | Returns a string array of values from a comma-delimited string. |
| SplitDelimitedParameters(string, char) | Returns a string array of values from a string using specified delimiter. |

The following methods are also available as methods on the various objects.

| Method | Equivalent Object Usage |
| - | - |
| AddFieldObject(IRowObject, IFieldObject) | rowObject.AddFieldObject(IFieldObject) |
| AddFieldObject(IRowObject, string, string) | rowObject.AddFieldObject(string, string) |
| AddFieldObject(IRowObject, string, string, string, string, string) | rowObject.AddFieldObject(string, string, string, string, string) |
| AddFieldObject(IRowObject, string, string, bool, bool, bool) | rowObject.AddFieldObject(string, string, bool, bool, bool) |
| AddFormObject(IOptionObject, IFormObject) | optionObject.AddFormObject(IFormObject) |
| AddFormObject(IOptionObject, string, bool) | optionObject.AddFormObject(string, bool) |
| AddFormObject(IOptionObject2, IFormObject) | optionObject.AddFormObject(IFormObject) |
| AddFormObject(IOptionObject2, string, bool) | optionObject.AddFormObject(string, bool) |
| AddFormObject(IOptionObject2015, IFormObject) | optionObject.AddFormObject(IFormObject) |
| AddFormObject(IOptionObject2015, string, bool) | optionObject.AddFormObject(string, bool) |
| AddRowObject(IOptionObject, string, IRowObject) | optionObject.AddRowObject(string, IRowObject) |
| AddRowObject(IOptionObject2, string, IRowObject) | optionObject.AddRowObject(string, IRowObject) |
| AddRowObject(IOptionObject2015, string, IRowObject) | optionObject.AddRowObject(string, IRowObject) |
| AddRowObject(IFormObject, IRowObject) | formObject.AddRowObject(IRowObject) |
| AddRowObject(IFormObject, string, string) | formObject.AddRowObject(string, string) |
| AddRowObject(IFormObject, string, string, string) | formObject.AddRowObject(string, string) |
| Clone(IOptionObject) | optionObject.Clone() |
| Clone(IOptionObject2) | optionObject.Clone() |
| Clone(IOptionObject2015) | optionObject.Clone() |
| Clone(IFormObject) | formObject.Clone() |
| Clone(IRowObject) | rowObject.Clone() |
| Clone(IFieldObject) | fieldObject.Clone() |
| DeleteRowObject(IOptionObject, IRowObject) | optionObject.DeleteRowObject(IRowObject) |
| DeleteRowObject(IOptionObject, string) | optionObject.DeleteRowObject(string) |
| DeleteRowObject(IOptionObject2, IRowObject) | optionObject.DeleteRowObject(IRowObject) |
| DeleteRowObject(IOptionObject2, string) | optionObject.DeleteRowObject(string) |
| DeleteRowObject(IOptionObject2015, IRowObject) | optionObject.DeleteRowObject(IRowObject) |
| DeleteRowObject(IOptionObject2015, string) | optionObject.DeleteRowObject(string) |
| DeleteRowObject(IFormObject, IRowObject) | formObject.DeleteRowObject(IRowObject) |
| DeleteRowObject(IFormObject, string) | formObject.DeleteRowObject(string) |
| DisableAllFieldObjects(IOptionObject) | optionObject.DisableAllFieldObjects() |
| DisableAllFieldObjects(IOptionObject, List<string>) | optionObject.DisableAllFieldObjects(List<string>) |
| DisableAllFieldObjects(IOptionObject2) | optionObject.DisableAllFieldObjects() |
| DisableAllFieldObjects(IOptionObject2, List<string>) | optionObject.DisableAllFieldObjects(List<string>) |
| DisableAllFieldObjects(IOptionObject2015) | optionObject.DisableAllFieldObjects() |
| DisableAllFieldObjects(IOptionObject2015, List<string>) | optionObject.DisableAllFieldObjects(List<string>) |
| GetCurrentRowId(IOptionObject, string) | optionObject.GetCurrentRowId(string) |
| GetCurrentRowId(IOptionObject2, string) | optionObject.GetCurrentRowId(string) |
| GetCurrentRowId(IOptionObject2015, string) | optionObject.GetCurrentRowId(string) |
| GetCurrentRowId(IFormObject) | formObject.GetCurrentRowId() |
| GetFieldValue(IOptionObject, string) | optionObject.GetFieldValue(string) |
| GetFieldValue(IOptionObject, string, string, string) | optionObject.GetFieldValue(string, string, string) |
| GetFieldValue(IOptionObject2, string) | optionObject.GetFieldValue(string) |
| GetFieldValue(IOptionObject2, string, string, string) | optionObject.GetFieldValue(string, string, string) |
| GetFieldValue(IOptionObject2015, string) | optionObject.GetFieldValue(string) |
| GetFieldValue(IOptionObject2015, string, string, string) | optionObject.GetFieldValue(string, string, string) |
| GetFieldValue(IFormObject, string) | formObject.GetFieldValue(string) |
| GetFieldValue(IFormObject, string, string) | formObject.GetFieldValue(string, string) |
| GetFieldValue(IRowObject, string) | rowObject.GetFieldValue(string) |
| GetFieldValue(IFieldObject) | fieldObject.GetFieldValue() |
| GetFieldValues(IOptionObject, string) | optionObject.GetFieldValues(string) |
| GetFieldValues(IOptionObject2, string) | optionObject.GetFieldValues(string) |
| GetFieldValues(IOptionObject2015, string) | optionObject.GetFieldValues(string) |
| GetFieldValues(IFormObject, string) | formObject.GetFieldValues(string) |
| GetMultipleIterationStatus(IOptionObject, string) | optionObject.GetMultipleIterationStatus(string) |
| GetMultipleIterationStatus(IOptionObject2, string) | optionObject.GetMultipleIterationStatus(string) |
| GetMultipleIterationStatus(IOptionObject2015, string) | optionObject.GetMultipleIterationStatus(string) |
| GetMultipleIterationStatus(IFormObject) | formObject.GetMultipleIterationStatus() |
| GetNextAvailableRowId(IFormObject, string) | formObject.GetNextAvailableRowId(string) |
| GetParentRowId(IOptionObject, string) | optionObject.GetParentRowId(string) |
| GetParentRowId(IOptionObject2, string) | optionObject.GetParentRowId(string) |
| GetParentRowId(IOptionObject2015, string) | optionObject.GetParentRowId(string) |
| GetParentRowId(IFormObject) | formObject.GetParentRowId() |
| GetReturnOptionObject(IOptionObject) | optionObject.ToReturnOptionObject() |
| GetReturnOptionObject(IOptionObject, double, string) | optionObject.ToReturnOptionObject(double, string) |
| GetReturnOptionObject(IOptionObject2) | optionObject.ToReturnOptionObject() |
| GetReturnOptionObject(IOptionObject2, double, string) | optionObject.ToReturnOptionObject(double, string) |
| GetReturnOptionObject(IOptionObject2015) | optionObject.ToReturnOptionObject() |
| GetReturnOptionObject(IOptionObject2015, double, string) | optionObject.ToReturnOptionObject(double, string) |
| IsFieldEnabled(IOptionObject, string) | optionObject.IsFieldEnabled(string) |
| IsFieldEnabled(IOptionObject2, string) | optionObject.IsFieldEnabled(string) |
| IsFieldEnabled(IOptionObject2015, string) | optionObject.IsFieldEnabled(string) |
| IsFieldEnabled(IFormObject, string) | formObject.IsFieldEnabled(string) |
| IsFieldEnabled(IRowObject, string) | rowObject.IsFieldEnabled(string) |
| IsFieldEnabled(IFieldObject) | fieldObject.IsFieldEnabled() |
| IsFieldLocked(IOptionObject, string) | optionObject.IsFieldLocked(string) |
| IsFieldLocked(IOptionObject2, string) | optionObject.IsFieldLocked(string) |
| IsFieldLocked(IOptionObject2015, string) | optionObject.IsFieldLocked(string) |
| IsFieldLocked(IFormObject, string) | formObject.IsFieldLocked(string) |
| IsFieldLocked(IRowObject, string) | rowObject.IsFieldLocked(string) |
| IsFieldLocked(IFieldObject) | fieldObject.IsFieldLocked() |
| IsFieldPresent(IOptionObject, string) | optionObject.IsFieldPresent(string) |
| IsFieldPresent(IOptionObject2, string) | optionObject.IsFieldPresent(string) |
| IsFieldPresent(IOptionObject2015, string) | optionObject.IsFieldPresent(string) |
| IsFieldPresent(IFormObject, string) | formObject.IsFieldPresent(string) |
| IsFieldPresent(IRowObject, string) | rowObject.IsFieldPresent(string) |
| IsFieldRequired(IOptionObject, string) | optionObject.IsFieldRequired(string) |
| IsFieldRequired(IOptionObject2, string) | optionObject.IsFieldRequired(string) |
| IsFieldRequired(IOptionObject2015, string) | optionObject.IsFieldRequired(string) |
| IsFieldRequired(IFormObject, string) | formObject.IsFieldRequired(string) |
| IsFieldRequired(IRowObject, string) | rowObject.IsFieldRequired(string) |
| IsFieldRequired(IFieldObject) | fieldObject.IsFieldRequired() |
| IsFormPresent(IOptionObject, string) | optionObject.IsFormPresent(string) |
| IsFormPresent(IOptionObject2, string) | optionObject.IsFormPresent(string) |
| IsFormPresent(IOptionObject2015, string) | optionObject.IsFormPresent(string) |
| IsRowMarkedForDeletion(IOptionObject, string) | optionObject.IsRowMarkedForDeletion(string) |
| IsRowMarkedForDeletion(IOptionObject2, string) | optionObject.IsRowMarkedForDeletion(string) |
| IsRowMarkedForDeletion(IOptionObject2015, string) | optionObject.IsRowMarkedForDeletion(string) |
| IsRowMarkedForDeletion(IFormObject, string) | formObject.IsRowMarkedForDeletion(string) |
| IsRowPresent(IOptionObject, string) | optionObject.IsRowPresent(string) |
| IsRowPresent(IOptionObject2, string) | optionObject.IsRowPresent(string) |
| IsRowPresent(IOptionObject2015, string) | optionObject.IsRowPresent(string) |
| IsRowPresent(IFormObject, string) | formObject.IsRowPresent(string) |
| RemoveFieldObject(IRowObject, IFieldObject) | rowObject.RemoveFieldObject(IFieldObject) |
| RemoveFieldObject(IRowObject, string) | rowObject.RemoveFieldObject(IFieldObject) |
| SetDisabledField(IOptionObject, string) | optionObject.SetDisabledField(string) |
| SetDisabledField(IOptionObject2, string) | optionObject.SetDisabledField(string) |
| SetDisabledField(IOptionObject2015, string) | optionObject.SetDisabledField(string) |
| SetDisabledField(IFormObject, string) | formObject.SetDisabledField(string) |
| SetDisabledField(IRowObject, string) | rowObject.SetDisabledField(string) |
| SetDisabledFields(IOptionObject, List<FieldObject>) | optionObject.SetDisabledFields(List<FieldObject>) |
| SetDisabledFields(IOptionObject, List<string>) | optionObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IOptionObject2, List<FieldObject>) | optionObject.SetDisabledFields(List<FieldObject>) |
| SetDisabledFields(IOptionObject2, List<string>) | optionObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IOptionObject2015, List<FieldObject>) | optionObject.SetDisabledFields(List<FieldObject>) |
| SetDisabledFields(IOptionObject2015, List<string>) | optionObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IFormObject, List<string>) | formObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IRowObject, List<string>) | rowObject.SetDisabledFields(List<string>) |
| SetFieldValue(IOptionObject, string, string) | optionObject.SetFieldValue(string, string) |
| SetFieldValue(IOptionObject, string, string, string, string) | optionObject.SetFieldValue(string, string, string, string) |
| SetFieldValue(IOptionObject2, string, string) | optionObject.SetFieldValue(string, string) |
| SetFieldValue(IOptionObject2, string, string, string, string) | optionObject.SetFieldValue(string, string, string, string) |
| SetFieldValue(IOptionObject2015, string, string) | optionObject.SetFieldValue(string, string) |
| SetFieldValue(IOptionObject2015, string, string, string, string) | optionObject.SetFieldValue(string, string, string, string) |
| SetFieldValue(IFormObject, string, string) | formObject.SetFieldValue(string, string) |
| SetFieldValue(IFormObject, string, string, string) | formObject.SetFieldValue(string, string, string) |
| SetFieldValue(IRowObject, string, string) | rowObject.SetFieldValue(string, string) |
| SetFieldValue(IFieldObject, string) | fieldObject.SetFieldValue(string) |
| SetLockedField(IOptionObject, string) | optionObject.SetLockedField(string) |
| SetLockedField(IOptionObject2, string) | optionObject.SetLockedField(string) |
| SetLockedField(IOptionObject2015, string) | optionObject.SetLockedField(string) |
| SetLockedField(IFormObject, string) | formObject.SetLockedField(string) |
| SetLockedField(IRowObject, string) | rowObject.SetLockedField(string) |
| SetLockedFields(IOptionObject, List<FieldObject>) | optionObject.SetLockedFields(List<FieldObject>) |
| SetLockedFields(IOptionObject, List<string>) | optionObject.SetLockedFields(List<string>) |
| SetLockedFields(IOptionObject2, List<FieldObject>) | optionObject.SetLockedFields(List<FieldObject>) |
| SetLockedFields(IOptionObject2, List<string>) | optionObject.SetLockedFields(List<string>) |
| SetLockedFields(IOptionObject2015, List<FieldObject>) | optionObject.SetLockedFields(List<FieldObject>) |
| SetLockedFields(IOptionObject2015, List<string>) | optionObject.SetLockedFields(List<string>) |
| SetLockedFields(IFormObject, List<string>) | formObject.SetLockedFields(List<string>) |
| SetLockedFields(IRowObject, List<string>) | rowObject.SetLockedFields(List<string>) |
| SetOptionalField(IOptionObject, string) | optionObject.SetOptionalField(string) |
| SetOptionalField(IOptionObject2, string) | optionObject.SetOptionalField(string) |
| SetOptionalField(IOptionObject2015, string) | optionObject.SetOptionalField(string) |
| SetOptionalField(IFormObject, string) | formObject.SetOptionalField(string) |
| SetOptionalField(IRowObject, string) | rowObject.SetOptionalField(string) |
| SetOptionalFields(IOptionObject, List<FieldObject>) | optionObject.SetOptionalFields(List<FieldObject>) |
| SetOptionalFields(IOptionObject, List<string>) | optionObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IOptionObject2, List<FieldObject>) | optionObject.SetOptionalFields(List<FieldObject>) |
| SetOptionalFields(IOptionObject2, List<string>) | optionObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IOptionObject2015, List<FieldObject>) | optionObject.SetOptionalFields(List<FieldObject>) |
| SetOptionalFields(IOptionObject2015, List<string>) | optionObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IFormObject, List<string>) | formObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IRowObject, List<string>) | rowObject.SetOptionalFields(List<string>) |
| SetRequiredField(IOptionObject, string) | optionObject.SetRequiredField(string) |
| SetRequiredField(IOptionObject2, string) | optionObject.SetRequiredField(string) |
| SetRequiredField(IOptionObject2015, string) | optionObject.SetRequiredField(string) |
| SetRequiredField(IFormObject, string) | formObject.SetRequiredField(string) |
| SetRequiredField(IRowObject, string) | rowObject.SetRequiredField(string) |
| SetRequiredFields(IOptionObject, List<FieldObject>) | optionObject.SetRequiredFields(List<FieldObject>) |
| SetRequiredFields(IOptionObject, List<string>) | optionObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IOptionObject2, List<FieldObject>) | optionObject.SetRequiredFields(List<FieldObject>) |
| SetRequiredFields(IOptionObject2, List<string>) | optionObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IOptionObject2015, List<FieldObject>) | optionObject.SetRequiredFields(List<FieldObject>) |
| SetRequiredFields(IOptionObject2015, List<string>) | optionObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IFormObject, List<string>) | formObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IRowObject, List<string>) | rowObject.SetRequiredFields(List<string>) |
| SetUnlockedField(IOptionObject, string) | optionObject.SetUnlockedField(string) |
| SetUnlockedField(IOptionObject2, string) | optionObject.SetUnlockedField(string) |
| SetUnlockedField(IOptionObject2015, string) | optionObject.SetUnlockedField(string) |
| SetUnlockedField(IFormObject, string) | formObject.SetUnlockedField(string) |
| SetUnlockedField(IRowObject, string) | rowObject.SetUnlockedField(string) |
| SetUnlockedFields(IOptionObject, List<FieldObject>) | optionObject.SetUnlockedFields(List<FieldObject>) |
| SetUnlockedFields(IOptionObject, List<string>) | optionObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IOptionObject2, List<FieldObject>) | optionObject.SetUnlockedFields(List<FieldObject>) |
| SetUnlockedFields(IOptionObject2, List<string>) | optionObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IOptionObject2015, List<FieldObject>) | optionObject.SetUnlockedFields(List<FieldObject>) |
| SetUnlockedFields(IOptionObject2015, List<string>) | optionObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IFormObject, List<string>) | formObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IRowObject, List<string>) | rowObject.SetUnlockedFields(List<string>) |
| TransformToHtmlString(IOptionObject) | optionObject.ToHtmlString() |
| TransformToHtmlString(IOptionObject, bool) | optionObject.ToHtmlString(bool) |
| TransformToHtmlString(IOptionObject2) | optionObject.ToHtmlString() |
| TransformToHtmlString(IOptionObject2, bool) | optionObject.ToHtmlString(bool) |
| TransformToHtmlString(IOptionObject2015) | optionObject.ToHtmlString() |
| TransformToHtmlString(IOptionObject2015, bool) | optionObject.ToHtmlString(bool) |
| TransformToHtmlString(IFormObject) | formObject.ToHtmlString() |
| TransformToHtmlString(IFormObject, bool) | formObject.ToHtmlString(bool) |
| TransformToHtmlString(IRowObject) | rowObject.ToHtmlString() |
| TransformToHtmlString(IRowObject, bool) | rowObject.ToHtmlString(bool) |
| TransformToHtmlString(IFieldObject) | fieldObject.ToHtmlString() |
| TransformToHtmlString(IFieldObject, bool) | fieldObject.ToHtmlString(bool) |

## See also

* IOptionObject2015
* IOptionObject2
* IOptionObject
* IFormObject
* IRowObject
* IFieldObject
