using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WebBrowserControl.Experiment.ViewModel;
using WebBrowserControl.Experiment.ViewModel.Command;

namespace WebBrowserControl.Experiment
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var hyperlinkViewModel = new HyperlinkViewModel();
            var browserWindow = new BrowserWindow {DataContext = hyperlinkViewModel};

            var command = new ShowHyperlinkCommand(browserWindow);

            var view = new MainWindow();
            var viewModel = new MainViewModel(command);
            view.DataContext = viewModel;
            view.Show();
        }
    }
}
