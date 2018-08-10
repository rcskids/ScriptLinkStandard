---
theme: cayman
layout: default
title: ScriptLinkStandard Documentation
---

# Introduction

ScriptLinkStandard is a class library designed to help organizations that use myAvatar by Netsmart Technologies, Inc. get up and running quickly with ScriptLink.

## Get Started

Looking to get started with ScriptLinkStandard? We will be making ScriptLinkStandard available through NuGet for easy inclusion in your new and existing ScriptLink projects.

### NuGet

The goal of this project is to make this library available for free through NuGet. We'll have more information soon on this.

### Manual Installation

1. Download the [latest release](https://github.com/rcskids/ScriptLinkStandard/releases).
2. Extract the compressed file.
3. Open your solution in Visual Studio.
4. For each project in the solution that will use the library (e.g., your web app and unit test projects)
	1. Select Project > Add Reference... from the menu bar (or right-click on the project and select Add > Reference...).
	2. In the Reference Manager, select Browse...
	3. Navigate the location of the ScriptLinkStandard.dll that you just extracted.
	4. Select the ScriptLinkStandard.dll file and click Add.
	5. Select OK.
5. You can now reference the ScriptLinkStandard library throughout your project with `@using` tags.

```c#
@using ScriptLinkStandard.Helpers
@using ScriptLinkStandard.Interfaces
@using ScriptLinkStandard.Objects
```

## Documentation
### Walkthroughs

Here are some walkthroughs to help you get started with ScriptLinkStandard.

* [Create a new ScriptLinkStandard Project](./walkthrough-create-new-scriptlinkstandard-project.md)
* [Migrate an existing ScriptLink project](./walkthrough-migrate-existing-scriptlink-project.md)

### API

#### ScriptLinkStandard.Objects

A basic implementation of the ScriptLinkStandard library would use only the ScriptLinkStandard namespace.

``` c#
@using ScriptLinkStandard.Objects
```

The [ScriptLinkStandard.Objects](./scriptlinkstandard.objects) namespace includes all of the objects (classes) required to create a functional ScriptLink API.

* [OptionObject2015](./scriptlinkstandard.objects/optionobject2015.md)
* [OptionObject2](./scriptlinkstandard.objects/optionobject2.md) (Legacy)
* [OptionObject](./scriptlinkstandard.objects/optionobject.md) (Legacy)
* Read [more...](./scriptlinkstandard.objects)

#### ScriptLinkStandard.Helpers

Although most of the [ScriptLinkHelpers](./scriptlinkstandard.helpers/scriptlinkhelpers.md) are accessible as method on the various objects, some use cases would need leverage the [ScriptLinkHelpers](./scriptlinkstandard.helpers/scriptlinkhelpers.md) class directly. Here are some common examples:

* [ScriptLinkHelpers](./scriptlinkstandard.helpers/scriptlinkhelpers.md).IsValidErrorCode()
* [ScriptLinkHelpers](./scriptlinkstandard.helpers/scriptlinkhelpers.md).IsValidRowAction()
* [ScriptLinkHelpers](./scriptlinkstandard.helpers/scriptlinkhelpers.md).IsValidUrl()
* [ScriptLinkHelpers](./scriptlinkstandard.helpers/scriptlinkhelpers.md).SafeGetInt()
* [ScriptLinkHelpers](./scriptlinkstandard.helpers/scriptlinkhelpers.md).SplitDelimitedParameter()
* Read [more...](./scriptlinkstandard.helpers)

#### ScriptLinkStandard.Interfaces

The [ScriptLinkStandard.Interfaces](./scriptlinkstandard.interfaces) namespace is helpful when you want use a Test-Driven Development process or create your own custom objects that work with the [ScriptLinkHelpers](./scriptlinkstandard.helpers/scriptlinkhelpers.md) class.
