using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Test.HelpersTests
{
    [TestClass]
    public class GetReturnOptionObjectTests
    {
        private IOptionObject optionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.optionObject = new OptionObject();

            optionObject.EntityID = "123456";
            optionObject.EpisodeNumber = 1;
            optionObject.Facility = "1";
            optionObject.OptionId = "USER00";
            optionObject.OptionStaffId = "1234";
            optionObject.OptionUserId = "username";
            optionObject.SystemCode = "UAT";
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_EntityID_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject);
            Assert.AreEqual(optionObject.EntityID, returnOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_EpisodeNumber_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject);
            Assert.AreEqual(optionObject.EpisodeNumber, returnOptionObject.EpisodeNumber);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_Facility_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject);
            Assert.AreEqual(optionObject.Facility, returnOptionObject.Facility);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_OptionId_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject);
            Assert.AreEqual(optionObject.OptionId, returnOptionObject.OptionId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_OptionStaffId_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject);
            Assert.AreEqual(optionObject.OptionStaffId, returnOptionObject.OptionStaffId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_OptionUserId_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject);
            Assert.AreEqual(optionObject.OptionUserId, returnOptionObject.OptionUserId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_SystemCode_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject);
            Assert.AreEqual(optionObject.SystemCode, returnOptionObject.SystemCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorMessage_AreEqual()
        {
            string expected = "Hello World!";
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, 1, expected);
            Assert.AreEqual(expected, returnOptionObject.ErrorMesg);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_Default_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject);
            Assert.AreEqual(0, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_0_AreEqual()
        {
            int expected = 0;
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_1_AreEqual()
        {
            int expected = 1;
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_2_AreEqual()
        {
            int expected = 2;
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_3_AreEqual()
        {
            int expected = 3;
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_4_AreEqual()
        {
            int expected = 4;
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void GetReturnOptionObject_ErrorCode_5_AreEqual()
        {
            int expected = 5;
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, expected, "test");
            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void GetReturnOptionObject_ErrorCode_6_Error()
        {
            int expected = 6;
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, expected, "test");
            Assert.AreNotEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void GetReturnOptionObject_ErrorCode_Negative1_Error()
        {
            int expected = -1;
            IOptionObject returnOptionObject = ScriptLinkHelpers.GetReturnOptionObject(optionObject, expected, "test");
            Assert.AreNotEqual(expected, returnOptionObject.ErrorCode);
        }
    }
}
