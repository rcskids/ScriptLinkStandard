using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class TransformToHtmlStringTests
    {
        [TestMethod]
        public void OptionObjectTransformToHtmlIsString()
        {
            OptionObject optionObject = new OptionObject()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.OptionObject</h1><h2>Forms</h2>";
            Assert.AreEqual(expected, optionObject.ToHtmlString());
            Assert.AreEqual(expected.GetType(), optionObject.ToHtmlString().GetType());
        }

        [TestMethod]
        public void OptionObjectTransformToHtmlDoesNotHaveHeaders()
        {
            OptionObject optionObject = new OptionObject()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(optionObject.ToHtmlString().Contains("<html>"));
        }

        [TestMethod]
        public void OptionObjectTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            OptionObject optionObject = new OptionObject()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(optionObject.ToHtmlString(false).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObjectTransformToHtmlOverrideDoesHaveHeaders()
        {
            OptionObject optionObject = new OptionObject()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsTrue(optionObject.ToHtmlString(true).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObjectHelperTransformToHtmlIsString()
        {
            OptionObject optionObject = new OptionObject()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.OptionObject</h1><h2>Forms</h2>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToHtmlString(optionObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToHtmlString(optionObject).GetType());
        }

        [TestMethod]
        public void OptionObjectHelperTransformToHtmlDoesNotHaveHeaders()
        {
            OptionObject optionObject = new OptionObject()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(optionObject).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObjectHelperTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            OptionObject optionObject = new OptionObject()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(optionObject, false).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObjectHelperTransformToHtmlOverrideDoesHaveHeaders()
        {
            OptionObject optionObject = new OptionObject()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsTrue(ScriptLinkHelpers.TransformToHtmlString(optionObject, true).Contains("<html>"));
        }


        [TestMethod]
        public void OptionObject2TransformToHtmlIsString()
        {
            OptionObject2 optionObject = new OptionObject2()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.OptionObject2</h1><h2>Forms</h2>";
            Assert.AreEqual(expected, optionObject.ToHtmlString());
            Assert.AreEqual(expected.GetType(), optionObject.ToHtmlString().GetType());
        }

        [TestMethod]
        public void OptionObject2TransformToHtmlDoesNotHaveHeaders()
        {
            OptionObject2 optionObject = new OptionObject2()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(optionObject.ToHtmlString().Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2TransformToHtmlOverrideDoesNotHaveHeaders()
        {
            OptionObject2 optionObject = new OptionObject2()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(optionObject.ToHtmlString(false).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2TransformToHtmlOverrideDoesHaveHeaders()
        {
            OptionObject2 optionObject = new OptionObject2()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsTrue(optionObject.ToHtmlString(true).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2HelperTransformToHtmlIsString()
        {
            OptionObject2 optionObject = new OptionObject2()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.OptionObject2</h1><h2>Forms</h2>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToHtmlString(optionObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToHtmlString(optionObject).GetType());
        }

        [TestMethod]
        public void OptionObject2HelperTransformToHtmlDoesNotHaveHeaders()
        {
            OptionObject2 optionObject = new OptionObject2()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(optionObject).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2HelperTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            OptionObject2 optionObject = new OptionObject2()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(optionObject, false).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2HelperTransformToHtmlOverrideDoesHaveHeaders()
        {
            OptionObject2 optionObject = new OptionObject2()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsTrue(ScriptLinkHelpers.TransformToHtmlString(optionObject, true).Contains("<html>"));
        }


        [TestMethod]
        public void OptionObject2015TransformToHtmlIsString()
        {
            OptionObject2015 optionObject = new OptionObject2015()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.OptionObject2015</h1><h2>Forms</h2>";
            Assert.AreEqual(expected, optionObject.ToHtmlString());
            Assert.AreEqual(expected.GetType(), optionObject.ToHtmlString().GetType());
        }

        [TestMethod]
        public void OptionObject2015TransformToHtmlDoesNotHaveHeaders()
        {
            OptionObject2015 optionObject = new OptionObject2015()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(optionObject.ToHtmlString().Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2015TransformToHtmlOverrideDoesNotHaveHeaders()
        {
            OptionObject2015 optionObject = new OptionObject2015()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(optionObject.ToHtmlString(false).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2015TransformToHtmlOverrideDoesHaveHeaders()
        {
            OptionObject2015 optionObject = new OptionObject2015()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsTrue(optionObject.ToHtmlString(true).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2015HelperTransformToHtmlIsString()
        {
            OptionObject2015 optionObject = new OptionObject2015()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.OptionObject2015</h1><h2>Forms</h2>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToHtmlString(optionObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToHtmlString(optionObject).GetType());
        }

        [TestMethod]
        public void OptionObject2015HelperTransformToHtmlDoesNotHaveHeaders()
        {
            OptionObject2015 optionObject = new OptionObject2015()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(optionObject).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2015HelperTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            OptionObject2015 optionObject = new OptionObject2015()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(optionObject, false).Contains("<html>"));
        }

        [TestMethod]
        public void OptionObject2015HelperTransformToHtmlOverrideDoesHaveHeaders()
        {
            OptionObject2015 optionObject = new OptionObject2015()
            {
                EntityID = "1",
                SystemCode = "UAT"
            };
            Assert.IsTrue(ScriptLinkHelpers.TransformToHtmlString(optionObject, true).Contains("<html>"));
        }


        [TestMethod]
        public void FormObjectTransformToHtmlIsString()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            string expected = "<h1>ScriptLinkStandard.Objects.FormObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table><h2>CurrentRow</h2><h2>OtherRows</h2>";
            Assert.AreEqual(expected, formObject.ToHtmlString());
            Assert.AreEqual(expected.GetType(), formObject.ToHtmlString().GetType());
        }

        [TestMethod]
        public void FormObjectTransformToHtmlDoesNotHaveHeaders()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            Assert.IsFalse(formObject.ToHtmlString().Contains("<html>"));
        }

        [TestMethod]
        public void FormObjectTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            Assert.IsFalse(formObject.ToHtmlString(false).Contains("<html>"));
        }

        [TestMethod]
        public void FormObjectTransformToHtmlOverrideDoesHaveHeaders()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            Assert.IsTrue(formObject.ToHtmlString(true).Contains("<html>"));
        }

        [TestMethod]
        public void FormObjectHelperTransformToHtmlIsString()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            string expected = "<h1>ScriptLinkStandard.Objects.FormObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table><h2>CurrentRow</h2><h2>OtherRows</h2>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToHtmlString(formObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToHtmlString(formObject).GetType());
        }

        [TestMethod]
        public void FormObjectHelperTransformToHtmlDoesNotHaveHeaders()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(formObject).Contains("<html>"));
        }

        [TestMethod]
        public void FormObjectHelperTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(formObject, false).Contains("<html>"));
        }

        [TestMethod]
        public void FormObjectHelperTransformToHtmlOverrideDoesHaveHeaders()
        {
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            Assert.IsTrue(ScriptLinkHelpers.TransformToHtmlString(formObject, true).Contains("<html>"));
        }


        [TestMethod]
        public void RowObjectTransformToHtmlIsString()
        {
            RowObject rowObject = new RowObject()
            {
                RowId = "1"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.RowObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table><h2>Fields</h2><table></table>";
            Assert.AreEqual(expected, rowObject.ToHtmlString());
            Assert.AreEqual(expected.GetType(), rowObject.ToHtmlString().GetType());
        }

        [TestMethod]
        public void RowObjectTransformToHtmlDoesNotHaveHeaders()
        {
            RowObject rowObject = new RowObject()
            {
                RowId = "1"
            };
            Assert.IsFalse(rowObject.ToHtmlString().Contains("<html>"));
        }

        [TestMethod]
        public void RowObjectTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            RowObject rowObject = new RowObject()
            {
                RowId = "1"
            };
            Assert.IsFalse(rowObject.ToHtmlString(false).Contains("<html>"));
        }

        [TestMethod]
        public void RowObjectTransformToHtmlOverrideDoesHaveHeaders()
        {
            RowObject rowObject = new RowObject()
            {
                RowId = "1"
            };
            Assert.IsTrue(rowObject.ToHtmlString(true).Contains("<html>"));
        }

        [TestMethod]
        public void RowObjectHelperTransformToHtmlIsString()
        {
            RowObject rowObject = new RowObject()
            {
                RowId = "1"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.RowObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table><h2>Fields</h2><table></table>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToHtmlString(rowObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToHtmlString(rowObject).GetType());
        }

        [TestMethod]
        public void RowObjectHelperTransformToHtmlDoesNotHaveHeaders()
        {
            RowObject rowObject = new RowObject()
            {
                RowId = "1"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(rowObject).Contains("<html>"));
        }

        [TestMethod]
        public void RowObjectHelperTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            RowObject rowObject = new RowObject()
            {
                RowId = "1"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(rowObject, false).Contains("<html>"));
        }

        [TestMethod]
        public void RowObjectHelperTransformToHtmlOverrideDoesHaveHeaders()
        {
            RowObject rowObject = new RowObject()
            {
                RowId = "1"
            };
            Assert.IsTrue(ScriptLinkHelpers.TransformToHtmlString(rowObject, true).Contains("<html>"));
        }


        [TestMethod]
        public void FieldObjectTransformToHtmlIsString()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.FieldObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table>";
            Assert.AreEqual(expected, fieldObject.ToHtmlString());
            Assert.AreEqual(expected.GetType(), fieldObject.ToHtmlString().GetType());
        }

        [TestMethod]
        public void FieldObjectTransformToHtmlDoesNotHaveHeaders()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            Assert.IsFalse(fieldObject.ToHtmlString().Contains("<html>"));
        }

        [TestMethod]
        public void FieldObjectTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            Assert.IsFalse(fieldObject.ToHtmlString(false).Contains("<html>"));
        }

        [TestMethod]
        public void FieldObjectTransformToHtmlOverrideDoesHaveHeaders()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            Assert.IsTrue(fieldObject.ToHtmlString(true).Contains("<html>"));
        }

        [TestMethod]
        public void FieldObjectHelperTransformToHtmlIsString()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            string expected = "<h1>ScriptLinkStandard.Objects.FieldObject</h1><table><thead><tr><th>Property</th><th>Value</th></tr></thead><tbody></tbody></table>";
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToHtmlString(fieldObject));
            Assert.AreEqual(expected.GetType(), ScriptLinkHelpers.TransformToHtmlString(fieldObject).GetType());
        }

        [TestMethod]
        public void FieldObjectHelperTransformToHtmlDoesNotHaveHeaders()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(fieldObject).Contains("<html>"));
        }

        [TestMethod]
        public void FieldObjectHelperTransformToHtmlOverrideDoesNotHaveHeaders()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            Assert.IsFalse(ScriptLinkHelpers.TransformToHtmlString(fieldObject, false).Contains("<html>"));
        }

        [TestMethod]
        public void FieldObjectHelperTransformToHtmlOverrideDoesHaveHeaders()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "TEST"
            };
            Assert.IsTrue(ScriptLinkHelpers.TransformToHtmlString(fieldObject, true).Contains("<html>"));
        }
    }
}
