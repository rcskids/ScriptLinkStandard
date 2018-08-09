---
theme: cayman
layout: default
title: ScriptLinkStandard.Objects Namespace
---

# ScriptLinkStandard.Objects

The ScriptLinkStandard.Objects namespace includes the classes that define the XML contract required for use with myAvatar ScriptLink.

It is recommended that you use the OptionObject2015 class.

## Structure

![OptionObject2015 Structure](./ScriptLinkStandard.Objects.png)

* OptionObject: [OptionObject2015](OptionObject2015.md), [OptionObject2](OptionObject2.md), or [OptionObject](OptionObject.md)
  * Forms: List<[FormObject](FormObject.md)>
    * CurrentRow: [RowObject](RowObject.md)
      * Fields: List<[FieldObject](FieldObject.md)>
    * OtherRows: List<[RowObject](RowObject.md)>
      * Fields: List<[FieldObject](FieldObject.md)>

[OptionObject2015](OptionObject2015.md), [OptionObject2](OptionObject2.md), and [OptionObject](OptionObject.md) have a same fundamental structure though there are differences in root level properties.
