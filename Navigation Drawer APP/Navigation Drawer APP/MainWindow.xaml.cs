using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Navigation_Drawer_APP
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void expand_btn_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void expand_btn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            //设置工具栏的可见性
            if(tg_btn.IsChecked==true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_contact.Visibility = Visibility.Collapsed;
                tt_message.Visibility = Visibility.Collapsed;
                tt_map.Visibility = Visibility.Collapsed;
                tt_setting.Visibility = Visibility.Collapsed;
                tt_signout.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_contact.Visibility = Visibility.Visible;
                tt_message.Visibility = Visibility.Visible;
                tt_map.Visibility = Visibility.Visible;
                tt_setting.Visibility = Visibility.Visible;
                tt_signout.Visibility = Visibility.Visible;
            }
        }

        private void tg_btn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }
       

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tg_btn.IsChecked = false;
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void tg_btn_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }
    }
}
