---
theme: cayman
layout: default
title: ScriptLinkStandard Documentation
---

# Testing ScriptLink APIs with SoapUI
Testing is an important part of any application development. The article below describes how to get started with SoapUI to test your ScriptLink APIs while they are still in the Development environment (i.e., Visual Studio).

## Before You Begin
To complete this example, you will need the following:
*	[Visual Studio](https://visualstudio.microsoft.com/downloads/) (Community, Professional, or Enterprise)
*	[SoapUI](https://www.soapui.org/downloads/soapui.html) (Open Source or Pro)

## Setup Test
### Visual Studio
If you don’t have a ScriptLink project yet, see our [Create a new ScriptLinkStandard Project walkthrough](./walkthrough-create-new-scriptlinkstandard-project.md) to get started.
1.	Open your ScriptLink solution in Visual Studio.
2.	Launch your web application in IIS Express and your preferred browser. (F5)
3.	Once launched in your web browser, navigate to the WSDL you wish to test. (e.g., https://localhost:44367/Api/v3/MyScriptLink.asmx?WSDL)
4.	Copy the URL for the WSDL to your clipboard. (Ctrl+V)

### SoapUI
1.	Launch SoapUI.
2.	Create a new SOAP project.
3.	Paste the WSDL URL into the Initial WSDL textbox, select Create Requests, and select OK.
4.	Expand RunScript to show the initial request, Request 1.
5.	Double-click on Request 1 to open.
You are now ready to test your ScriptLink API.

## Testing
Now that you are setup for the test, you can configure the sample OptionObject on the left. Before we do, let’s confirm that the API responds.

### Default Submission Test
Click the submit request button (Alt+Enter) to submit the default request to your API.
* If your web application is not running, then you will not get a response.
* If your web application is running you should get a response something like this.

``` xml
<soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
   <soap:Body>
      <soap:Fault>
         <faultcode>soap:Client</faultcode>
         <faultstring>System.Web.Services.Protocols.SoapException: Server was unable to read request. ---> System.InvalidOperationException: There is an error in XML document (9, 53). ---> System.FormatException: Input string was not in a correct format.
   at System.Number.ParseDouble(String value, NumberStyles options, NumberFormatInfo numfmt)
   at System.Xml.XmlConvert.ToDouble(String s)
   at Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializationReader1.Read5_OptionObject2015(Boolean isNullable, Boolean checkType)
   at Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializationReader1.Read8_RunScript()
   at Microsoft.Xml.Serialization.GeneratedAssembly.ArrayOfObjectSerializer4.Deserialize(XmlSerializationReader reader)
   at System.Xml.Serialization.XmlSerializer.Deserialize(XmlReader xmlReader, String encodingStyle, XmlDeserializationEvents events)
   --- End of inner exception stack trace ---
   at System.Xml.Serialization.XmlSerializer.Deserialize(XmlReader xmlReader, String encodingStyle, XmlDeserializationEvents events)
   at System.Web.Services.Protocols.SoapServerProtocol.ReadParameters()
   --- End of inner exception stack trace ---
   at System.Web.Services.Protocols.SoapServerProtocol.ReadParameters()
   at System.Web.Services.Protocols.WebServiceHandler.CoreProcessRequest()</faultstring>
         <detail/>
      </soap:Fault>
   </soap:Body>
</soap:Envelope>
```

Make note of the error included in the <faultstring>. This is indicating that we have an invalid value in our default XML. Which is fine for now, because the first test was just to confirm that the API responds.

### Test Valid XML
Now that we have confirmed that the API is running and responding, we will make the minimum edits to the XML to get a valid submission. Depending upon how your API is written, you should also get a valid OptionObject back with any errors related to the submission returned in the ErrorMesg.

Here are the minimum recommended edits to create a valid OptionObject:
*	Set EpisodeNumber to 0. Default is ?.
*	Remove ErrorCode and ErrorMessage. These wouldn’t typically have preset value in the XML submitted from myAvatar.
*	Set MultipleIteration to 0. Default is ?.

We can correct EpisodeNumber and MultipleIteration values in later tests when we begin to construct our anticipated XML.

Now that you are submitting a valid OptionObject XML file you should receive a valid OptionObject in return. If not, this is a great time to write and test your error handling for any invalid content.

To make changes to your code and test them. Stop Debugging, make the changes to the code, and start Debugging again. Once the application is running again, submit that XML again and see how the response changes.

### Configure XML for Specific Tests
Now that you have a valid OptionObject to submit and you receive a valid OptionObject in return, you can start replacing the default values with actual values you wish to test. For example, if you use a controller design where one API routes to different functionality based on the parameter then set that first to test the error handling of that specific method.

### Additional Considerations
#### Create Additional Requests
To create additional requests to test, right-click on the RunScript service and select New Request.

#### Save the Project
You can save this project for future use. This will with repeat testing in the future. Select Save All and it will save the project and any services and requests that you have added.

#### Rename Request
If you choose to save this project for future testing, you can rename your request to reflect the scenario it tests for. To do this, either right-click on the request and select rename or select the request and press F2.

#### Clone Requests
Once you have created your first text submission with sample values, you can clone it to create additional scenarios without starting from the default request. To do this either right-click on the request and select clone or select the request and press F9.
