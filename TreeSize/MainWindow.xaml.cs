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

        private void DisablingInfoBox()
        {
            InfoBox1.Visibility = Visibility.Hidden;
            InfoBoxTitle.Visibility = Visibility.Hidden;
            AtomicNumberTitle.Visibility = Visibility.Hidden;
            AtomicNumberValue.Visibility = Visibility.Hidden;
            AtomicWeightTitle.Visibility = Visibility.Hidden;
            AtomicWeightValue.Visibility = Visibility.Hidden;
        }

        private void EnablingInfoBox()
        {
            InfoBox1.Visibility = Visibility.Visible;
            InfoBoxTitle.Visibility = Visibility.Visible;
            AtomicNumberTitle.Visibility = Visibility.Visible;
            AtomicNumberValue.Visibility = Visibility.Visible;
            AtomicWeightTitle.Visibility = Visibility.Visible;
            AtomicWeightValue.Visibility = Visibility.Visible;
        }

        private void HydrogenButton_Click(object sender, RoutedEventArgs e)
        {
            EnablingInfoBox();
        }

        private void AtomicWeightTitle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
