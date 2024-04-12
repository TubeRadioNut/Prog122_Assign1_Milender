//Charles Milender
//4-10-2024
//Programming 122
//Assignment 1 - Basic Calculator
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

namespace Prog122_Assign1_Milender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//<--Don't delete this
        }//end of the MainWindow

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //get user input, parse it, perform addtion and display in messagebox
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double sum = num1 + num2;
                MessageBox.Show($"{num1.ToString()} + {num2.ToString()} = {sum.ToString()}");
            }
            catch(FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and decimal only!");
            }
            
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            
            //get user input, parse it, perform subtraction and display in messagebox
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double sum = num1 - num2;
                MessageBox.Show($"{num1.ToString()} - {num2.ToString()} = {sum.ToString()}");
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and decimal only!");
            }
        }
    }//end of the class
}//end of namespace