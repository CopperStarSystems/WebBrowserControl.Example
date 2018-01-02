//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.ShowHyperlinkCommand.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System;
using System.Windows.Input;
using WebBrowserControl.Experiment.ViewModel.Infrastructure;

namespace WebBrowserControl.Experiment.ViewModel.Command
{
    public class ShowHyperlinkCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        readonly IView view;

        public ShowHyperlinkCommand(IView view)
        {
            this.view = view;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            view.Show();
        }
    }
}