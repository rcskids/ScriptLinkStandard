---
theme: cayman
layout: default
title: ScriptLinkStandard Documentation
---

# Compatibility

ScriptLinkStandard v.1.0.18-beta has been created using .NET Standard 2.0 to support the widest range of [.NET Framework](https://docs.microsoft.com/en-us/dotnet/framework/) and Windows Server versions and features.

## .NET Framework

Initial testing has been completed demonstrating compatibility of the library with various .NET implementations. Testing with all available frameworks is expected prior to release.

| .NET Framework | Compatible |
|:-------------- |:-----------|
| 4.8 | Untested |
| 4.7.2 | Yes |
| 4.7.1 | Yes |
| 4.7 | Yes |
| 4.6.2 | Yes |
| 4.6.1 | Yes |
| 4.6 and earlier | No |

Check out the Microsoft Docs for more information on [.NET Standard compatibility](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

## Windows Server

We have begun testing ScriptLink APIs built on ScriptLinkStandard on various Windows Servers. Testing is expected to be completed prior to release.

| Version | Compatible |
|:--------|:-----------|
| Windows Server 2019 | Untested |
| Windows Server 2016 | Yes |
| Windows Server 2012 R2 | Yes |
| Windows Server 2012 | Yes |
| Windows Server 2008 R2 | Yes, with SP1 |
| Windows Server 2008 or earlier | No |

More information can be found on [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/framework/get-started/system-requirements).

## .NET Core?

ScriptLinkStandard is compatible with .NET Core 2.0 or later, though is untested at this time. The [System.Web.Services](https://docs.microsoft.com/en-us/dotnet/api/system.web.services?view=netframework-4.7.2) namespace is not available in [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/). As a result, ScriptLink web services cannot be created with [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/) using the .NET Framework methodology.

Here are some helpful articles, should you decide to try it out with .NET Core.
* [Custom ASP.NET Core Middleware Example](https://devblogs.microsoft.com/dotnet/custom-asp-net-core-middleware-example/)
* [How to Call WCF Services and Create SOAP Services with ASP.NET Core](https://stackify.com/soap-net-core/)
