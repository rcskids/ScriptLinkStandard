using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class GetOptionObjectHeadersTests
    {
        private OptionObject optionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            optionObject = new OptionObject();
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_IsNotNull()
        {
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(optionObject);
            Assert.IsNotNull(headers);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetOptionObjectHeaders_ContainsExpected_EntityID_Entry()
        {
            string expected = "Entity ID: " + optionObject.EntityID;
            List<string> headers = ScriptLinkHelpers.GetOptionObjectHeaders(optionObject);
            bool isPresent = headers.Contains(expected);
            Assert.IsTrue(isPresent);
        }
    }
}
