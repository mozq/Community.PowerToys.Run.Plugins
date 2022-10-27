using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using Community.PowerToys.Run.Plugin.DenCode.Models;

namespace Community.PowerToys.Run.Plugin.DenCode
{
    /// <summary>
    /// DenCode API.
    /// </summary>
    public interface IDenCodeClient
    {
        /// <summary>
        /// Encodes/decodes a value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Encoding/decoding results.</returns>
        Task<DenCodeResponse?> DenCodeAsync(string value);

        /// <summary>
        /// Encodes/decodes a value.
        /// </summary>
        /// <param name="method">The encoding/decoding method.</param>
        /// <param name="value">The value.</param>
        /// <returns>Encoding/decoding results.</returns>
        Task<DenCodeResponse?> DenCodeAsync(DenCodeMethod method, string value);
    }

    /// <inheritdoc/>
    public class DenCodeClient : IDenCodeClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DenCodeClient"/> class.
        /// </summary>
        public DenCodeClient()
        {
            HttpClient = new HttpClient
            {
                BaseAddress = new Uri("https://dencode.com"),
                Timeout = TimeSpan.FromSeconds(5),
            };
            HttpClient.DefaultRequestHeaders.Add("X-Application-Id", "Community.PowerToys.Run.Plugin.DenCode");
        }

        internal DenCodeClient(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        private HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public async Task<DenCodeResponse?> DenCodeAsync(string value)
        {
            var request = JsonSerializer.Deserialize<DenCodeRequest>(Constants.AllRequest);
            request!.value = value;
            var response = await HttpClient.PostAsJsonAsync("dencode", request).ConfigureAwait(false);
            return await response.Content.ReadFromJsonAsync<DenCodeResponse>().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<DenCodeResponse?> DenCodeAsync(DenCodeMethod method, string value)
        {
            if (method is null)
            {
                throw new ArgumentNullException(nameof(method));
            }

            var request = JsonSerializer.Deserialize<DenCodeRequest>(Constants.AllRequest);
            request!.type = method.GetRequestType();
            request!.method = method.Key;
            request!.value = value;
            var response = await HttpClient.PostAsJsonAsync("dencode", request).ConfigureAwait(false);
            return await response.Content.ReadFromJsonAsync<DenCodeResponse>().ConfigureAwait(false);
        }
    }
}
