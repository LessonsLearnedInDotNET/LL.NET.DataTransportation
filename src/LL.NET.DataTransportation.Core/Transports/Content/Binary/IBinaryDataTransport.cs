using System;

namespace LL.NET.DataTransportation.Core.Transports.Content.Binary
{
    /// <summary>
    /// Defines the interface of a data transport object that sends and 
    /// receives data in binary format.
    /// </summary>
    public interface IBinaryDataTransport : IDataTransport
    {
        /// <summary>
        /// Transports an array of bytes using an established connection.
        /// </summary>
        /// <param name="data">An array of <see cref="byte"/>s</param>
        void Send(byte[] data);

        /// <summary>
        /// An event that is raised when an array of bytes are received on an 
        /// established connection.
        /// </summary>
        event EventHandler<ByteArrayEventArgs> DataReceived;
    }
}
