using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class TransformToJsonTests
    {
        [TestMethod]
        public void OptionObjectTransformToJsonIsString()
        {
            OptionObject optionObject = new OptionObject();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"SystemCode\":null}";
            Assert.AreEqual(expected, optionObject.ToJson());
            Assert.AreEqual(expected.GetType(), optionObject.ToJson().GetType());
        }

        [TestMethod]
        public void OptionObjectHelperTransformToJsonIsString()
        {
            OptionObject optionObject = new OptionObject();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"SystemCode\":null}";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToJson(optionObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToJson(optionObject).GetType());
        }

        [TestMethod]
        public void OptionObject2TransformToJsonIsString()
        {
            OptionObject2 optionObject = new OptionObject2();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null}";
            Assert.AreEqual(expected, optionObject.ToJson());
            Assert.AreEqual(expected.GetType(), optionObject.ToJson().GetType());
        }

        [TestMethod]
        public void OptionObject2HelperTransformToJsonIsString()
        {
            OptionObject2 optionObject = new OptionObject2();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null}";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToJson(optionObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToJson(optionObject).GetType());
        }

        [TestMethod]
        public void OptionObject2015TransformToJsonIsString()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            Assert.AreEqual(expected, optionObject.ToJson());
            Assert.AreEqual(expected.GetType(), optionObject.ToJson().GetType());
        }

        [TestMethod]
        public void OptionObject2015HelperTransformToJsonIsString()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            string expected = "{\"EntityID\":null,\"EpisodeNumber\":0.0,\"ErrorCode\":0.0,\"ErrorMesg\":null,\"Facility\":null,\"Forms\":[],\"NamespaceName\":null,\"OptionId\":null,\"OptionStaffId\":null,\"OptionUserId\":null,\"ParentNamespace\":null,\"ServerName\":null,\"SystemCode\":null,\"SessionToken\":null}";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToJson(optionObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToJson(optionObject).GetType());
        }
    }
}
