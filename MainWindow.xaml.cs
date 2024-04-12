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

        //Create a method for the add button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //get user input, parse it in try, catch exception to display it and inform user how to correct input,
            //perform addition and display in messagebox
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double sum = num1 + num2;
                MessageBox.Show($"{num1.ToString()} + {num2.ToString()} = {sum.ToString()}");
            }
            catch(FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and/or decimal only!");
            }
            
        }

        //Create a method for the subtract button
        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {

            //get user input, parse it in try, catch exception to display it and inform user how to correct input,
            //perform subtraction and display in messagebox
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double sum = num1 - num2;
                MessageBox.Show($"{num1.ToString()} - {num2.ToString()} = {sum.ToString()}");
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and/or decimal only!");
            }
        }

        //Create a method for the multiply button
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //get user input, parse it in try, catch exception to display it and inform user how to correct input,
            //perform multiplication and display in messagebox
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double sum = num1 * num2;
                MessageBox.Show($"{num1.ToString()} * {num2.ToString()} = {sum.ToString()}");
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and/or decimal only!");
            }
        }

        //Create a method for the divide button
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            //get user input, parse it in try, catch exception to display it and inform user how to correct input,
            //perform division and display in messagebox, use if else for division by zero to inform user not to do that
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                if (num2 != 0)
                {
                    double sum = num1 / num2;
                    MessageBox.Show($"{num1.ToString()} / {num2.ToString()} = {sum.ToString()}");
                }
                else
                {
                    MessageBox.Show("Can not divide by zero, try again!");
                }
                
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and/or decimal only!");
            }
        }
    }//end of the class
}//end of namespace