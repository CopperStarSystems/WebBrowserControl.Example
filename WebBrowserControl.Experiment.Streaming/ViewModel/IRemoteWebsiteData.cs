//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.IRemoteWebsiteData.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.IO;

namespace WebBrowserControl.Experiment.Streaming.ViewModel
{
    public interface IRemoteWebsiteData
    {
        Stream RemoteDataStream { get; }
    }
}