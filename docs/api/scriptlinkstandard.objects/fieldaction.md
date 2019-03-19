---
theme: cayman
layout: default
title: FieldAction Class
---

# FieldAction

Namespace: [ScriptLinkStandard.Objects](./)

Assemblies: ScriptLinkStandard.dll

Defines the FieldAction class.

``` c#
public class FieldAction
```

## Examples

The example below shows the use of RowAction to set the RowAction property of a RowObject.

```c#
RowObject rowObject = new RowObject();
rowObject.RowAction = RowAction.Add;
```

## Properties

| Properties | Code | Description |
|:-----------|:-----|:------------|
| Add | "ADD" | Sets the valid Add value for a RowAction. |
| Delete | "DELETE" | Sets the valid Delete value for a RowAction. |
| Edit | "EDIT" | Sets the valid Edit value for a RowAction. |
| None | "" | Sets the valid None value for a RowAction. |

## See Also

* [OptionObject](./optionobject.md)
* [OptionObject2](./optionobject2.md)
* [OptionObject2015](./optionobject2015.md)
