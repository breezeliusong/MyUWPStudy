using App1.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Page1));
        }

        private void InputBox_GotFocus(object sender, RoutedEventArgs e)
        {
        }

        private void InputBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                Windows.UI.ViewManagement.InputPane.GetForCurrentView().TryHide();
            }

        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            AppBarButton appBar = sender as AppBarButton;
            if (appBar != null)
            {
                string lable = appBar.Label;
                switch (lable)
                {
                    case "Back":
                        if (rootFrame == null) return;
                        if (rootFrame.CanGoBack) rootFrame.GoBack();
                        break;
                    case "Forward":
                        if (rootFrame == null) return;
                        if (rootFrame.CanGoForward) rootFrame.GoForward();
                        break;
                }
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2));
        }
    }
}
