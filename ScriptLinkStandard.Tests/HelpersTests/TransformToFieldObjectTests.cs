using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class TransformToFieldObjectTests
    {
        [TestMethod]
        [TestCategory("FieldObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void FieldObjectFromJson_NullString()
        {
            string json = null;
            FieldObject expected = new FieldObject();
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToFieldObject(json));
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjectFromJson_Success()
        {
            string json = "{\"Enabled\":\"0\",\"FieldNumber\":\"1\",\"FieldValue\":\"\",\"Lock\":\"0\",\"Required\":\"0\"}";
            FieldObject expected = new FieldObject
            {
                FieldNumber = "1"
            };
            FieldObject actual = (FieldObject)ScriptLinkHelpers.TransformToFieldObject(json);
            Assert.IsNotNull(actual.FieldNumber);
            Assert.AreEqual(expected.FieldNumber, actual.FieldNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjectFromJson_Failure()
        {
            string json = "{\"Enabled\":\"0\",\"FieldNumber\":\"2\",\"FieldValue\":\"\",\"Lock\":\"0\",\"Required\":\"0\"}";
            FieldObject expected = new FieldObject
            {
                FieldNumber = "1"
            };
            FieldObject actual = (FieldObject)ScriptLinkHelpers.TransformToFieldObject(json);
            Assert.IsNotNull(actual.FieldNumber);
            Assert.AreNotEqual(expected.FieldNumber, actual.FieldNumber);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjectFromXml_Success()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                       + "<FieldObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                       + "  <Enabled>0</Enabled>" + Environment.NewLine
                       + "  <FieldNumber>1</FieldNumber>" + Environment.NewLine
                       + "  <FieldValue />" + Environment.NewLine
                       + "  <Lock>0</Lock>" + Environment.NewLine
                       + "  <Required>0</Required>" + Environment.NewLine
                       + "</FieldObject>";
            FieldObject expected = new FieldObject
            {
                FieldNumber = "1"
            };
            FieldObject actual = (FieldObject)ScriptLinkHelpers.TransformToFieldObject(xml);
            Assert.IsNotNull(actual.FieldNumber);
            Assert.AreEqual(expected.FieldNumber, actual.FieldNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjectFromXml_Failure()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                       + "<FieldObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                       + "  <Enabled>0</Enabled>" + Environment.NewLine
                       + "  <FieldNumber>2</FieldNumber>" + Environment.NewLine
                       + "  <FieldValue />" + Environment.NewLine
                       + "  <Lock>0</Lock>" + Environment.NewLine
                       + "  <Required>0</Required>" + Environment.NewLine
                       + "</FieldObject>";
            FieldObject expected = new FieldObject
            {
                FieldNumber = "1"
            };
            FieldObject actual = (FieldObject)ScriptLinkHelpers.TransformToFieldObject(xml);
            Assert.IsNotNull(actual.FieldNumber);
            Assert.AreNotEqual(expected.FieldNumber, actual.FieldNumber);
            Assert.AreNotEqual(expected, actual);
        }
    }
}
