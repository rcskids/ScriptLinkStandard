using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.ObjectsTests
{
    [TestClass]
    public class FieldObjectTests
    {
        private FieldObject newFieldObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.newFieldObject = new FieldObject();
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_CanSetAndGetEnabled()
        {
            var expected = "1";
            newFieldObject.Enabled = expected;
            var actual = newFieldObject.Enabled;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_CanSetAndGetFieldNumber()
        {
            var expected = "12345.0";
            newFieldObject.FieldNumber = expected;
            var actual = newFieldObject.FieldNumber;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_CanSetAndGetFieldValue()
        {
            var expected = "field value";
            newFieldObject.FieldValue = expected;
            var actual = newFieldObject.FieldValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_CanSetAndGetLock()
        {
            var expected = "0";
            newFieldObject.Lock = expected;
            var actual = newFieldObject.Lock;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_CanSetAndGetRequired()
        {
            var expected = "0";
            newFieldObject.Required = expected;
            var actual = newFieldObject.Required;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_AreEqual()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            FieldObject fieldObject2 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };

            Assert.IsTrue(fieldObject1.Equals(fieldObject2));
            Assert.IsTrue(fieldObject1 == fieldObject2);
            Assert.IsFalse(fieldObject1 != fieldObject2);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_AreNotEqual()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            FieldObject fieldObject2 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST DIFFERENT",
                Lock = "0",
                Required = "0"
            };

            Assert.IsFalse(fieldObject1.Equals(fieldObject2));
            Assert.IsFalse(fieldObject1 == fieldObject2);
            Assert.IsTrue(fieldObject1 != fieldObject2);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_GetFieldValue_AreEqual()
        {
            string expected = "TEST";
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = expected,
                Lock = "0",
                Required = "0"
            };
            string actual = fieldObject1.GetFieldValue();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsEnabled_IsFalse()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            Assert.IsFalse(fieldObject1.IsEnabled());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsEnabled_IsTrue()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            Assert.IsTrue(fieldObject1.IsEnabled());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsLocked_IsFalse()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            Assert.IsFalse(fieldObject1.IsLocked());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsLocked_IsTrue()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "1",
                Required = "0"
            };
            Assert.IsTrue(fieldObject1.IsLocked());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsModified_IsFalse()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            fieldObject1.FieldValue = "TEST MODIFIED";
            Assert.IsFalse(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsModified_IsTrue()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            fieldObject1.SetFieldValue("TEST MODIFIED");
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsRequired_IsFalse()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            Assert.IsFalse(fieldObject1.IsRequired());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_IsRequired_IsTrue()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            Assert.IsTrue(fieldObject1.IsRequired());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsDisabled_AreEqual()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            fieldObject1.SetAsDisabled();
            Assert.AreEqual("0", fieldObject1.Enabled);
            Assert.AreEqual("0", fieldObject1.Required);
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsEnabled_AreEqual()
        {
            string expected = "1";
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            fieldObject1.SetAsEnabled();
            Assert.AreEqual(expected, fieldObject1.Enabled);
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsLocked_AreEqual()
        {
            string expected = "1";
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            fieldObject1.SetAsLocked();
            Assert.AreEqual(expected, fieldObject1.Lock);
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsModified_AreEqual()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            fieldObject1.SetAsModified();
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsOptional_AreEqual()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            fieldObject1.SetAsOptional();
            Assert.AreEqual("1", fieldObject1.Enabled);
            Assert.AreEqual("0", fieldObject1.Required);
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsRequired_AreEqual()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            fieldObject1.SetAsRequired();
            Assert.AreEqual("1", fieldObject1.Enabled);
            Assert.AreEqual("1", fieldObject1.Required);
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObject_SetAsUnlocked_AreEqual()
        {
            string expected = "0";
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            fieldObject1.SetAsUnlocked();
            Assert.AreEqual(expected, fieldObject1.Lock);
            Assert.IsTrue(fieldObject1.IsModified());
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_CanGetHtmlString_WithoutHtmlHeaders()
        {
            var actual = newFieldObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_CanGetHtmlString_WithHtmlHeaders()
        {
            var actual = newFieldObject.ToHtmlString(true);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_Constructor_1Parameter_NoError()
        {
            string expected = "123.45";
            FieldObject fieldObject = new FieldObject(expected);
            Assert.AreEqual(expected, fieldObject.FieldNumber);
            Assert.AreEqual("", fieldObject.FieldValue);
            Assert.AreEqual("0", fieldObject.Enabled);
            Assert.AreEqual("0", fieldObject.Lock);
            Assert.AreEqual("0", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FieldObjects_Constructor_1Parameter_Error()
        {
            string expected = "";
            FieldObject fieldObject = new FieldObject(expected);
            Assert.AreEqual(expected, fieldObject.FieldNumber);
            Assert.AreEqual("", fieldObject.FieldValue);
            Assert.AreEqual("1", fieldObject.Enabled);
            Assert.AreEqual("1", fieldObject.Lock);
            Assert.AreEqual("1", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_Constructor_2Parameter_NoError()
        {
            string fieldNumber = "123.45";
            string fieldValue = "TEST";
            FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue);
            Assert.AreEqual(fieldNumber, fieldObject.FieldNumber);
            Assert.AreEqual(fieldValue, fieldObject.FieldValue);
            Assert.AreEqual("0", fieldObject.Enabled);
            Assert.AreEqual("0", fieldObject.Lock);
            Assert.AreEqual("0", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FieldObjects_Constructor_2Parameter_Error()
        {
            string fieldNumber = "";
            string fieldValue = "TEST";
            FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue);
            Assert.AreEqual(fieldNumber, fieldObject.FieldNumber);
            Assert.AreEqual(fieldValue, fieldObject.FieldValue);
            Assert.AreEqual("1", fieldObject.Enabled);
            Assert.AreEqual("1", fieldObject.Lock);
            Assert.AreEqual("1", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjects_Constructor_5Parameter_NoError()
        {
            string fieldNumber = "123.45";
            string fieldValue = "TEST";
            FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue, true, true, true);
            Assert.AreEqual(fieldNumber, fieldObject.FieldNumber);
            Assert.AreEqual(fieldValue, fieldObject.FieldValue);
            Assert.AreEqual("1", fieldObject.Enabled);
            Assert.AreEqual("1", fieldObject.Lock);
            Assert.AreEqual("1", fieldObject.Required);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FieldObjects_Constructor_5Parameter_Error()
        {
            string fieldNumber = "";
            string fieldValue = "TEST";
            FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue, true, true, true);
            Assert.AreEqual(fieldNumber, fieldObject.FieldNumber);
            Assert.AreEqual(fieldValue, fieldObject.FieldValue);
            Assert.AreEqual("1", fieldObject.Enabled);
            Assert.AreEqual("1", fieldObject.Lock);
            Assert.AreEqual("1", fieldObject.Required);
        }
    }
}
