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

namespace pr6savichev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Classes.TV TV= new Classes.TV();
        public MainWindow()
        {
            InitializeComponent();
            VideoPlayer.Source = new Uri(TV.Channels[TV.ActiveChannel].Src);
            VideoPlayer.Play();
        }

        private void BackChannel(object sender, RoutedEventArgs e)
        {
            TV.BackChannel(VideoPlayer, NameChannel);
        }

        private void NextChannel(object sender, RoutedEventArgs e)
        {
            TV.NextChannel(VideoPlayer, NameChannel);
        }

        private void DownVolume(object sender, RoutedEventArgs e)
        {
            if (VideoPlayer.Volume > 0)
            {
                VideoPlayer.Volume -= 0.1;
            }
        }

        private void UpVolume(object sender, RoutedEventArgs e)
        {
            if (VideoPlayer.Volume < 1)
            {
                VideoPlayer.Volume += 0.1;
            }
        }
    }
}
