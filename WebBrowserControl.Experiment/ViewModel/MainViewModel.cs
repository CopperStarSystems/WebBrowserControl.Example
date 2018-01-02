//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.MainViewModel.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.Windows.Input;

namespace WebBrowserControl.Experiment.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel(ICommand showBrowserCommand)
        {
            ShowBrowserCommand = showBrowserCommand;
        }

        public ICommand ShowBrowserCommand { get; }
    }
}