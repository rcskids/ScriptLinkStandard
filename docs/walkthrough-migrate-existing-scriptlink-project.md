---
title: Walkthrough: Migrate an Existing ScriptLink Project to ScriptLinkStandard
---

# Walkthrough: Migrate an Existing ScriptLink Project to ScriptLinkStandard

If you have been using ScriptLink with myAvatar for any amount of time you are likely familiar with the NTST default libraries made available through the App Exchange. There are some notable differences between the NTST.ScriptLinkService.Objects library and ScriptLinkStandard.Objects. The instructions below will walk you through the minimum changes required to migrate to ScriptLinkStandard and then demonstrate some optimizations that can be leveraged.

## Ambiguous Reference

You cannot declare both NTST.ScriptLinkService.Objects and ScriptLinkStandard.Objects in the same file. This creates an ambiguous reference compile error. Comment out or remove NTST.ScriptLinkService.Objects from the list of usings after you add the using for ScriptLinkStandard.Objects.

```c#
//using NTST.ScriptLinkService.Objects;
using ScriptLinkStandard.Objects;
```

## Convert Arrays to Lists

The only breaking change when moving from NTST.ScriptLinkService.Objects to ScriptLinkStandard.Objects is the change from Arrays to Lists in the various objects. Specifically, the following properties have been changed from arrays to List<T>:
* OptionObject2015.Forms
* OptionObject2.Forms
* OptionObject.Forms
* FormObject.OtherRows
* RowObject.Fields

```c#
//var forms = new FormObject[1];
var forms = new List<FormObject>();
var formObject = new FormObject();
var currentRow = new RowObject();
//var fields = new FieldObject[1];
var fields = new List<FieldObject>();
var field = new FieldObject();
```

Now that you have replaced the using and changed the arrays to List<T>, your project should compile again and your web services should work as expected.

## Recommended Refactoring

One of the keys benefits of using ScriptLinkStandard is the ability to write less code to accomplish the same tasks. This reduces the risk of errors and unexpected bugs.

### Legacy Sample Code

Consider the following ScriptLink API based on NTST.ScripLinkService.Objects.

```c#
    public class ScriptLinkController : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetVersion()
        {
            return "v.0.0.1";
        }

        [WebMethod]
        public OptionObject2 RunScript(OptionObject2 optionObject2, string scriptName)
        {
            OptionObject2 returnOptionObject = new OptionObject2();

            switch (scriptName)
            {
                case "SetValueBasedOnAnotherValueAndThrowError":
                    returnOptionObject = SetValueBasedOnAnotherValueAndThrowError(optionObject2);
                    break;
                default:
                    returnOptionObject.ErrorCode = 3;
                    returnOptionObject.ErrorMesg = "No script was found with this name.";
                    returnOptionObject.EntityID = optionObject2.EntityID;
                    returnOptionObject.OptionId = optionObject2.OptionId;
                    returnOptionObject.EpisodeNumber = optionObject2.EpisodeNumber;
                    returnOptionObject.SystemCode = optionObject2.SystemCode;
                    returnOptionObject.Facility = optionObject2.Facility;
                    returnOptionObject.ServerName = optionObject2.ServerName;
                    returnOptionObject.ParentNamespace = optionObject2.ParentNamespace;
                    returnOptionObject.NamespaceName = optionObject2.NamespaceName;
                    break;
            }

            return returnOptionObject;
        }
```

If the scriptName value is set correctly, then it calls the following private class.

```c#
        private OptionObject2 SetValueBasedOnAnotherValueAndThrowError(OptionObject2 optionObject2)
        {
            OptionObject2 returnOptionObject2 = new OptionObject2();
            string fieldValue = "Field not found in OptionObject.";

            foreach (var form in optionObject2.Forms)
            {
                foreach (var currentField in form.CurrentRow.Fields)
                {
                    try
                    {
                        switch (currentField.FieldNumber)
                        {
                            case "15":
                                fieldValue = currentField.FieldValue;
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                }
            }

            if (fieldValue != "6")
            {
                //var forms = new FormObject[1];
                var forms = new List<FormObject>();
                var formObject = new FormObject();
                var currentRow = new RowObject();
                //var fields = new FieldObject[1];
                var fields = new List<FieldObject>();
                var field = new FieldObject();

                field.FieldNumber = "15";
                field.FieldValue = "6";
                field.Enabled = "1";
                fields[0] = field;

                currentRow.Fields = fields;
                currentRow.RowId = optionObject2.Forms[0].CurrentRow.RowId;
                currentRow.ParentRowId = optionObject2.Forms[0].CurrentRow.ParentRowId;
                currentRow.RowAction = "EDIT";

                formObject.FormId = "14";
                formObject.CurrentRow = currentRow;
                forms[0] = formObject;

                returnOptionObject2.ErrorCode = 3;
                returnOptionObject2.ErrorMesg = "The FieldValue must be 6.";
                returnOptionObject2.Forms = forms;
            }
            else
            {
                returnOptionObject2.ErrorCode = 3;
                returnOptionObject2.ErrorMesg = "You have chosen wisely.";
            }
            returnOptionObject2.EntityID = optionObject2.EntityID;
            returnOptionObject2.OptionId = optionObject2.OptionId;
            returnOptionObject2.EpisodeNumber = optionObject2.EpisodeNumber;
            returnOptionObject2.SystemCode = optionObject2.SystemCode;
            returnOptionObject2.Facility = optionObject2.Facility;
            returnOptionObject2.ServerName = optionObject2.ServerName;
            returnOptionObject2.ParentNamespace = optionObject2.ParentNamespace;
            returnOptionObject2.NamespaceName = optionObject2.NamespaceName;

            return returnOptionObject2;
        }
```

### Refactor ReturnOptionObject Creation

When using ScriptLinkStandard, the returnOptionObject can be created directly from the received OptionObject2 in this sample. This means you do not have to write the code set the required values, remove the unmodifed FormObjects, RowObjects, and FieldObjects. The refactored web service could look something like this.

```c#
        [WebMethod]
        public OptionObject2 RunScript(OptionObject2 optionObject2, string scriptName)
        {
            switch (scriptName)
            {
                case "SetValueBasedOnAnotherValueAndThrowError":
                    return SetValueBasedOnAnotherValueAndThrowError(optionObject2);
                default:
                    return optionObject2.ToReturnOptionObject(3,"No script was found with this name.");
            }
        }
```

### Refactor Setting and Getting FieldValues

ScriptLinkStandard makes it easier to get and set values. It allows the developer to skip the rewriting off loops to get and new to set. Additionally, since the sample code hands off returnOptionObject creation to the private method when the scriptName matches the ToReturnOptionObject refactor option is available here as well.

Here's the refactored private method.

```c#
        private OptionObject2 SetValueBasedOnAnotherValueAndThrowError(OptionObject2 optionObject2)
        {
            if (optionObject2.GetFieldValue("15") != "6")
            {
                optionObject2.SetFieldValue("15", "6");
                return optionObject2.ToReturnOptionObject(3, "The FieldValue must be 6.");
            }
            return optionObject2.ToReturnOptionObject(3, "You have chosen wisely.");
        }
```
