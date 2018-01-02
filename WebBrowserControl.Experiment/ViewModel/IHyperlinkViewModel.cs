//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.IHyperlinkViewModel.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.ComponentModel;

namespace WebBrowserControl.Experiment.ViewModel
{
    public interface IHyperlinkViewModel : INotifyPropertyChanged
    {
        string Hyperlink { get; set; }
    }
}