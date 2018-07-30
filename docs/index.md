---
theme: cayman
layout: default
title: ScriptLinkStandard Documentation
---

# Introduction

ScriptLinkStandard is a class library designed to help organizations that use myAvatar by Netsmart Technologies, Inc. get up and running quickly with ScriptLink.

## Get Started

Looking to get started with ScriptLinkStandard? We will be making ScriptLinkStandard available through NuGet easy inclusion in your new and existing ScriptLink projects.

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

## Walkthroughs

Here are some walkthroughs to help you get started with ScriptLinkStandard.

* [Create a new ScriptLinkStandard Project](./walkthrough-create-new-scriptlinkstandard-project)
* [Migrate an existing ScriptLink project](./walkthrough-migrate-existing-scriptlink-project)
