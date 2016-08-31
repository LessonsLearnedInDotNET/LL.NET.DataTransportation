using System;

namespace LL.NET.DataTransportation.Core.Transports.Content.Text
{
    /// <summary>
    /// Defines the interface of a data transport object that sends and 
    /// receives data in text format.
    /// </summary>
    public interface ITextDataTransport
    {
        /// <summary>
        /// Transports a <see cref="string"/> of text using an established connection.
        /// </summary>
        /// <param name="data">An array of <see cref="byte"/>s</param>
        void Send(string data);

        /// <summary>
        /// An event that is raised when a <see cref="string"/> of text is
        /// received on an established connection.
        /// </summary>
        event EventHandler<StringEventArgs> DataReceived;
    }
}
