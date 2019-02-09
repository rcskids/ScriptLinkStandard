

# ScriptLinkHelpers

Namespace: ScriptLinkStandard.Helpers

Assemblies: ScriptLinkStandard.dll

Provides methods to help with the handling of OptionObjects.

```c#
public partial class ScriptLinkHelpers
```

## Examples

The following code samples demonstrate using the ScriptLinkHelpers class.

### IsValidErrorCode
There is a limited set of error codes that are valid of ruse with ScriptLink.
```c#
double errorCode = 3;
if (ScriptLinkHelpers.IsValidErrorCode(errorCode))
{
  optionObject.ErrorCode = errorCode;
}
```

### IsValidRowAction
There is a limited set of error codes that are valid of ruse with ScriptLink.
```c#
string rowAction = "EDIT";
if (ScriptLinkHelpers.IsValidRowAction(rowAction))
{
  rowObject.RowAction = rowAction;
}
```

### IsValidUrl
There is a limited set of error codes that are valid of ruse with ScriptLink.
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
| GetOptionObjectHeaders(IOptionObject) | |
| GetOptionObjectHeaders(IOptionObject2) | |
| GetOptionObjectHeaders(IOptionObject2015) | |
| IsValidErrorCode(double) | |
| IsValidErrorCode(string) | |
| IsValidRowAction(string) | |
| IsValidUrl(string) | |
| SafeGetInt(string) | |
| SplitDelimitedParameters(string) | |
| SplitDelimitedParameters(string, char) | |

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
| SetDisabledFields(IOptionObject, List<FieldObject>) | optionObject.SetDisabledFields(List<FieldObject>) |
| SetDisabledFields(IOptionObject, List<string>) | optionObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IOptionObject, string) | optionObject.SetDisabledFields(string) |
| SetDisabledFields(IOptionObject2, List<FieldObject>) | optionObject.SetDisabledFields(List<FieldObject>) |
| SetDisabledFields(IOptionObject2, List<string>) | optionObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IOptionObject2, string) | optionObject.SetDisabledFields(string) |
| SetDisabledFields(IOptionObject2015, List<FieldObject>) | optionObject.SetDisabledFields(List<FieldObject>) |
| SetDisabledFields(IOptionObject2015, List<string>) | optionObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IOptionObject2015, string) | optionObject.SetDisabledFields(string) |
| SetDisabledFields(IFormObject, List<string>) | formObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IFormObject, string) | formObject.SetDisabledFields(string) |
| SetDisabledFields(IRowObject, List<string>) | rowObject.SetDisabledFields(List<string>) |
| SetDisabledFields(IRowObject, string) | rowObject.SetDisabledFields(string) |
| SetFieldObjects(IOptionObject, string, List<FieldObject>) | optionObject.SetFieldObjects(string, List<FieldObject>) |
| SetFieldObjects(IOptionObject, string, List<string>) | optionObject.SetFieldObjects(string, List<string>) |
| SetFieldObjects(IOptionObject, string, string) | optionObject.SetFieldObjects(string, string) |
| SetFieldObjects(IOptionObject2, string, List<FieldObject>) | optionObject.SetFieldObjects(string, List<FieldObject>) |
| SetFieldObjects(IOptionObject2, string, List<string>) | optionObject.SetFieldObjects(string, List<string>) |
| SetFieldObjects(IOptionObject2, string, string) | optionObject.SetFieldObjects(string, string) |
| SetFieldObjects(IOptionObject2015, string, List<FieldObject>) | optionObject.SetFieldObjects(string, List<FieldObject>) |
| SetFieldObjects(IOptionObject2015, string, List<string>) | optionObject.SetFieldObjects(string, List<string>) |
| SetFieldObjects(IOptionObject2015, string, string) | optionObject.SetFieldObjects(string, string) |
| SetFieldObjects(IFormObject, string, List<string>) | formObject.SetFieldObjects(string, List<string>) |
| SetFieldObjects(IFormObject, string, string) | formObject.SetFieldObjects(string, string) |
| SetFieldObjects(IRowObject, string, List<string>) | rowObject.SetFieldObjects(string, List<string>) |
| SetFieldObjects(IRowObject, string, string) | rowObject.SetFieldObjects(string, string) |
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
| SetLockedFields(IOptionObject, List<FieldObject>) | optionObject.SetLockedFields(List<FieldObject>) |
| SetLockedFields(IOptionObject, List<string>) | optionObject.SetLockedFields(List<string>) |
| SetLockedFields(IOptionObject, string) | optionObject.SetLockedFields(string) |
| SetLockedFields(IOptionObject2, List<FieldObject>) | optionObject.SetLockedFields(List<FieldObject>) |
| SetLockedFields(IOptionObject2, List<string>) | optionObject.SetLockedFields(List<string>) |
| SetLockedFields(IOptionObject2, string) | optionObject.SetLockedFields(string) |
| SetLockedFields(IOptionObject2015, List<FieldObject>) | optionObject.SetLockedFields(List<FieldObject>) |
| SetLockedFields(IOptionObject2015, List<string>) | optionObject.SetLockedFields(List<string>) |
| SetLockedFields(IOptionObject2015, string) | optionObject.SetLockedFields(string) |
| SetLockedFields(IFormObject, List<string>) | formObject.SetLockedFields(List<string>) |
| SetLockedFields(IFormObject, string) | formObject.SetLockedFields(string) |
| SetLockedFields(IRowObject, List<string>) | rowObject.SetLockedFields(List<string>) |
| SetLockedFields(IRowObject, string) | rowObject.SetLockedFields(string) |
| SetOptionalFields(IOptionObject, List<FieldObject>) | optionObject.SetOptionalFields(List<FieldObject>) |
| SetOptionalFields(IOptionObject, List<string>) | optionObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IOptionObject, string) | optionObject.SetOptionalFields(string) |
| SetOptionalFields(IOptionObject2, List<FieldObject>) | optionObject.SetOptionalFields(List<FieldObject>) |
| SetOptionalFields(IOptionObject2, List<string>) | optionObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IOptionObject2, string) | optionObject.SetOptionalFields(string) |
| SetOptionalFields(IOptionObject2015, List<FieldObject>) | optionObject.SetOptionalFields(List<FieldObject>) |
| SetOptionalFields(IOptionObject2015, List<string>) | optionObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IOptionObject2015, string) | optionObject.SetOptionalFields(string) |
| SetOptionalFields(IFormObject, List<string>) | formObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IFormObject, string) | formObject.SetOptionalFields(string) |
| SetOptionalFields(IRowObject, List<string>) | rowObject.SetOptionalFields(List<string>) |
| SetOptionalFields(IRowObject, string) | rowObject.SetOptionalFields(string) |
| SetRequiredFields(IOptionObject, List<FieldObject>) | optionObject.SetRequiredFields(List<FieldObject>) |
| SetRequiredFields(IOptionObject, List<string>) | optionObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IOptionObject, string) | optionObject.SetRequiredFields(string) |
| SetRequiredFields(IOptionObject2, List<FieldObject>) | optionObject.SetRequiredFields(List<FieldObject>) |
| SetRequiredFields(IOptionObject2, List<string>) | optionObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IOptionObject2, string) | optionObject.SetRequiredFields(string) |
| SetRequiredFields(IOptionObject2015, List<FieldObject>) | optionObject.SetRequiredFields(List<FieldObject>) |
| SetRequiredFields(IOptionObject2015, List<string>) | optionObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IOptionObject2015, string) | optionObject.SetRequiredFields(string) |
| SetRequiredFields(IFormObject, List<string>) | formObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IFormObject, string) | formObject.SetRequiredFields(string) |
| SetRequiredFields(IRowObject, List<string>) | rowObject.SetRequiredFields(List<string>) |
| SetRequiredFields(IRowObject, string) | rowObject.SetRequiredFields(string) |
| SetUnlockedFields(IOptionObject, List<FieldObject>) | optionObject.SetUnlockedFields(List<FieldObject>) |
| SetUnlockedFields(IOptionObject, List<string>) | optionObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IOptionObject, string) | optionObject.SetUnlockedFields(string) |
| SetUnlockedFields(IOptionObject2, List<FieldObject>) | optionObject.SetUnlockedFields(List<FieldObject>) |
| SetUnlockedFields(IOptionObject2, List<string>) | optionObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IOptionObject2, string) | optionObject.SetUnlockedFields(string) |
| SetUnlockedFields(IOptionObject2015, List<FieldObject>) | optionObject.SetUnlockedFields(List<FieldObject>) |
| SetUnlockedFields(IOptionObject2015, List<string>) | optionObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IOptionObject2015, string) | optionObject.SetUnlockedFields(string) |
| SetUnlockedFields(IFormObject, List<string>) | formObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IFormObject, string) | formObject.SetUnlockedFields(string) |
| SetUnlockedFields(IRowObject, List<string>) | rowObject.SetUnlockedFields(List<string>) |
| SetUnlockedFields(IRowObject, string) | rowObject.SetUnlockedFields(string) |

## See also

* IOptionObject2015
* IOptionObject2
* IOptionObject
* IFormObject
* IRowObject
* IFieldObject
