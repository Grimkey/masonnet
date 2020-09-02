using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mason.API.Fleet
{
    public class Fleet
    {
        private readonly Endpoint _endpoint;

        public Fleet(Endpoint client)
        {
            _endpoint = client;
        }

        /// <summary>
        /// Enumerate all devices. This method will read page by page until all devices are enumerated.
        /// </summary>
        /// <param name="token">token to cancel the enumeration</param>
        /// <returns>A forward-only device enumerator</returns>
        public async IAsyncEnumerable<Device> ListDevices([EnumeratorCancellation] CancellationToken token)
        {
            Pagination<Device> devices = null;

            do
            {
                devices = await GetNextPage(devices?.Next, token);

                foreach (var d in devices.Data)
                {
                    if (token.IsCancellationRequested)
                    {
                        yield break;
                    }

                    yield return d;
                }
            } while (devices.Next != null && !token.IsCancellationRequested);
        }

        private async Task<Pagination<Device>> GetNextPage(string next, CancellationToken token)
        {
            var call = "default/device";
            if (!string.IsNullOrEmpty(next))
            {
                call = $"{call}?after={next}";
            }
            var response = await _endpoint.Client.GetAsync(call, token);
            // TODO: Handle Mason errors
            response.EnsureSuccessStatusCode();
            
            var jsonRaw = await response.Content.ReadAsStringAsync();
           return JsonConvert.DeserializeObject<Pagination<Device>>(jsonRaw);
        }
    }
}