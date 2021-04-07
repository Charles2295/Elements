using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeSize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() // Basically the Start() method.
        {
            InitializeComponent();

            // Hiding the Information Box on Start
            DisablingInfoBox();
        }

        private void DisablingInfoBox() // This is the default state
        {
            InfoBox.Visibility = Visibility.Hidden;
            InfoBoxTitle.Visibility = Visibility.Hidden;
            AtomicNumberTitle.Visibility = Visibility.Hidden;
            AtomicNumberValue.Visibility = Visibility.Hidden;
            AtomicWeightTitle.Visibility = Visibility.Hidden;
            AtomicWeightValue.Visibility = Visibility.Hidden;
            AtomicElectroTitle.Visibility = Visibility.Hidden;
            AtomicElectroValue.Visibility = Visibility.Hidden;
        }

        private void EnablingInfoBox()
        {
            InfoBox.Visibility = Visibility.Visible;
            InfoBoxTitle.Visibility = Visibility.Visible;
            AtomicNumberTitle.Visibility = Visibility.Visible;
            AtomicNumberValue.Visibility = Visibility.Visible;
            AtomicWeightTitle.Visibility = Visibility.Visible;
            AtomicWeightValue.Visibility = Visibility.Visible;
            AtomicElectroTitle.Visibility = Visibility.Visible;
            AtomicElectroValue.Visibility = Visibility.Visible;
        }

        private void HydrogenButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Hydrogen";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF80CBC4"));
            AtomicNumberValue.Text = "1234";
            AtomicWeightValue.Text = "1234";
            AtomicElectroValue.Text = "1234";
        }

        private void LithiumButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Lithium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFAB91"));
            AtomicNumberValue.Text = "123";
            AtomicWeightValue.Text = "123";
            AtomicElectroValue.Text = "123";
        }
    }
}
