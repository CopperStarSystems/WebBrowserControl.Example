//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.Streaming.NavigateToStreamBehavior.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;
using WebBrowserControl.Experiment.Streaming.ViewModel;

namespace WebBrowserControl.Experiment.Streaming.Behavior
{
    public class NavigateToStreamBehavior
    {
        public static readonly DependencyProperty TargetProperty =
            DependencyProperty.RegisterAttached("Target",
                                                typeof(WebBrowser),
                                                typeof(NavigateToStreamBehavior),
                                                new PropertyMetadata(default(WebBrowser), OnTargetChanged));

        static void OnTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var x = e.NewValue;
        }

        public static readonly DependencyProperty RemoteWebsiteDataProperty =
            DependencyProperty.RegisterAttached("RemoteWebsiteData",
                                                typeof(IRemoteWebsiteViewModel),
                                                typeof(NavigateToStreamBehavior),
                                                new PropertyMetadata(default(RemoteWebsiteData),
                                                                     OnRemoteWebsiteDataChanged));

        public static IRemoteWebsiteViewModel GetRemoteWebsiteData(DependencyObject obj)
        {
            return (IRemoteWebsiteViewModel) obj.GetValue(RemoteWebsiteDataProperty);
        }

        public static WebBrowser GetTarget(DependencyObject obj)
        {
            return (WebBrowser) obj.GetValue(TargetProperty);
        }

        public static void SetRemoteWebsiteData(DependencyObject obj, IRemoteWebsiteViewModel value)
        {
            obj.SetValue(RemoteWebsiteDataProperty, value);
        }

        public static void SetTarget(DependencyObject obj, WebBrowser value)
        {
            obj.SetValue(TargetProperty, value);
        }

        static void OnRemoteWebsiteDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var webBrowser = GetTarget(d);
            var viewModel = e.NewValue as IRemoteWebsiteViewModel;
            webBrowser.NavigateToStream(viewModel.RemoteWebsiteData);
        }
    }
}