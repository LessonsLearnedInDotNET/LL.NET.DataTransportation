using System;

namespace LL.NET.DataTransportation.Core.Transports
{
    /// <summary>
    /// Defines interface of a data transport object. All data transportation 
    /// objects will require implementation specific IO objects that should be
    /// disposed properly on end of use.
    /// </summary>
    public interface IDataTransport : IDisposable
    {
        /// <summary>
        /// Establishes a data transportation connection.
        /// </summary>
        void Connect();

        /// <summary>
        /// Closes a data transportation connection.
        /// </summary>
        void Disconnect();
    }
}
