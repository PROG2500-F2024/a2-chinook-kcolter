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

namespace PROG2500_A2_Chinook
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
              

        private void HomeToolButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Home());
        }

        private void ArtistsToolButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Artists());
        }

        private void AlbumsToolButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Albums());
        }

        private void TracksToolButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Tracks());
        }

        private void DockPanel_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Home());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //researched from https://stackoverflow.com/a/2820377
            System.Windows.Application.Current.Shutdown();
        }
    }
}
