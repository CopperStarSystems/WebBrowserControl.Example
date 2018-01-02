//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.App.xaml.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.Windows;
using WebBrowserControl.Experiment.Streaming.ViewModel;

namespace WebBrowserControl.Experiment.Streaming
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainView = new MainWindow();
            var viewModel = new MainViewModel();
            mainView.DataContext = viewModel;
            mainView.Show();
        }
    }
}