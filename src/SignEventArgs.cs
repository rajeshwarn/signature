﻿using System;

namespace CodeTitans.Signature
{
    /// <summary>
    /// Arguments describing signing result.
    /// </summary>
    internal sealed class SignEventArgs : EventArgs
    {
        /// <summary>
        /// Init constructor.
        /// </summary>
        public SignEventArgs(bool success, string output, string error)
        {
            Success = success;
            Output = output;
            Error = error;
        }

        public bool Success
        {
            get;
            private set;
        }

        public string Output
        {
            get;
            private set;
        }

        public string Error
        {
            get;
            private set;
        }
    }
}
