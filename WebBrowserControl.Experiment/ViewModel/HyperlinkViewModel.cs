//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.HyperlinkViewModel.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Runtime.CompilerServices;
using WebBrowserControl.Experiment.Annotations;

namespace WebBrowserControl.Experiment.ViewModel
{
    public class HyperlinkViewModel : IHyperlinkViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string hyperlink;

        public string Hyperlink
        {
            get => hyperlink;
            set
            {
                hyperlink = value;
                RaisePropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}