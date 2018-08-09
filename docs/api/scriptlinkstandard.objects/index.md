---
theme: cayman
layout: default
title: ScriptLinkStandard.Objects Namespace
---

# ScriptLinkStandard.Objects

The ScriptLinkStandard.Objects namespace includes the classes that define the XML contract required for use with myAvatar ScriptLink.

It is recommended that you use the [OptionObject2015](optionobject2015.md) class.

## Structure

![OptionObject2015 Structure](./ScriptLinkStandard.Objects.png)

* OptionObject: [OptionObject2015](optionobject2015.md), [OptionObject2](optionobject2.md), or [OptionObject](optionobject.md)
  * Forms: List<[FormObject](formobject.md)>
    * CurrentRow: [RowObject](fowobject.md)
      * Fields: List<[FieldObject](fieldobject.md)>
    * OtherRows: List<[RowObject](rowobject.md)>
      * Fields: List<[FieldObject](fieldobject.md)>

[OptionObject2015](optionobject2015.md), [OptionObject2](optionobject2.md), and [OptionObject](optionobject.md) have a same fundamental structure though there are differences in root level properties.
