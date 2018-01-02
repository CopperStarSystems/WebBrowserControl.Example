//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.ShowBrowserWindowCommand.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System;
using System.Windows.Input;

namespace WebBrowserControl.Experiment.Streaming.ViewModel.Command
{
    public class ShowBrowserWindowCommand : ICommand
    {
        readonly IRemoteWebsiteData remoteWebsiteData;

        public ShowBrowserWindowCommand(IRemoteWebsiteData remoteWebsiteData)
        {
            this.remoteWebsiteData = remoteWebsiteData;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var view  = new BrowserWindow();
            var viewModel = new RemoteWebsiteViewModel(remoteWebsiteData);
            view.DataContext = viewModel;
            view.Show();
        }
    }
}