using System;

namespace LL.NET.DataTransportation.Core.Binary
{
    /// <summary>
    /// An event argument that holds an array of bytes
    /// </summary>
    public class ByteArrayEventArgs : EventArgs
    {
        /// <summary>
        /// An immutable set of binary data in the form of a <see cref="byte"/> array.
        /// </summary>
        public byte[] Data { get; private set; }

        public ByteArrayEventArgs(byte[] data)
        {
            Data = data;
        }
    }
}
