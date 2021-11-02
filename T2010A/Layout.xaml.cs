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
using T2010A.Models;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Pages.Home));
            var item1 = new MenuItem() { Name = "Email", MenuPage = "email", Icon = "\uE715" };
            var item2 = new MenuItem() { Name = "Infomation", MenuPage = "infomation", Icon = "\uE77B" };
            var item3 = new MenuItem() { Name = "Customer", MenuPage = "customer", Icon = "\uE748" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);


        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;// item mà được chọn để nhấn vào
            switch (selected.MenuPage)
            {
                case "email": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "infomation": MainFrame.Navigate(typeof(Pages.DemoForm)); break;
                case "customer": MainFrame.Navigate(typeof(Pages.Customer)); break;

            }
        }

        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }
    }
}
