using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class TransformToOptionObject2015Tests
    {
        private OptionObject2015 newOptionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.newOptionObject = new OptionObject2015();
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectEntityIDEqualsTransformEntityID()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectEpisodeNumberEqualsTransformEpisodeNumber()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectErrorCodeEqualsTransformErrorCode()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.ErrorCode, (int)transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(ArgumentException))]
        public void ModifiedOptionObjectInvalidValueErrorCodeTransform()
        {
            OptionObject2015 modifiedOptionObject = new OptionObject2015
            {
                ErrorCode = 6
            };
            OptionObject transformedOptionObject = modifiedOptionObject.ToOptionObject();
            Assert.AreEqual(modifiedOptionObject.ErrorCode, (int)transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectErrorMessageEqualsTransformErrorMessage()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectFacilityEqualsTransformFacility()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectOptionIdEqualsTransformOptionId()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectStaffIdEqualsTransformStaffId()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectUserIdEqualsTransformUserId()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectSystemCodeEqualsTransformSystemCode()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void NewOptionObjectFormCountEqualsTransformFormCount()
        {
            OptionObject transformedOptionObject = newOptionObject.ToOptionObject();
            Assert.AreEqual(newOptionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void ModifiedOptionObjectFormCountEqualsTransformFormCount()
        {
            FormObject addForm = new FormObject();
            OptionObject2015 modifiedOptionObject = new OptionObject2015();
            modifiedOptionObject.Forms.Add(addForm);
            OptionObject transformedOptionObject = modifiedOptionObject.ToOptionObject();
            Assert.AreEqual(modifiedOptionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015FromJsonSuccess()
        {
            string json = "{\"EntityID\":1,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2015 expected = new OptionObject2015
            {
                EntityID = "1"
            };
            OptionObject2015 actual = (OptionObject2015)ScriptLinkHelpers.TransformToOptionObject2015(json);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreEqual(expected.EntityID, actual.EntityID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015FromJsonFailure()
        {
            string json = "{\"EntityID\":2,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            OptionObject2015 expected = new OptionObject2015
            {
                EntityID = "1"
            };
            OptionObject2015 actual = (OptionObject2015)ScriptLinkHelpers.TransformToOptionObject2015(json);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreNotEqual(expected.EntityID, actual.EntityID);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015FromXmlSuccess()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2015 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EntityID>1</EntityID>" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2015>";
            OptionObject2015 expected = new OptionObject2015
            {
                EntityID = "1"
            };
            OptionObject2015 actual = (OptionObject2015)ScriptLinkHelpers.TransformToOptionObject2015(xml);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreEqual(expected.EntityID, actual.EntityID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015FromXmlFailure()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2015 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EntityID>2</EntityID>" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2015>";
            OptionObject2015 expected = new OptionObject2015
            {
                EntityID = "1"
            };
            OptionObject2015 actual = (OptionObject2015)ScriptLinkHelpers.TransformToOptionObject2015(xml);
            Assert.IsNotNull(actual.EntityID);
            Assert.AreNotEqual(expected.EntityID, actual.EntityID);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
