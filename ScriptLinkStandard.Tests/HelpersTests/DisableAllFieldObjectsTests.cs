using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class DisableAllFieldObjectsTests
    {
        private IOptionObject optionObject;
        private IOptionObject2 optionObject2;

        [TestInitialize]
        public void TestInitialize()
        {
            IFieldObject addField = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "100",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };

            IRowObject currentRow = new RowObject();
            currentRow.Fields.Add((FieldObject)addField);
            currentRow.Fields.Add((FieldObject)addField);
            currentRow.Fields.Add((FieldObject)addField);
            currentRow.ParentRowId = "";
            currentRow.RowAction = "";
            currentRow.RowId = "1";

            IRowObject otherRow1 = new RowObject();
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.ParentRowId = "1";
            otherRow1.RowAction = "";
            otherRow1.RowId = "2";

            IRowObject otherRow2 = new RowObject();
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.ParentRowId = "1";
            otherRow2.RowAction = "";
            otherRow2.RowId = "3";

            IFormObject primaryForm = new FormObject
            {
                CurrentRow = (RowObject)currentRow,
                FormId = "1",
                MultipleIteration = false
            };

            IFormObject multipleIterationForm = new FormObject
            {
                CurrentRow = null,
                FormId = "2",
                MultipleIteration = true
            };
            multipleIterationForm.OtherRows.Add((RowObject)otherRow1);
            multipleIterationForm.OtherRows.Add((RowObject)otherRow2);

            this.optionObject = new OptionObject();

            optionObject.EntityID = "123456";
            optionObject.EpisodeNumber = 1;
            optionObject.Facility = "1";
            optionObject.Forms.Add((FormObject)primaryForm);
            optionObject.Forms.Add((FormObject)multipleIterationForm);
            optionObject.OptionId = "USER00";
            optionObject.OptionStaffId = "1234";
            optionObject.OptionUserId = "username";
            optionObject.SystemCode = "UAT";

            this.optionObject2 = new OptionObject2();

            optionObject2.EntityID = "123456";
            optionObject2.EpisodeNumber = 1;
            optionObject2.Facility = "1";
            optionObject2.Forms.Add((FormObject)primaryForm);
            optionObject2.Forms.Add((FormObject)multipleIterationForm);
            optionObject2.NamespaceName = "NAMESPACE";
            optionObject2.OptionId = "USER00";
            optionObject2.OptionStaffId = "1234";
            optionObject2.OptionUserId = "username";
            optionObject2.ParentNamespace = "PARENTNAMESPACE";
            optionObject2.ServerName = "SERVERNAME";
            optionObject2.SystemCode = "UAT";
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_EntityID_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.EntityID, returnOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_EntityID_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.EntityID, returnOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_EpisodeNumber_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.EpisodeNumber, returnOptionObject.EpisodeNumber);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_EpisodeNumber_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.EpisodeNumber, returnOptionObject.EpisodeNumber);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_Facility_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.Facility, returnOptionObject.Facility);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_Facility_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.Facility, returnOptionObject.Facility);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_NamespaceName_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.NamespaceName, returnOptionObject.NamespaceName);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_OptionID_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.OptionId, returnOptionObject.OptionId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_OptionID_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.OptionId, returnOptionObject.OptionId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_OptionStaffID_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.OptionStaffId, returnOptionObject.OptionStaffId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_OptionStaffID_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.OptionStaffId, returnOptionObject.OptionStaffId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_OptionUserID_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.OptionUserId, returnOptionObject.OptionUserId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_OptionUserID_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.OptionUserId, returnOptionObject.OptionUserId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_ParentNamespace_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.ParentNamespace, returnOptionObject.ParentNamespace);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_ServerName_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.ServerName, returnOptionObject.ServerName);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_SystemCode_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.SystemCode, returnOptionObject.SystemCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_SystemCode_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.SystemCode, returnOptionObject.SystemCode);
        }




        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_FormCount_AreEqual()
        {
            IOptionObject returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.Forms.Count, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_FormCount_AreEqual()
        {
            IOptionObject2 returnOptionObject = ScriptLinkHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.Forms.Count, returnOptionObject.Forms.Count);
        }
    }
}
