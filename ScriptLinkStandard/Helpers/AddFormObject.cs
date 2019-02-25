using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Adds a <see cref="IFormObject"/> to an <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static IOptionObject AddFormObject(IOptionObject optionObject, IFormObject formObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            return AddFormObject(optionObject.ToOptionObject2015(), formObject).ToOptionObject();
        }
        /// <summary>
        /// Creates a <see cref="IFormObject"/> with specified FormId and adds to an <see cref="IOptionObject"/> using provided FormId and indicating whether it is a multiple iteration table.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        /// <returns></returns>
        public static IOptionObject AddFormObject(IOptionObject optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return AddFormObject(optionObject.ToOptionObject2015(), formId, multipleIteration).ToOptionObject();
        }
        /// <summary>
        /// Adds a <see cref="IFormObject"/> to an <see cref="IOptionObject2"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static IOptionObject2 AddFormObject(IOptionObject2 optionObject, IFormObject formObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            return AddFormObject(optionObject.ToOptionObject2015(), formObject).ToOptionObject2();
        }
        /// <summary>
        /// Creates a <see cref="IFormObject"/> with specified FormId and adds to an <see cref="IOptionObject2"/> using provided FormId and indicating whether it is a multiple iteration table.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        /// <returns></returns>
        public static IOptionObject2 AddFormObject(IOptionObject2 optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return AddFormObject(optionObject.ToOptionObject2015(), formId, multipleIteration).ToOptionObject2();
        }
        /// <summary>
        /// Adds a <see cref="IFormObject"/> to an <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static IOptionObject2015 AddFormObject(IOptionObject2015 optionObject, IFormObject formObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            if (optionObject.Forms.Count == 0 && formObject.MultipleIteration)
                throw new ArgumentException("The first FormObject cannot be a Multiple Iteration form.");
            if (optionObject.Forms.Contains((FormObject)formObject) || optionObject.Forms.Exists(f => f.FormId == formObject.FormId))
                throw new ArgumentException("A FormObject with this FormId already exists.");
            optionObject.Forms.Add((FormObject)formObject);
            return optionObject;
        }
        /// <summary>
        /// Creates a <see cref="IFormObject"/> with specified FormId and adds to an <see cref="IOptionObject2015"/> using provided FormId and indicating whether it is a multiple iteration table.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        /// <returns></returns>
        public static IOptionObject2015 AddFormObject(IOptionObject2015 optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            FormObject formObject = new FormObject
            {
                FormId = formId,
                MultipleIteration = multipleIteration
            };
            return AddFormObject(optionObject, formObject);
        }
    }
}
