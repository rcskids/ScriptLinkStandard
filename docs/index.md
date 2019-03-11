---
theme: cayman
layout: default
title: ScriptLinkStandard Documentation
---

# Introduction

ScriptLinkStandard is a class library designed to help organizations that use myAvatar by Netsmart Technologies, Inc. get up and running quickly with ScriptLink.

## Get Started

Looking to get started with ScriptLinkStandard? We will be making ScriptLinkStandard available through NuGet for easy inclusion in your new and existing ScriptLink projects.

### Compatibility

ScriptLinkStandard is compatible with projects based on .NET Framework 4.6.1 and later. [Learn more](./compatibility.md).

### NuGet

1. Right-click on the solution and select Manage NuGet Packages for Solution...
2. Enter ScriptLinkStandard in the search box. (Check Include prerelease to check to get the latest prerelease version.)
3. Select ScriptLinkStandard from the search results.
4. Check the boxes next to each of your projects (Web and Unit Test) and select Install.
5. Once installed you may close the NuGet - Solution page or search for additional packages.
6. You can now reference the ScriptLinkStandard library throughout your project with `@using` tags.

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

The [ScriptLinkStandard.Objects](./api/scriptlinkstandard.objects) namespace includes all of the objects (classes) required to create a functional ScriptLink API.

* [OptionObject2015](./api/scriptlinkstandard.objects/optionobject2015.md)
* [OptionObject2](./api/scriptlinkstandard.objects/optionobject2.md) (Legacy)
* [OptionObject](./api/scriptlinkstandard.objects/optionobject.md) (Legacy)
* Read [more...](./api/scriptlinkstandard.objects)

#### ScriptLinkStandard.Helpers

Although most of the [ScriptLinkHelpers](./api/scriptlinkstandard.helpers/scriptlinkhelpers.md) are accessible as method on the various objects, some use cases would need leverage the [ScriptLinkHelpers](./api/scriptlinkstandard.helpers/scriptlinkhelpers.md) class directly. Here are some common examples:

* [ScriptLinkHelpers](./api/scriptlinkstandard.helpers/scriptlinkhelpers.md).IsValidErrorCode()
* [ScriptLinkHelpers](./api/scriptlinkstandard.helpers/scriptlinkhelpers.md).IsValidRowAction()
* [ScriptLinkHelpers](./api/scriptlinkstandard.helpers/scriptlinkhelpers.md).IsValidUrl()
* [ScriptLinkHelpers](./api/scriptlinkstandard.helpers/scriptlinkhelpers.md).SafeGetInt()
* [ScriptLinkHelpers](./api/scriptlinkstandard.helpers/scriptlinkhelpers.md).SplitDelimitedParameter()
* Read [more...](./api/scriptlinkstandard.helpers)

#### ScriptLinkStandard.Interfaces

The [ScriptLinkStandard.Interfaces](./api/scriptlinkstandard.interfaces) namespace is helpful when you want use a Test-Driven Development process or create your own custom objects that work with the [ScriptLinkHelpers](./api/scriptlinkstandard.helpers/scriptlinkhelpers.md) class.

### Other Examples

* [Testing ScriptLink APIs with SoapUI](testing-scriptlink-api-with-soapui.md)
