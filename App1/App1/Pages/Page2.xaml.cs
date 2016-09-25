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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace App1.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(HumburgPage1));
            TitleTextBlock.Text = "HumburgPage1";
        }

        private void HamburgButton_Click(object sender, RoutedEventArgs e)
        {
            MySpliteView.IsPaneOpen = !MySpliteView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();

            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Ph1.IsSelected)
            {
                MyFrame.Navigate(typeof(HumburgPage1));
                TitleTextBlock.Text = "HumburgPage1";
            }
            else if(Ph2.IsSelected)
            {
                MyFrame.Navigate(typeof(HuambugPage2));
                TitleTextBlock.Text = "HumburgPage2";
            }
        }
    }
}
