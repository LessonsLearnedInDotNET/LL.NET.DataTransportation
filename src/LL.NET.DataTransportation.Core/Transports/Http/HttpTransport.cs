using System;
using System.Net.Http;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace LL.NET.DataTransportation.Core.Transports.Http
{
    /// <summary>
    /// Provides a wrapper for thread safe operations on <see cref="HttpClient"/>.
    /// </summary>
    public class HttpTransport : IHttpDataTransport
    {
        /// <summary>
        /// A static <see cref="HttpClient"/> instance for reuse during the 
        /// lifetime of the <see cref="HttpTransport"/> instance. <see cref="HttpClient"/>
        /// inherits from <see cref="IDisposable"/>, but it wasn't designed
        /// with the intention to be disposed after each use. Disposing of
        /// a <see cref="HttpClient"/> causes sockets to be left in a waiting
        /// state for <see cref="HttpClient.Timeout"/> milliseconds before the
        /// operating system properly closes the connection on the socket.
        /// Keeping the instance of HttpClient alive allows the socket to be
        /// reused.
        /// </summary>
        public static HttpClient Client = new HttpClient();

        public void CancelPendingRequests()
        {
            Client.CancelPendingRequests();
        }

        public Task<HttpResponseMessage> DeleteAsync(string uri)
        {
            return Client.DeleteAsync(uri);
        }

        public Task<HttpResponseMessage> DeleteAsync(string uri, CancellationToken cancellationToken)
        {
            return Client.DeleteAsync(uri, cancellationToken);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri uri)
        {
            return Client.DeleteAsync(uri);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri uri, CancellationToken cancellationToken)
        {
            return Client.DeleteAsync(uri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(string uri)
        {
            return Client.GetAsync(uri);
        }

        public Task<HttpResponseMessage> GetAsync(string uri, CancellationToken cancellationToken)
        {
            return Client.GetAsync(uri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(string uri, HttpCompletionOption httpCompletionOption)
        {
            return Client.GetAsync(uri, httpCompletionOption);
        }

        public Task<HttpResponseMessage> GetAsync(string uri, HttpCompletionOption httpCompletionOption, CancellationToken cancellationToken)
        {
            return Client.GetAsync(uri, httpCompletionOption, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(Uri uri)
        {
            return Client.GetAsync(uri);
        }

        public Task<HttpResponseMessage> GetAsync(Uri uri, CancellationToken cancellationToken)
        {
            return Client.GetAsync(uri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(Uri uri, HttpCompletionOption httpCompletionOption)
        {
            return Client.GetAsync(uri, httpCompletionOption);
        }

        public Task<HttpResponseMessage> GetAsync(Uri uri, HttpCompletionOption httpCompletionOption, CancellationToken cancellationToken)
        {
            return Client.GetAsync(uri, httpCompletionOption, cancellationToken);
        }

        public Task<byte[]> GetByteArrayAsync(string uri)
        {
            return Client.GetByteArrayAsync(uri);
        }

        public Task<byte[]> GetByteArrayAsync(Uri uri)
        {
            return Client.GetByteArrayAsync(uri);
        }

        public Task<Stream> GetStreamAsync(string uri)
        {
            return Client.GetStreamAsync(uri);
        }

        public Task<Stream> GetStreamAsync(Uri uri)
        {
            return Client.GetStreamAsync(uri);
        }

        public Task<string> GetStringAsync(string uri)
        {
            return Client.GetStringAsync(uri);
        }

        public Task<string> GetStringAsync(Uri uri)
        {
            return Client.GetStringAsync(uri);
        }

        public Task<HttpResponseMessage> PostAsync(string uri, HttpContent httpContent)
        {
            return Client.PostAsync(uri, httpContent);
        }

        public Task<HttpResponseMessage> PostAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken)
        {
            return Client.PostAsync(uri, httpContent, cancellationToken);
        }

        public Task<HttpResponseMessage> PostAsync(Uri uri, HttpContent httpContent)
        {
            return Client.PostAsync(uri, httpContent);
        }

        public Task<HttpResponseMessage> PostAsync(Uri uri, HttpContent httpContent, CancellationToken cancellationToken)
        {
            return Client.PostAsync(uri, httpContent, cancellationToken);
        }

        public Task<HttpResponseMessage> PutAsync(string uri, HttpContent httpContent)
        {
            return Client.PutAsync(uri, httpContent);
        }

        public Task<HttpResponseMessage> PutAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken)
        {
            return Client.PutAsync(uri, httpContent, cancellationToken);
        }

        public Task<HttpResponseMessage> PutAsync(Uri uri, HttpContent httpContent)
        {
            return Client.PutAsync(uri, httpContent);
        }

        public Task<HttpResponseMessage> PutAsync(Uri uri, HttpContent httpContent, CancellationToken cancellationToken)
        {
            return Client.PutAsync(uri, httpContent, cancellationToken);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage)
        {
            return Client.SendAsync(requestMessage);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, HttpCompletionOption httpCompletionOption)
        {
            return Client.SendAsync(requestMessage, httpCompletionOption);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, HttpCompletionOption httpCompletionOption, CancellationToken cancellationToken)
        {
            return Client.SendAsync(requestMessage, httpCompletionOption, cancellationToken);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            return Client.SendAsync(requestMessage, cancellationToken);
        }
    }
}
