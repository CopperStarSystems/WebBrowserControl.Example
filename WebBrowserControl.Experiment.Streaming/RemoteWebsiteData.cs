//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.RemoteWebsiteData.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.IO;
using WebBrowserControl.Experiment.Streaming.ViewModel;

namespace WebBrowserControl.Experiment.Streaming
{
    public class RemoteWebsiteData : IRemoteWebsiteData
    {
        public Stream RemoteDataStream { get; }
    }
}