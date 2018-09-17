using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class TransformToXmlTests
    {
        [TestMethod]
        public void OptionObjectTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject>";
            Assert.AreEqual(expected, new OptionObject().ToXml());
            Assert.AreEqual(expected.GetType(), new OptionObject().ToXml().GetType());
        }

        [TestMethod]
        public void OptionObjectHelperTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToXml(new OptionObject()));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToXml(new OptionObject()).GetType());
        }

        [TestMethod]
        public void OptionObject2TransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2>";
            Assert.AreEqual(expected, new OptionObject2().ToXml());
            Assert.AreEqual(expected.GetType(), new OptionObject2().ToXml().GetType());
        }

        [TestMethod]
        public void OptionObject2HelperTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToXml(new OptionObject2()));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToXml(new OptionObject2()).GetType());
        }

        [TestMethod]
        public void OptionObject2015TransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2015 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2015>";
            Assert.AreEqual(expected, new OptionObject2015().ToXml());
            Assert.AreEqual(expected.GetType(), new OptionObject2015().ToXml().GetType());
        }

        [TestMethod]
        public void OptionObject2015HelperTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<OptionObject2015 xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <EpisodeNumber>0</EpisodeNumber>" + Environment.NewLine
                            + "  <ErrorCode>0</ErrorCode>" + Environment.NewLine
                            + "  <Forms />" + Environment.NewLine
                            + "</OptionObject2015>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToXml(new OptionObject2015()));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToXml(new OptionObject2015()).GetType());
        }

        [TestMethod]
        public void FormObjectTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<FormObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <MultipleIteration>false</MultipleIteration>" + Environment.NewLine
                            + "  <OtherRows />" + Environment.NewLine
                            + "</FormObject>";
            Assert.AreEqual(expected, new FormObject().ToXml());
            Assert.AreEqual(expected.GetType(), new FormObject().ToXml().GetType());
        }

        [TestMethod]
        public void FormObjectHelperTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<FormObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <MultipleIteration>false</MultipleIteration>" + Environment.NewLine
                            + "  <OtherRows />" + Environment.NewLine
                            + "</FormObject>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToXml(new FormObject()));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToXml(new FormObject()).GetType());
        }

        [TestMethod]
        public void RowObjectTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<RowObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <Fields />" + Environment.NewLine
                            + "</RowObject>";
            Assert.AreEqual(expected, new RowObject().ToXml());
            Assert.AreEqual(expected.GetType(), new RowObject().ToXml().GetType());
        }

        [TestMethod]
        public void RowObjectHelperTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<RowObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <Fields />" + Environment.NewLine
                            + "</RowObject>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToXml(new RowObject()));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToXml(new RowObject()).GetType());
        }

        [TestMethod]
        public void FieldObjectTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<FieldObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <Enabled>0</Enabled>" + Environment.NewLine
                            + "  <FieldNumber />" + Environment.NewLine
                            + "  <FieldValue />" + Environment.NewLine
                            + "  <Lock>0</Lock>" + Environment.NewLine
                            + "  <Required>0</Required>" + Environment.NewLine
                            + "</FieldObject>";
            Assert.AreEqual(expected, new FieldObject().ToXml());
            Assert.AreEqual(expected.GetType(), new FieldObject().ToXml().GetType());
        }

        [TestMethod]
        public void FieldObjectHelperTransformToXmlIsString()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + Environment.NewLine
                            + "<FieldObject xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine
                            + "  <Enabled>0</Enabled>" + Environment.NewLine
                            + "  <FieldNumber />" + Environment.NewLine
                            + "  <FieldValue />" + Environment.NewLine
                            + "  <Lock>0</Lock>" + Environment.NewLine
                            + "  <Required>0</Required>" + Environment.NewLine
                            + "</FieldObject>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToXml(new FieldObject()));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToXml(new FieldObject()).GetType());
        }
    }
}
