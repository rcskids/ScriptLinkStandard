namespace ScriptLinkStandard.Objects
{
    public static class ErrorCode
    {
        /// <summary>
        /// Returns no message. Equivalent of success.
        /// </summary>
        public const int None = 0;
        /// <summary>
        /// Returns provided message with an Ok button. Stops script processing.
        /// </summary>
        public const int Error = 1;
        /// <summary>
        /// Returns provided message with Ok and Cancel buttons. Stops script processing, if Cancel is selected.
        /// </summary>
        public const int OkCancel = 2;
        /// <summary>
        /// Returns provided message with an Ok button.
        /// </summary>
        public const int Info = 3;
        /// <summary>
        /// Returns provided message with Yes and No buttons. Stops script processing, if No is selected.
        /// </summary>
        public const int YesNo = 4;
        /// <summary>
        /// Opens provided Url in default web browser.
        /// </summary>
        public const int OpenUrl = 5;
        /// <summary>
        /// Returns a message with Ok and Cancel buttons. Opens specified form(s) if OK selected. Can only be used at Form Load and on Field events.
        /// </summary>
        public const int OpenForm = 6;
    }
}
