//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.RemoteWebsiteRepository.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebBrowserControl.Experiment.Streaming.Repository
{
    public class RemoteWebsiteRepository : IRemoteWebsiteRepository
    {
        readonly HttpClient httpClient = new HttpClient();

        public async Task<Stream> GetRemotePageAsync(string url)
        {
            var response = httpClient.GetAsync(url);
            return await response.Result.Content.ReadAsStreamAsync();
        }
    }
}