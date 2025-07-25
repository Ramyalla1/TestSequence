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

        private void BrowseTeax_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "T-eax Files (*.teax)|*.teax|All Files (*.*)|*.*";
            dlg.Title = "Select T-eax File";

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                SelectTeax.Text = dlg.FileName;
            }

        }
        private void BrowseST_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();


            dlg.Filter = "ST Files (*.st)|*.st|All Files (*.*)|*.*";
            dlg.Title = "Select ST File";


            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                SelectST.Text = dlg.FileName;
            }

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}