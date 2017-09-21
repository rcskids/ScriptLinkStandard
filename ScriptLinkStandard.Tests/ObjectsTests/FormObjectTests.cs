using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Test.EntitiesTests
{
    [TestClass]
    public class FormObjectTests
    {
        private FormObject formObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.formObject = new FormObject();
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void NewFormObjectHasOtherRowsObject()
        {
            Assert.IsNotNull(formObject.OtherRows);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void NewFormObjectOtherRowsObjectIsNotEmpty()
        {
            List<RowObject> expected = new List<RowObject>();
            var actual = formObject.OtherRows;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void NewFormObjectDefaultMultipleIterationIsFalse()
        {
            Assert.IsFalse(formObject.MultipleIteration);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void NewFormObjectCanSetMultipleIterationToTrue()
        {
            var modifiedFormObject = new FormObject();
            modifiedFormObject.MultipleIteration = true;
            Assert.IsTrue(modifiedFormObject.MultipleIteration);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void NewFormObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            var actual = formObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void NewFormObject_CanGetHtmlString_WithHtmlHeaders()
        {
            var actual = formObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void NewFormObject_GetCurrentRowId()
        {
            var actual = formObject.GetCurrentRowId();
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void NewFormObject_GetParentRowId()
        {
            var actual = formObject.GetParentRowId();
            Assert.AreEqual(null, actual);
        }
    }
}
