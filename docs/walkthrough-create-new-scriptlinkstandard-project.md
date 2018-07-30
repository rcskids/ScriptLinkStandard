---
theme: cayman
layout: default
title: Walkthrough: Create a New ScriptLinkStandard Project
---

# Walkthrough: Create a New ScriptLinkStandard Project

This walkthrough uses Visual Studio 2017 and C#.

## Before You Begin

You will need the following to complete this walkthrough.
1. Visual Studio

## Create the Project

1. Open Visual Studio
2. Select Create new project... (File / New / Project)
  1. Expand Visual C# and select Web.
  2. Select ASP.NET Web Application (.NET Framework)
  3. Set the Name for your ScriptLink project. (e.g., SLSDemo.Web)
  4. Accept defaults for your Location and Solution name.
  5. Set the Framework to .NET Framework 4.6.1.
  6. Select OK.
3. On the New ASP.NET Web Application screen,
  1. Select Empty.
  2. Check Add unit tests
  3. Select OK.
4. The project will now be created.

## Add Required Packages

To be written.

## Create Controller API

1. Right-click on the SLSDemo.Web project and select Add / New Folder...
2. Set the name of the folder to Api.
3. Right-click on the Api folder and select New / Web Service (ASMX).
4. Set the Item name to ScriptLinkController and select OK.
5. You should now have a basic Hello World web method created.
```c#
public class ScriptLinkController : System.Web.Services.WebService
{

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
}
```
6. Add to the top of the file.
```c#
using ScriptLinkStandard.Objects;
```
7. Replace the HelloWorld() web method with the following.
```c#
public class ScriptLinkController : System.Web.Services.WebService
{
    [WebMethod]
    public string GetVersion()
    {
        return "v.0.0.1";
    }

    [WebMethod]
    public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string parameters)
    {
        return optionObject2015.ToReturnOptionObject(3, "Hello, World!");
    }
}
```
8. Right-click on the project and select Add / HTML Page
9. Set the Item name to index and select OK.
10. Run the project.
11. You should now see a blank web page rendered from http://localhost:{portnumber}/index.html
12. Replace index.html with Api/ScriptLinkController.asmx and press Enter.
13. Congratulations! You should now see your Web Service default documentation.
  1. Select Service Description to see the WSDL.
  2. Select GetVersion to view documentation on the GetVersion method.
    1. Select Invoke to see the version number you set returned.
  3. Select RunScript to view documentation on the RunScript method.

## Create Hello World Script

To be written.

## Add Unit Test

To be written.
