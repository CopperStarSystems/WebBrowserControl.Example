//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.IRemoteWebsiteViewModel.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.IO;

namespace WebBrowserControl.Experiment.Streaming.ViewModel
{
    public interface IRemoteWebsiteViewModel : IViewModel
    {
        Stream RemoteWebsiteData { get; }
    }
}