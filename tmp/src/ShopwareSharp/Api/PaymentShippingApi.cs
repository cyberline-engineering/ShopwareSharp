// <auto-generated>
/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace ShopwareSharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentShippingApi : IApi
    {
        /// <summary>
        /// Initiate a payment for an order
        /// </summary>
        /// <remarks>
        /// This generic endpoint is should be called to initiate a payment flow after an order has been created. The details of the payment flow can differ depending on the payment integration and might require calling additional operations or the setup of webhooks.  The endpoint internally calls the payment handler of the payment method currently set for the order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="handlePaymentMethodRequest"></param>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;object?&gt;&gt;</returns>
        Task<ApiResponse<object?>> HandlePaymentMethodWithHttpInfoAsync(HandlePaymentMethodRequest handlePaymentMethodRequest, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Initiate a payment for an order
        /// </summary>
        /// <remarks>
        /// This generic endpoint is should be called to initiate a payment flow after an order has been created. The details of the payment flow can differ depending on the payment integration and might require calling additional operations or the setup of webhooks.  The endpoint internally calls the payment handler of the payment method currently set for the order.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="handlePaymentMethodRequest"></param>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object&gt;</returns>
        Task<object?> HandlePaymentMethodAsync(HandlePaymentMethodRequest handlePaymentMethodRequest, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Initiate a payment for an order
        /// </summary>
        /// <remarks>
        /// This generic endpoint is should be called to initiate a payment flow after an order has been created. The details of the payment flow can differ depending on the payment integration and might require calling additional operations or the setup of webhooks.  The endpoint internally calls the payment handler of the payment method currently set for the order.
        /// </remarks>
        /// <param name="handlePaymentMethodRequest"></param>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object?&gt;</returns>
        Task<object?> HandlePaymentMethodOrDefaultAsync(HandlePaymentMethodRequest handlePaymentMethodRequest, System.Threading.CancellationToken? cancellationToken = null);

        
        /// <summary>
        /// Fetch shipping methods
        /// </summary>
        /// <remarks>
        /// Perform a filtered search for shipping methods.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="onlyAvailable">List only available shipping methods. This filters shipping methods methods which can not be used in the actual context because of their availability rule. (optional)</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;ReadShippingMethod200Response?&gt;&gt;</returns>
        Task<ApiResponse<ReadShippingMethod200Response?>> ReadShippingMethodWithHttpInfoAsync(bool? onlyAvailable = null, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch shipping methods
        /// </summary>
        /// <remarks>
        /// Perform a filtered search for shipping methods.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="onlyAvailable">List only available shipping methods. This filters shipping methods methods which can not be used in the actual context because of their availability rule. (optional)</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;ReadShippingMethod200Response&gt;</returns>
        Task<ReadShippingMethod200Response?> ReadShippingMethodAsync(bool? onlyAvailable = null, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// Fetch shipping methods
        /// </summary>
        /// <remarks>
        /// Perform a filtered search for shipping methods.
        /// </remarks>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="onlyAvailable">List only available shipping methods. This filters shipping methods methods which can not be used in the actual context because of their availability rule. (optional)</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;ReadShippingMethod200Response?&gt;</returns>
        Task<ReadShippingMethod200Response?> ReadShippingMethodOrDefaultAsync(bool? onlyAvailable = null, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null);

            }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentShippingApi : IPaymentShippingApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// An event to track the health of the server. 
        /// If you store these event args, be sure to purge old event args to prevent a memory leak.
        /// </summary>
        public event ClientUtils.EventHandler<ApiResponseEventArgs>? ApiResponded;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<PaymentShippingApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentShippingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentShippingApi(ILogger<PaymentShippingApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, 
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
        }

        /// <summary>
        /// Initiate a payment for an order This generic endpoint is should be called to initiate a payment flow after an order has been created. The details of the payment flow can differ depending on the payment integration and might require calling additional operations or the setup of webhooks.  The endpoint internally calls the payment handler of the payment method currently set for the order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="handlePaymentMethodRequest"></param>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> HandlePaymentMethodAsync(HandlePaymentMethodRequest handlePaymentMethodRequest, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?> result = await HandlePaymentMethodWithHttpInfoAsync(handlePaymentMethodRequest, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Initiate a payment for an order This generic endpoint is should be called to initiate a payment flow after an order has been created. The details of the payment flow can differ depending on the payment integration and might require calling additional operations or the setup of webhooks.  The endpoint internally calls the payment handler of the payment method currently set for the order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="handlePaymentMethodRequest"></param>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object?> HandlePaymentMethodOrDefaultAsync(HandlePaymentMethodRequest handlePaymentMethodRequest, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object?>? result = null;
            try 
            {
                result = await HandlePaymentMethodWithHttpInfoAsync(handlePaymentMethodRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Initiate a payment for an order This generic endpoint is should be called to initiate a payment flow after an order has been created. The details of the payment flow can differ depending on the payment integration and might require calling additional operations or the setup of webhooks.  The endpoint internally calls the payment handler of the payment method currently set for the order.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="handlePaymentMethodRequest"></param>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="object"/></returns>
        public async Task<ApiResponse<object?>> HandlePaymentMethodWithHttpInfoAsync(HandlePaymentMethodRequest handlePaymentMethodRequest, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

                if (handlePaymentMethodRequest == null)
                    throw new ArgumentNullException(nameof(handlePaymentMethodRequest));

                #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    UriBuilder uriBuilder = new UriBuilder();
                    uriBuilder.Host = HttpClient.BaseAddress!.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/handle-payment";

                    

                    

                    request.Content = (handlePaymentMethodRequest as object) is System.IO.Stream stream
                        ? request.Content = new StreamContent(stream)
                        : request.Content = new StringContent(JsonSerializer.Serialize(handlePaymentMethodRequest, _jsonSerializerOptions));

                    List<TokenBase> tokens = new List<TokenBase>();

                    ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokens.Add(apiKey);

                    apiKey.UseInHeader(request, "sw-access-key");

                    request.RequestUri = uriBuilder.Uri;

                    string[] contentTypes = new string[] {
                        "application/json" 
                    };

                    string? contentType = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentType != null)
                        request.Content.Headers.Add("ContentType", contentType);
                        
                    request.Method = HttpMethod.Post;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        DateTime requestedAt = DateTime.UtcNow;

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        if (ApiResponded != null)
                        {
                            try
                            {
                                ApiResponded.Invoke(this, new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/handle-payment"));
                            }
                            catch(Exception e)
                            {
                                Logger.LogError(e, "An error occured while invoking ApiResponded.");
                            }
                        }

                        ApiResponse<object?> apiResponse = new ApiResponse<object?>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                            apiResponse.Content = JsonSerializer.Deserialize<object>(apiResponse.RawContent, _jsonSerializerOptions);
                        else if (apiResponse.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase token in tokens)
                                token.BeginRateLimit();

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }

        /// <summary>
        /// Fetch shipping methods Perform a filtered search for shipping methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="onlyAvailable">List only available shipping methods. This filters shipping methods methods which can not be used in the actual context because of their availability rule. (optional)</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ReadShippingMethod200Response"/>&gt;</returns>
        public async Task<ReadShippingMethod200Response?> ReadShippingMethodAsync(bool? onlyAvailable = null, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ReadShippingMethod200Response?> result = await ReadShippingMethodWithHttpInfoAsync(onlyAvailable, readCustomerRequest, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// Fetch shipping methods Perform a filtered search for shipping methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="onlyAvailable">List only available shipping methods. This filters shipping methods methods which can not be used in the actual context because of their availability rule. (optional)</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ReadShippingMethod200Response"/>&gt;</returns>
        public async Task<ReadShippingMethod200Response?> ReadShippingMethodOrDefaultAsync(bool? onlyAvailable = null, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ReadShippingMethod200Response?>? result = null;
            try 
            {
                result = await ReadShippingMethodWithHttpInfoAsync(onlyAvailable, readCustomerRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Fetch shipping methods Perform a filtered search for shipping methods.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType">Content type of the request</param>
        /// <param name="accept">Accepted response content types</param>
        /// <param name="onlyAvailable">List only available shipping methods. This filters shipping methods methods which can not be used in the actual context because of their availability rule. (optional)</param>
        /// <param name="readCustomerRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="ReadShippingMethod200Response"/></returns>
        public async Task<ApiResponse<ReadShippingMethod200Response?>> ReadShippingMethodWithHttpInfoAsync(bool? onlyAvailable = null, ReadCustomerRequest? readCustomerRequest = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    UriBuilder uriBuilder = new UriBuilder();
                    uriBuilder.Host = HttpClient.BaseAddress!.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/shipping-method";

                    System.Collections.Specialized.NameValueCollection parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
                    if (onlyAvailable != null)
                        parseQueryString["onlyAvailable"] = Uri.EscapeDataString(onlyAvailable.ToString()!);

                    uriBuilder.Query = parseQueryString.ToString();
                    request.Content = (readCustomerRequest as object) is System.IO.Stream stream
                        ? request.Content = new StreamContent(stream)
                        : request.Content = new StringContent(JsonSerializer.Serialize(readCustomerRequest, _jsonSerializerOptions));

                    List<TokenBase> tokens = new List<TokenBase>();

                    ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokens.Add(apiKey);

                    apiKey.UseInHeader(request, "sw-access-key");

                    request.RequestUri = uriBuilder.Uri;

                    string[] contentTypes = new string[] {
                        "application/json" 
                    };

                    string? contentType = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentType != null)
                        request.Content.Headers.Add("ContentType", contentType);

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string? accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));
                    
                    request.Method = HttpMethod.Post;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        DateTime requestedAt = DateTime.UtcNow;

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        if (ApiResponded != null)
                        {
                            try
                            {
                                ApiResponded.Invoke(this, new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/shipping-method"));
                            }
                            catch(Exception e)
                            {
                                Logger.LogError(e, "An error occured while invoking ApiResponded.");
                            }
                        }

                        ApiResponse<ReadShippingMethod200Response?> apiResponse = new ApiResponse<ReadShippingMethod200Response?>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                            apiResponse.Content = JsonSerializer.Deserialize<ReadShippingMethod200Response>(apiResponse.RawContent, _jsonSerializerOptions);
                        else if (apiResponse.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase token in tokens)
                                token.BeginRateLimit();

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }    }
}