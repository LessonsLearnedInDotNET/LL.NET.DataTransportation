using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LL.NET.DataTransportation.Core.Transports.Http
{
    /// <summary>
    /// Defines the interface of an http data transport object that sends and 
    /// receives data via HTTP. The follow interface is intended to be thread safe.
    /// </summary>
    public interface IHttpDataTransport
    {
        /// <summary>
        /// Cancel all pending requests on this instance. Transport can still
        /// be used to make additional requests.
        /// </summary>
        void CancelPendingRequests();

        /// <summary>
        /// Send an asynchronous DELETE request to the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> DeleteAsync(string uri);

        /// <summary>
        /// Send and asynchronous DELETE request to the specied <paramref name="uri"/>
        /// with a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> DeleteAsync(string uri, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous DELETE request to the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The <see cref="Uri"/> where the request will be sent.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> DeleteAsync(Uri uri);

        /// <summary>
        /// Send and asynchronous DELETE request to the specied <paramref name="uri"/>
        /// with a cancellation token.
        /// </summary>
        /// <param name="uri">The <see cref="Uri"/> where the request will be sent.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> DeleteAsync(Uri uri, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous GET request to the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(string uri);

        /// <summary>
        /// Send and asynchronous GET request to the specied <paramref name="uri"/>
        /// with a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(string uri, CancellationToken cancellationToken);

        /// <summary>
        /// Send and asynchronous GET request to the specied <paramref name="uri"/>
        /// with an HTTP completion option.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpCompletionOption">
        /// An HTTP completion option value that indicates when the operation should
        /// be considered completed.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(string uri, HttpCompletionOption httpCompletionOption);

        /// <summary>
        /// Send and asynchronous GET request to the specied <paramref name="uri"/>
        /// with an HTTP completion option and a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpCompletionOption">
        /// An HTTP completion option value that indicates when the operation should
        /// be considered completed.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(string uri, HttpCompletionOption httpCompletionOption, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous GET request to the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(Uri uri);

        /// <summary>
        /// Send and asynchronous GET request to the specied <paramref name="uri"/>
        /// with a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(Uri uri, CancellationToken cancellationToken);

        /// <summary>
        /// Send and asynchronous GET request to the specied <paramref name="uri"/>
        /// with an HTTP completion option.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpCompletionOption">
        /// An HTTP completion option value that indicates when the operation should
        /// be considered completed.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(Uri uri, HttpCompletionOption httpCompletionOption);

        /// <summary>
        /// Send and asynchronous GET request to the specied <paramref name="uri"/>
        /// with an HTTP completion option and a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpCompletionOption">
        /// An HTTP completion option value that indicates when the operation should
        /// be considered completed.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> GetAsync(Uri uri, HttpCompletionOption httpCompletionOption, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous GET request to the specified <paramref name="uri"/> 
        /// and returns the response body as a <see cref="byte"/> array.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>A <see cref="Task{byte[]}"/> representing the asynchronous operation.</returns>
        Task<byte[]> GetByteArrayAsync(string uri);

        /// <summary>
        /// Send an asynchronous GET request to the specified <paramref name="uri"/> 
        /// and returns the response body as a <see cref="byte"/> array.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>A <see cref="Task{byte[]}"/> representing the asynchronous operation.</returns>
        Task<byte[]> GetByteArrayAsync(Uri uri);

        /// <summary>
        /// Send an asynchronous GET request to the specified <paramref name="uri"/> 
        /// and returns the response body as a <see cref="Stream"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>A <see cref="Task{Stream}"/> representing the asynchronous operation.</returns>
        Task<Stream> GetStreamAsync(string uri);

        /// <summary>
        /// Send an asynchronous GET request to the specified <paramref name="uri"/> 
        /// and returns the response body as a <see cref="Stream"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>A <see cref="Task{Stream}"/> representing the asynchronous operation.</returns>
        Task<Stream> GetStreamAsync(Uri uri);

        /// <summary>
        /// Send an asynchronous GET request to the specified <paramref name="uri"/>.
        /// and return the response body as a <see cref="string"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>A <see cref="Task{string}"/> representing the asynchronous operation.</returns>
        Task<string> GetStringAsync(string uri);

        /// <summary>
        /// Send an asynchronous GET request to the specified <paramref name="uri"/>.
        /// and return the response body as a <see cref="string"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <returns>A <see cref="Task{string}"/> representing the asynchronous operation.</returns>
        Task<string> GetStringAsync(Uri uri);

        /// <summary>
        /// Send an asynchronous POST request with content to the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpContent">The HTTP request content sent to the server.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> PostAsync(string uri, HttpContent httpContent);

        /// <summary>
        /// Send an asynchronous POST request with content to the specified <paramref name="uri"/>
        /// with a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpContent">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> PostAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous POST request with content to the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpContent">The HTTP request content sent to the server.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> PostAsync(Uri uri, HttpContent httpContent);

        /// <summary>
        /// Send an asynchronous POST request with content to the specified <paramref name="uri"/>
        /// with a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpContent">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> PostAsync(Uri uri, HttpContent httpContent, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous PUT request with content to the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpContent">The HTTP request content sent to the server.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> PutAsync(string uri, HttpContent httpContent);

        /// <summary>
        /// Send an asynchronous PUT request with content to the specified <paramref name="uri"/>
        /// with a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpContent">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> PutAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous PUT request with content to the specified <paramref name="uri"/>.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpContent">The HTTP request content sent to the server.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> PutAsync(Uri uri, HttpContent httpContent);

        /// <summary>
        /// Send an asynchronous PUT request with content to the specified <paramref name="uri"/>
        /// with a cancellation token.
        /// </summary>
        /// <param name="uri">The uri where the request will be sent.</param>
        /// <param name="httpContent">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> PutAsync(Uri uri, HttpContent httpContent, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous HTTP request.
        /// </summary>
        /// <param name="requestMessage">The HTTP request message to send.</param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage);

        /// <summary>
        /// Send an asynchronous HTTP request with an HTTP completion option.
        /// </summary>
        /// <param name="requestMessage">The HTTP request message to send.</param>
        /// <param name="httpCompletionOption">
        /// An HTTP completion option value that indicates when the operation should
        /// be considered completed.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, HttpCompletionOption httpCompletionOption);

        /// <summary>
        /// Send an asynchronous HTTP request with an HTTP completion option and
        /// a cancellation token.
        /// </summary>
        /// <param name="requestMessage">The HTTP request message to send.</param>
        /// <param name="httpCompletionOption">
        /// An HTTP completion option value that indicates when the operation should
        /// be considered completed.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, HttpCompletionOption httpCompletionOption, CancellationToken cancellationToken);

        /// <summary>
        /// Send an asynchronous HTTP request with a cancellation token.
        /// </summary>
        /// <param name="requestMessage">The HTTP request message to send.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive
        /// notice of cancellation.
        /// </param>
        /// <returns>
        /// A <see cref="Task{HttpResponse}"/> representing the asynchronous operation.
        /// </returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken);
    }
}
