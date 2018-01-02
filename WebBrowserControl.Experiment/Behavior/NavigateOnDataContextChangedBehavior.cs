//  --------------------------------------------------------------------------------------
// WebBrowserControl.Experiment.NavigateOnDataContextChangedBehavior.cs
// 2017/12/29
//  --------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;
using WebBrowserControl.Experiment.ViewModel;

namespace WebBrowserControl.Experiment.Behavior
{
    public class NavigateOnDataContextChangedBehavior
    {
        // Using a DependencyProperty as the backing store for Target.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetProperty =
            DependencyProperty.RegisterAttached("Target",
                                                typeof(WebBrowser),
                                                typeof(NavigateOnDataContextChangedBehavior),
                                                new PropertyMetadata(default(WebBrowser), OnTargetChanged));

        public static WebBrowser GetTarget(DependencyObject obj)
        {
            return (WebBrowser) obj.GetValue(TargetProperty);
        }

        public static void SetTarget(DependencyObject obj, WebBrowser value)
        {
            obj.SetValue(TargetProperty, value);
        }

        static void NavigateToNewLocation(object sender, DependencyPropertyChangedEventArgs e)
        {
            var viewModel = (IHyperlinkViewModel) e.NewValue;
            var browser = (WebBrowser) sender;
            if (viewModel == null)
                return;
            browser.Navigate(viewModel.Hyperlink);
        }

        static void OnTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var target = (WebBrowser) e.NewValue;
            if (target == null)
                return;
            target.DataContextChanged += NavigateToNewLocation;
        }
    }
}