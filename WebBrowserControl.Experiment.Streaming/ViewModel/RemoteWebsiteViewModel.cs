//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.RemoteWebsiteViewModel.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.IO;

namespace WebBrowserControl.Experiment.Streaming.ViewModel
{
    public class RemoteWebsiteViewModel : ViewModelBase, IRemoteWebsiteViewModel
    {
        readonly IRemoteWebsiteData remoteWebsiteData;

        public RemoteWebsiteViewModel(IRemoteWebsiteData remoteWebsiteData)
        {
            this.remoteWebsiteData = remoteWebsiteData;
            remoteWebsiteData.RemoteDataStream.Seek(0, SeekOrigin.Begin);
        }

        public Stream RemoteWebsiteData => remoteWebsiteData.RemoteDataStream;
    }
}