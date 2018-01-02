//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.IViewFactory.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

namespace WebBrowserControl.Experiment.ViewModel.Infrastructure
{
    public interface IViewFactory
    {
        T Create<T>() where T : class, IView, new();
    }
}