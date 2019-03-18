using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Objects
{
    public static class ErrorCode
    {
        /// <summary>
        /// Returns provided message with an Ok button. Stops script processing.
        /// </summary>
        public static int Error { get { return 1; } }
        /// <summary>
        /// Returns provided message with Ok and Cancel buttons. Stops script processing, if Cancel is selected.
        /// </summary>
        public static int OkCancel { get { return 2; } }
        /// <summary>
        /// Returns provided message with an Ok button.
        /// </summary>
        public static int Info { get { return 3; } }
        /// <summary>
        /// Returns provided message with Yes and No buttons. Stops script processing, if No is selected.
        /// </summary>
        public static int YesNo { get { return 4; } }
        /// <summary>
        /// Opens provided Url in default web browser.
        /// </summary>
        public static int OpenUrl { get { return 5; } }
        /// <summary>
        /// Returns a message with Ok and Cancel buttons. Opens specified form(s) if OK selected. Can only be used at Form Load and on Field events.
        /// </summary>
        public static int OpenForm { get { return 6; } }
    }
}
