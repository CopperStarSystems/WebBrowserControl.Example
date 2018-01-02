//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.ViewModelBase.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Runtime.CompilerServices;
using WebBrowserControl.Experiment.Streaming.Annotations;

namespace WebBrowserControl.Experiment.Streaming.ViewModel
{
    public abstract class ViewModelBase : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}