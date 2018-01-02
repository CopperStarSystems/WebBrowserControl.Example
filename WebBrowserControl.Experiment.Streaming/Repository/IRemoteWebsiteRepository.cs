//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.IRemoteWebsiteRepository.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.IO;
using System.Threading.Tasks;

namespace WebBrowserControl.Experiment.Streaming.Repository
{
    public interface IRemoteWebsiteRepository
    {
        Task<Stream> GetRemotePageAsync(string url);
    }
}