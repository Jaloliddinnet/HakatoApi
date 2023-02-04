using HakatoApp.Pages;
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

namespace HakatoApp
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

        private void TabItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Patients patients = new Patients(); 
            Menyu.Content = patients;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            Menyu.Content = dashboard;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Doctors doctors = new Doctors();
            Menyu.Content = doctors;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Pharmacy pharmacy = new Pharmacy();
            Menyu.Content = pharmacy;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            About about = new About();
            Menyu.Content = about;
        }

        private void Doctor_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
