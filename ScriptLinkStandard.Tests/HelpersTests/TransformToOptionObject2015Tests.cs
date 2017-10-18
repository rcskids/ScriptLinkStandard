using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
