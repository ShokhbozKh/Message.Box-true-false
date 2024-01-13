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

namespace WpfApp3
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

        private void btnOk(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Hello world", "diqqat", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation, MessageBoxResult.OK);
            var result = MessageBox.Show("diqqat", "tanla", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                tbInput.Text = "YES";
            }
            else if (result == MessageBoxResult.Cancel)
            {
                tbInput.Text = "CANCEL";
            }
            else
            {
                tbInput.Text = "NO";
            }
        }
    }
}