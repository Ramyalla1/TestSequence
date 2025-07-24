using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestSequence
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked! You entered: " + myTextBox.Text);
        }

        private void myButton1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked! You entered: " + myTextBox.Text);
        }

       
    }
}