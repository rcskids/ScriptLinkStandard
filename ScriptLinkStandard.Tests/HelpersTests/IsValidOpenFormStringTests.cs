using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class IsValidOpenFormStringTests
    {

        [TestMethod]
        public void IsValidOpenFormString_FormOnly_IsValid()
        {
            string openFormString = "[PM]GUISYS560";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_FormAndMessage_IsValid()
        {
            string openFormString = "[PM]GUISYS560|Message";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_FormMessageAndEntity_IsValid()
        {
            string openFormString = "[PM]PATIENT14|Message|123456";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_FormMessageEntityAndEpisode_IsValid()
        {
            string openFormString = "[PM]PATIENT500|Message|123456|1";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_MultipleForms_IsValid()
        {
            string openFormString = "[PM]GUISYS560&[CWS]GUISYS560|Message";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_MissingEpisode_IsValid()
        {
            string openFormString = "[PM]PATIENT14|Message|123456|";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_NullString_NotValid()
        {
            string openFormString = null;
            Assert.IsFalse(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_EmptyString_NotValid()
        {
            string openFormString = "";
            Assert.IsFalse(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_BasicString_NotValid()
        {
            string openFormString = "ABC";
            Assert.IsFalse(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_NonEpisodic_NotValid()
        {
            string openFormString = "[PM]PATIENT14|Message|123456|0";
            Assert.IsFalse(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_MissingEntityID_NotValid()
        {
            string openFormString = "[PM]PATIENT500|Message||1";
            Assert.IsFalse(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_PMForm_IsValid()
        {
            string openFormString = "[PM]GUISYS560";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_CWSForm_IsValid()
        {
            string openFormString = "[CWS]GUISYS560";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_MSOForm_IsValid()
        {
            string openFormString = "[MSO]GUISYS560";
            Assert.IsTrue(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }

        [TestMethod]
        public void IsValidOpenFormString_OtherForm_NotValid()
        {
            string openFormString = "[INCIDENT]GUISYS560";
            Assert.IsFalse(ScriptLinkHelpers.IsValidOpenFormString(openFormString));
        }
    }
}
