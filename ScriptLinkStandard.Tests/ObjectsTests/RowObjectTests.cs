using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Test.ObjectsTests
{
    [TestClass]
    public class RowObjectTests
    {
        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_HasFieldsObject()
        {
            RowObject rowObject = new RowObject();
            Assert.IsNotNull(rowObject.Fields);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_FieldsObjectIsNotEmpty()
        {
            RowObject rowObject = new RowObject();
            List<FieldObject> expected = new List<FieldObject>();
            var actual = rowObject.Fields;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_AreEqual()
        {
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            RowObject rowObject2 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            Assert.IsTrue(rowObject1.Equals(rowObject2));
            Assert.IsTrue(rowObject1 == rowObject2);
            Assert.IsFalse(rowObject1 != rowObject2);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_AreNotEqual()
        {
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            RowObject rowObject2 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "3"
            };
            Assert.IsFalse(rowObject1.Equals(rowObject2));
            Assert.IsFalse(rowObject1 == rowObject2);
            Assert.IsTrue(rowObject1 != rowObject2);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_GetFieldValue_AreEqual()
        {
            string expected = "TEST";
            FieldObject fieldObject = new FieldObject
            {
                FieldNumber = "123",
                FieldValue = ""
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            rowObject1.SetFieldValue("123", expected);
            string actual = rowObject1.GetFieldValue("123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_GetFieldValue_AreNotEqual()
        {
            string expected = "TEST";
            FieldObject fieldObject = new FieldObject
            {
                FieldNumber = "123",
                FieldValue = ""
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            string actual = rowObject1.GetFieldValue("123");

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldEnabled_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsFalse(rowObject1.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldEnabled_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsTrue(rowObject1.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldLocked_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsFalse(rowObject1.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldLocked_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "1",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsTrue(rowObject1.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldPresent_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsFalse(rowObject1.IsFieldPresent("234"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldPresent_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsTrue(rowObject1.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldRequired_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsFalse(rowObject1.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldRequired_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsTrue(rowObject1.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_RemoveUnmodifiedFieldObjects()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            FieldObject fieldObject2 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "124",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            FieldObject fieldObject3 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "125",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject1);
            rowObject1.Fields.Add(fieldObject2);
            rowObject1.Fields.Add(fieldObject3);

            rowObject1.SetFieldValue("124", "MODIFIED");
            rowObject1.RemoveUnmodifiedFieldObjects();

            Assert.AreEqual(1, rowObject1.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            RowObject rowObject = new RowObject();
            var actual = rowObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_CanGetHtmlString_WithHtmlHeaders()
        {
            RowObject rowObject = new RowObject();
            var actual = rowObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }
    }
}
