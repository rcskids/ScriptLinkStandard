---
theme: cayman
layout: default
title: IFieldObject Interface
---

# IFieldObject Interface

Namespace: [ScriptLinkStandard.Interfaces](./)

Assemblies: ScriptLinkStandard.dll

Exposes an object that supports the Netsmart-defined FieldObject properties and the ScriptLinkStandard methods.

```c#
public interface IFieldObject
```

## Examples

The following code example shows how to implement a custom FieldObject that can be used with the ScriptLinkHelpers.

```c#
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using System;

// Custom FieldObject
public class CustomFieldObject : IFieldObject
{
    // Public properties required by Netsmart
    public string Enabled { get; set; }
    public string FieldNumber { get; set; }
    public string FieldValue { get; set; }
    public string Lock { get; set; }
    public string Required { get; set; }

    // Private properties
    private bool _isModified { get; set; }

    // Required Methods for ScriptLinkHelpers compatibility
    public string GetFieldValue() => this.FieldValue;
    public bool IsEnabled() => this.Enabled == "1" ? true : false;
    public bool IsLocked() => this.Lock == "1" ? true : false;
    public bool IsModified() => _isModified;
    public bool IsRequired() => this.Required == "1" ? true : false;
    public void SetAsDisabled()
    {
        _isModified = true;
        this.Enabled = "0";
        this.Required = "0";
    }
    public void SetAsEnabled()
    {
        _isModified = true;
        this.Enabled = "1";
    }
    public void SetAsLocked()
    {
        _isModified = true;
        this.Lock = "1";
    }
    public void SetAsModified() => _isModified = true;
    public void SetAsOptional()
    {
        _isModified = true;
        this.Enabled = "1";
        this.Required = "0";
    }
    public void SetAsRequired()
    {
        _isModified = true;
        this.Enabled = "1";
        this.Required = "1";
    }
    public void SetAsUnlocked()
    {
        _isModified = true;
        this.Lock = "0";
    }
    public void SetFieldValue(string fieldValue)
    {
        _isModified = true;
        this.FieldValue = fieldValue;
    }
    public string ToHtmlString() => ScriptLinkHelpers.TransformToHtmlString(this);
    public string ToHtmlString(bool includeHtmlHeaders) => ScriptLinkHelpers.TransformToHtmlString(this, includeHtmlHeaders);
    public string ToJson() => ScriptLinkHelpers.TransformToJson(this);
    public string ToXml() => ScriptLinkHelpers.TransformToXml(this);
}
```
