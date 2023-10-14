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

namespace Wpf_C__LESSON_1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if(((MouseEventArgs)e).LeftButton == MouseButtonState.Pressed) { bt1.Background = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256))); }
            else if(((MouseEventArgs)e).RightButton == MouseButtonState.Pressed) { GridButtons.Children.Remove(bt1); }

        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (((MouseEventArgs)e).LeftButton == MouseButtonState.Pressed) { bt2.Background = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256))); }
            else if (((MouseEventArgs)e).RightButton == MouseButtonState.Pressed) { GridButtons.Children.Remove(bt2); }
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (((MouseEventArgs)e).LeftButton == MouseButtonState.Pressed) { bt3.Background = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256))); }
            else if (((MouseEventArgs)e).RightButton == MouseButtonState.Pressed) { GridButtons.Children.Remove(bt3); }
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (((MouseEventArgs)e).LeftButton == MouseButtonState.Pressed) { bt4.Background = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256))); }
            else if (((MouseEventArgs)e).RightButton == MouseButtonState.Pressed) { GridButtons.Children.Remove(bt4); }
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (((MouseEventArgs)e).LeftButton == MouseButtonState.Pressed) { bt5.Background = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256))); }
            else if (((MouseEventArgs)e).RightButton == MouseButtonState.Pressed) { GridButtons.Children.Remove(bt5); }
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (((MouseEventArgs)e).LeftButton == MouseButtonState.Pressed) { bt6.Background = new SolidColorBrush(Color.FromRgb((byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256), (byte)Random.Shared.Next(256))); }
            else if (((MouseEventArgs)e).RightButton == MouseButtonState.Pressed) { GridButtons.Children.Remove(bt6); }
        }
    }
}









