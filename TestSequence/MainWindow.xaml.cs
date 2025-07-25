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
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Title = "Select Config File";
            if (dlg.ShowDialog() == true)
            {
                myTextBox2.Text = dlg.FileName;
            }
        }

        private void myButton1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Title = "Select Config File";
            if (dlg.ShowDialog() == true)
            {
                myTextBox2.Text = dlg.FileName;
            }
        }

        

        private void myButton2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void myButton3_Click(object sender, RoutedEventArgs e)
        {
            // Example: Open file dialog for Config file
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Title = "Select Config File";
            if (dlg.ShowDialog() == true)
            {
                myTextBox2.Text = dlg.FileName;
            }
        }

    }
}