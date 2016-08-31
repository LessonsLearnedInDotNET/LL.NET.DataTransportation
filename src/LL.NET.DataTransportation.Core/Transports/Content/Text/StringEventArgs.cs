using System;

namespace LL.NET.DataTransportation.Core.Transports.Content.Text
{
    /// <summary>
    /// An event argument that holds an <see cref="string"/> of text
    /// </summary>
    public class StringEventArgs : EventArgs
    {
        /// <summary>
        /// An immutable <see cref="string"/> of text data.
        /// </summary>
        public string Data { get; private set; }

        public StringEventArgs(string data)
        {
            Data = data;
        }
    }
}
