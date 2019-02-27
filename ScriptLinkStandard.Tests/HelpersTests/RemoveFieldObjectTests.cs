using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class RemoveFieldObjectTests
    {
        [TestMethod]
        public void RemoveFieldObject_RowObject_ByFieldObject()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject("1||1");
            rowObject.AddFieldObject(fieldObject);
            rowObject.RemoveFieldObject(fieldObject);
            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void RemoveFieldObject_RowObject_ByFieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject("1||1");
            rowObject.AddFieldObject(fieldObject);
            rowObject.RemoveFieldObject(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void RemoveFieldObject_RowObject_ByFieldObject_NotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject("1||1");
            rowObject.RemoveFieldObject(fieldObject);
            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveFieldObject_RowObject_ByFieldNumber_NotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject("1||1");
            rowObject.RemoveFieldObject(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_RowObject_ByFieldObject_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = null;
            RowObject rowObject = new RowObject("1||1");
            rowObject.RemoveFieldObject(fieldObject);
            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_RowObject_ByFieldNumber_Null()
        {
            string fieldNumber = null;
            RowObject rowObject = new RowObject("1||1");
            rowObject.RemoveFieldObject(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveFieldObject_RowObject_Null_ByFieldObject()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = null;
            rowObject.RemoveFieldObject(fieldObject);
            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveFieldObject_RowObject_Null_ByFieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = null;
            rowObject.RemoveFieldObject(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }
    }
}
