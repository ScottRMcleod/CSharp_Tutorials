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

namespace CodeRunnerTemplate
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

        private void Output(string value)
        {
            txtOutput.Text += value + "\n";
        }
        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            //Declarations of vairables:
            string myString = "Hello World";
            int MyNumber = 2;

            //pushes output to the txtOutput text box
            Output(myString);
            //Casting date time objects to a string to present the data in the txtOutput box
            Output("The Date is: "+DateTime.Now.ToString("dd.MM.yyyy"));
            //Casting the Integer value to a string inorder to present this data in the txt.Output text box
            Output("Your Integer is: " + MyNumber.ToString());
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
        }
    }
}
