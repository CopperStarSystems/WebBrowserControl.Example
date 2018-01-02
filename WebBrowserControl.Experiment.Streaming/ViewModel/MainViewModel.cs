//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.MainViewModel.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using WebBrowserControl.Experiment.Streaming.Repository;
using WebBrowserControl.Experiment.Streaming.ViewModel.Command;

namespace WebBrowserControl.Experiment.Streaming.ViewModel
{
    public class MainViewModel : ViewModelBase, IRemoteWebsiteData
    {
        Stream remoteDataStream;

        public MainViewModel()
        {
            var repository = new RemoteWebsiteRepository();
            RemoteDataStream = Task.Run(() => repository.GetRemotePageAsync("http://google.com")).Result;
            ShowBrowserWindowCommand=new ShowBrowserWindowCommand(this);
        }

        public Stream RemoteDataStream
        {
            get => remoteDataStream;
            private set
            {
                remoteDataStream = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowBrowserWindowCommand { get; }
    }
}