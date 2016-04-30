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
using CurriculumVitae.ViewModels;
using Domain.Models;

namespace CurriculumVitae
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM _vm;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _vm = new MainWindowVM();
            _vm.LoadData();
            DataContext = _vm;
        }

        private void ThrowButtonNotImplementedMessage()
        {
            MessageBoxResult result = MessageBox.Show("Nupp pole veel implementeeritud", "", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            ThrowButtonNotImplementedMessage();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ThrowButtonNotImplementedMessage();
        }

        private void BtnAbout_Click(object sender, RoutedEventArgs e)
        {
            ThrowButtonNotImplementedMessage();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Exit application?", "Confirmation", MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
