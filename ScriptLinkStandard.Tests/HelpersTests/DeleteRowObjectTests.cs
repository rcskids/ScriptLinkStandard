using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class DeleteRowObjectTests
    {
        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromOptionObject_RowObject_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject optionObject = new OptionObject();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject_RowObject_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject optionObject = new OptionObject();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromOptionObject_RowId_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject optionObject = new OptionObject();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject_RowId_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject optionObject = new OptionObject();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }
        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromOptionObject2_RowObject_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject2_RowObject_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromOptionObject2_RowId_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject2_RowId_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject);

            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }
        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromFormObject_RowObject_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject);

            Assert.IsTrue(formObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromFormObject_RowObject_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromFormObject_RowId_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromFormObject_RowId_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromOptionObject_MI_RowObject_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new OptionObject();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            optionObject.DeleteRowObject(rowObject1);
            optionObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject_MI_RowObject_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new OptionObject();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new RowObject
            {
                RowId = "2||4"
            };

            optionObject.DeleteRowObject(rowObject4);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject4.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject4.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromOptionObject_MI_RowId_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new OptionObject();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            optionObject.DeleteRowObject(rowObject1.RowId);
            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject_MI_RowId_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject optionObject = new OptionObject();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new RowObject
            {
                RowId = "2||4"
            };

            optionObject.DeleteRowObject(rowObject4.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject4.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject4.RowId));
        }
        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromOptionObject2_MI_RowObject_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            optionObject.DeleteRowObject(rowObject1.RowId);
            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject2_MI_RowObject_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new RowObject
            {
                RowId = "2||4"
            };

            optionObject.DeleteRowObject(rowObject4);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject4.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject4.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject2_MI_RowId_IsFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject1);

            optionObject.DeleteRowObject(rowObject1.RowId);
            optionObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(optionObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromOptionObject2_MI_RowId_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject1.CurrentRow = rowObject;
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject2.CurrentRow = rowObject1;
            formObject2.OtherRows.Add(rowObject2);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject1);
            optionObject.Forms.Add(formObject2);

            RowObject rowObject4 = new RowObject
            {
                RowId = "2||4"
            };

            optionObject.DeleteRowObject(rowObject4.RowId);

            Assert.IsTrue(optionObject.IsRowPresent(rowObject4.RowId));
            Assert.IsTrue(optionObject.IsRowMarkedForDeletion(rowObject4.RowId));
        }
        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromFormObject_MI_RowObject_IsFound()
        {
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject = new FormObject
            {
                FormId = "2",
                MultipleIteration = true
            };
            formObject.CurrentRow = rowObject1;
            formObject.OtherRows.Add(rowObject2);

            formObject.DeleteRowObject(rowObject1);
            formObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(formObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromFormObject_MI_RowObject_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject = new FormObject
            {
                FormId = "2",
                MultipleIteration = true
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject2);

            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        public void DeleteRowObject_FromFormObject_MI_RowId_IsFound()
        {
            RowObject rowObject1 = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "2",
                MultipleIteration = true
            };
            formObject.CurrentRow = rowObject1;
            formObject.OtherRows.Add(rowObject2);

            formObject.DeleteRowObject(rowObject1.RowId);
            formObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject1.RowId));
            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteRowObject_FromFormObject_MI_RowId_IsNotFound()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "2||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "2||2"
            };
            FormObject formObject = new FormObject
            {
                FormId = "2",
                MultipleIteration = true
            };
            formObject.CurrentRow = rowObject;

            formObject.DeleteRowObject(rowObject2.RowId);

            Assert.IsTrue(formObject.IsRowPresent(rowObject2.RowId));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion(rowObject2.RowId));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteRowObject_FromOptionObject_Null()
        {
            OptionObject optionObject = null;
            optionObject.DeleteRowObject("1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteRowObject_FromOptionObject2_Null()
        {
            OptionObject2 optionObject = null;
            optionObject.DeleteRowObject("1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteRowObject_FromOptionObject2015_Null()
        {
            OptionObject2015 optionObject = null;
            optionObject.DeleteRowObject("1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteRowObject_FromFormObject_Null()
        {
            FormObject formObject = null;
            formObject.DeleteRowObject("1||1");
            Assert.IsFalse(formObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_Helper_FromOptionObject_Null()
        {
            OptionObject optionObject = null;
            ScriptLinkHelpers.DeleteRowObject(optionObject, "1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_Helper_FromOptionObject2_Null()
        {
            OptionObject2 optionObject = null;
            ScriptLinkHelpers.DeleteRowObject(optionObject, "1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_Helper_FromOptionObject2015_Null()
        {
            OptionObject2015 optionObject = null;
            ScriptLinkHelpers.DeleteRowObject(optionObject, "1||1");
            Assert.IsFalse(optionObject.IsFieldPresent("1||1"));
        }

        [TestMethod]
        [TestCategory("DeleteRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteRowObject_Helper_FromFormObject_Null()
        {
            FormObject formObject = null;
            ScriptLinkHelpers.DeleteRowObject(formObject, "1||1");
            Assert.IsFalse(formObject.IsFieldPresent("1||1"));
        }
    }
}
