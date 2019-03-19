---
theme: cayman
layout: default
title: FieldAction Class
---

# FieldAction

Namespace: [ScriptLinkStandard.Objects](./)

Assemblies: ScriptLinkStandard.dll

Defines the FieldAction class. Only usable with ScriptLinkHelpers.SetFieldObject and .SetFieldObjects.

``` c#
public class FieldAction
```

## Examples

The example below shows the use of FieldAction to set a FieldObject as disabled using ScriptLinkHelpers.

```c#
string fieldNumber = "123";
optionObject = ScriptLinkHelpers.SetFieldObject(optionObject, FieldAction.Disabled, fieldNumber);
```

## Properties

| Properties | Code | Description |
|:-----------|:-----|:------------|
| Disable | "DISABLE" | Used to set a FieldObject as disabled and not required. |
| Enable | "ENABLE" | Used to set a FieldObject as enabled. Does not change required setting. |
| Lock | "LOCK" | Used to set a FieldObject as locked. |
| Modify | "MODIFY" | Used to set a FieldObject as modified. |
| Optional | "OPTIONAL" | Used to set a FieldObject as enabled and not required. |
| Required | "REQUIRED" | Used to set a FieldObject as enabled and required. |
| Unlock | "UNLOCK" | Used to set a FieldObject as unlocked. |
