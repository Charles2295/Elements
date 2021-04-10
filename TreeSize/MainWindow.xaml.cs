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
            BoilingPointTitle.Visibility = Visibility.Hidden;
            BoilingPointValue.Visibility = Visibility.Hidden;
            MeltingPointTitle.Visibility = Visibility.Hidden;
            MeltingPointValue.Visibility = Visibility.Hidden;
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
            BoilingPointTitle.Visibility = Visibility.Visible;
            BoilingPointValue.Visibility = Visibility.Visible;
            MeltingPointTitle.Visibility = Visibility.Visible;
            MeltingPointValue.Visibility = Visibility.Visible;
        }

        // Column 1
        private void HydrogenButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Hydrogen";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF80CBC4"));
            AtomicNumberValue.Text = "1";
            AtomicWeightValue.Text = "1.00784 u";
            AtomicElectroValue.Text = "2.2";
            BoilingPointValue.Text = "-252.9 °C";
            MeltingPointValue.Text = "-259.14 °C";
        }

        private void LithiumButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Lithium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFAB91"));
            AtomicNumberValue.Text = "3";
            AtomicWeightValue.Text = "6.941 u";
            AtomicElectroValue.Text = "0.98";
            BoilingPointValue.Text = "1,330 °C";
            MeltingPointValue.Text = "180.5 °C";
        }

        private void SodiumButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Sodium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFAB91"));
            AtomicNumberValue.Text = "11";
            AtomicWeightValue.Text = "22.989769 u";
            AtomicElectroValue.Text = "0.93";
            BoilingPointValue.Text = "882.8 °C";
            MeltingPointValue.Text = "97.79 °C";
        }

        private void PotassiumButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Potassium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFAB91"));
            AtomicNumberValue.Text = "19";
            AtomicWeightValue.Text = "39.0983 u";
            AtomicElectroValue.Text = "0.82";
            BoilingPointValue.Text = "758.8 °C";
            MeltingPointValue.Text = "63.5 °C";
        }

        private void RubidiumButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Rubidium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFAB91"));
            AtomicNumberValue.Text = "37";
            AtomicWeightValue.Text = "85.4678 u";
            AtomicElectroValue.Text = "0.82";
            BoilingPointValue.Text = "688 °C";
            MeltingPointValue.Text = "39.3 °C";
        }

        private void CaesiummButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Caesium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFAB91"));
            AtomicNumberValue.Text = "55";
            AtomicWeightValue.Text = "132.90545 u";
            AtomicElectroValue.Text = "0.79";
            BoilingPointValue.Text = "671 °C";
            MeltingPointValue.Text = "28.5 °C";
        }

        private void FranciumButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Francium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFAB91"));
            AtomicNumberValue.Text = "87";
            AtomicWeightValue.Text = "223 u";
            AtomicElectroValue.Text = "0.7";
            BoilingPointValue.Text = "677 °C";
            MeltingPointValue.Text = "27 °C";
        }

        // Column 2
        private void BerylliumButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Beryllium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFECB7F"));
            AtomicNumberValue.Text = "4";
            AtomicWeightValue.Text = "9.012182 u";
            AtomicElectroValue.Text = "1.57";
            BoilingPointValue.Text = "2,471 °C";
            MeltingPointValue.Text = "1,287 °C";
        }

        private void MagnesiumButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
            InfoBoxTitle.Text = "Magnesium";
            InfoBoxTitle.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFECB7F"));
            AtomicNumberValue.Text = "12";
            AtomicWeightValue.Text = "24.305 u";
            AtomicElectroValue.Text = "1.31";
            BoilingPointValue.Text = "1,090 °C";
            MeltingPointValue.Text = "24.305 °C";
        }
    }
}
