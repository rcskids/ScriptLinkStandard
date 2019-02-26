using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class GetOptionObjectHeadersTests
    {
        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject_IsNotNull()
        {
            OptionObject optionObject = new OptionObject();
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(optionObject);
            Assert.IsNotNull(headers);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject2_IsNotNull()
        {
            OptionObject2 optionObject = new OptionObject2();
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(optionObject);
            Assert.IsNotNull(headers);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject2015_IsNotNull()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(optionObject);
            Assert.IsNotNull(headers);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject_ContainsExpected_EntityID_Entry()
        {
            OptionObject optionObject = new OptionObject();
            string expected = "Entity ID: " + optionObject.EntityID;
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(optionObject);
            bool isPresent = headers.Contains(expected);
            Assert.IsTrue(isPresent);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject2_ContainsExpected_EntityID_Entry()
        {
            OptionObject2 optionObject = new OptionObject2();
            string expected = "Entity ID: " + optionObject.EntityID;
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(optionObject);
            bool isPresent = headers.Contains(expected);
            Assert.IsTrue(isPresent);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_OptionObject2015_ContainsExpected_EntityID_Entry()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            string expected = "Entity ID: " + optionObject.EntityID;
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(optionObject);
            bool isPresent = headers.Contains(expected);
            Assert.IsTrue(isPresent);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOptionObjectHeaders_OptionObject_Null()
        {
            OptionObject nullOptionObject = null;
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(nullOptionObject);
            Assert.AreEqual(5, headers.Count);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOptionObjectHeaders_OptionObject2_Null()
        {
            OptionObject2 nullOptionObject = null;
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(nullOptionObject);
            Assert.AreEqual(5, headers.Count);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetOptionObjectHeaders_OptionObject2015_Null()
        {
            OptionObject2015 nullOptionObject = null;
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(nullOptionObject);
            Assert.AreEqual(5, headers.Count);
        }
    }
}
