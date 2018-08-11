---
theme: cayman
layout: default
title: ScriptLinkStandard Documentation
---

# Compatibility

ScriptLinkStandard v.1.0.0-beta has been created using .NET Standard 1.1 to support the widest range of [.NET Framework](https://docs.microsoft.com/en-us/dotnet/framework/) and Windows Server versions.

## .NET Framework

Initial testing has been completed demonstrating compatibility of the library with various .NET implementations. Testing with all available frameworks is expected prior to release.

| .NET Framework | Compatible |
|:-------------- |:-----------|
| 4.7.2 | Untested |
| 4.7.1 | Untested |
| 4.7 | Untested |
| 4.6.2 | Untested |
| 4.6.1 | Yes |
| 4.6 | Yes |
| 4.5.2 | Yes |
| 4.5.1 | Yes |
| 4.5 | Yes |

Check out the Microsoft Docs for more information on [.NET Standard compatibility](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

## Windows Server

We have begun testing ScriptLink APIs built on ScriptLinkStandard on various Windows Servers. Testing is expected to be completed prior to release.

| Version | Compatible |
|:--------|:-----------|
| Windows Server 2016 | Yes |
| Windows Server 2012 R2 | Untested |
| Windows Server 2012 | Untested |
| Windows Server 2008 R2 | Untested |
| Windows Server 2008 | Untested |
| Windows Server 2003 R2 | No |
| Windows Server 2003 | No |

More information can be found on [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/framework/get-started/system-requirements).

## .NET Core?

The [System.Web.Services](https://docs.microsoft.com/en-us/dotnet/api/system.web.services?view=netframework-4.7.2) namespace is not available in [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/). As a result, ScriptLink web services cannot be created with [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/).
