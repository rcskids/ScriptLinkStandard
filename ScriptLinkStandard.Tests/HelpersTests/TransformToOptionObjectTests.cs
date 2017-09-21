using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Test.HelperTests
{
    [TestClass]
    public class TransformToOptionObjectTests
    {
        private OptionObject newOptionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.newOptionObject = new OptionObject();
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectEntityIDEqualsTransformReturnEntityID()
        {
            OptionObject transformedOptionObject = newOptionObject.ToReturnOptionObject();
            Assert.AreEqual(newOptionObject.EntityID, transformedOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectEpisodeNumberEqualsTransformEpisodeNumber()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.EpisodeNumber, transformedOptionObject.EpisodeNumber);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectErrorCodeEqualsTransformErrorCode()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.ErrorCode, (int)transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void ModifiedOptionObjectInvalidValueErrorCodeTransform()
        {
            OptionObject modifiedOptionObject = new OptionObject
            {
                ErrorCode = 6
            };
            OptionObject2 transformedOptionObject = modifiedOptionObject.ToOptionObject2();
            Assert.AreEqual(modifiedOptionObject.ErrorCode, transformedOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectErrorMessageEqualsTransformErrorMessage()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.ErrorMesg, transformedOptionObject.ErrorMesg);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectFacilityEqualsTransformFacility()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.Facility, transformedOptionObject.Facility);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectOptionIdEqualsTransformOptionId()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.OptionId, transformedOptionObject.OptionId);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectStaffIdEqualsTransformStaffId()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.OptionStaffId, transformedOptionObject.OptionStaffId);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectUserIdEqualsTransformUserId()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.OptionUserId, transformedOptionObject.OptionUserId);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectSystemCodeEqualsTransformSystemCode()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.SystemCode, transformedOptionObject.SystemCode);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectFormCountEqualsTransformFormCount()
        {
            OptionObject2 transformedOptionObject = newOptionObject.ToOptionObject2();
            Assert.AreEqual(newOptionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ModifiedOptionObjectFormCountEqualsTransformFormCount()
        {
            OptionObject modifiedOptionObject = new OptionObject();
            FormObject addForm = new FormObject();
            modifiedOptionObject.Forms.Add(addForm);
            OptionObject2 transformedOptionObject = modifiedOptionObject.ToOptionObject2();
            Assert.AreEqual(modifiedOptionObject.Forms.Count, transformedOptionObject.Forms.Count);
        }
    }
}
