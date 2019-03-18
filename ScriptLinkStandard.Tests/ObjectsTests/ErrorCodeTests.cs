using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.ObjectsTests
{
    [TestClass]
    public class ErrorCodeTests
    {
        [TestMethod]
        public void ErrorCode_Error_Returns_1()
        {
            int expected = 1;
            Assert.AreEqual(expected, ErrorCode.Error);
        }

        [TestMethod]
        public void ErrorCode_OkCancel_Returns_2()
        {
            int expected = 2;
            Assert.AreEqual(expected, ErrorCode.OkCancel);
        }

        [TestMethod]
        public void ErrorCode_Info_Returns_3()
        {
            int expected = 3;
            Assert.AreEqual(expected, ErrorCode.Info);
        }

        [TestMethod]
        public void ErrorCode_YesNo_Returns_4()
        {
            int expected = 4;
            Assert.AreEqual(expected, ErrorCode.YesNo);
        }

        [TestMethod]
        public void ErrorCode_OpenUrl_Returns_5()
        {
            int expected = 5;
            Assert.AreEqual(expected, ErrorCode.OpenUrl);
        }

        [TestMethod]
        public void ErrorCode_OpenForm_Returns_6()
        {
            int expected = 6;
            Assert.AreEqual(expected, ErrorCode.OpenForm);
        }
    }
}
