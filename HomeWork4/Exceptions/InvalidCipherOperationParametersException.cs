using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Exceptions
{

    internal sealed class InvalidCipherOperationParametersException : Exception
    {

        #region Constructors

        public InvalidCipherOperationParametersException(IDictionary<string, string> errors)
            : base()
        {
            foreach (var keyValuePair in errors)
            {
                Data.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        #endregion

        #region Properties

        public override string Message
        {
            get
            {
                var messageStringBuilder = new StringBuilder();
                foreach (DictionaryEntry keyValuePair in Data)
                {
                    messageStringBuilder.Append($"\"{keyValuePair.Key.ToString()}\": {keyValuePair.Value};\n");
                }
                messageStringBuilder.Remove(messageStringBuilder.Length - 1, 1);
                messageStringBuilder[messageStringBuilder.Length - 1] = '.';
                return messageStringBuilder.ToString();
            }
        }

        #endregion

    }

}