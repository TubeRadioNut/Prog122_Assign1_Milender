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

        /// <summary>
        /// Create method for the add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //get user input, parse it in try, catch exception to display it and inform user how to correct input,
            //perform addition and display in messagebox
            try
            {
                //Creates variables for user input and parse to double
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double sum = num1 + num2;
                MessageBox.Show($"{num1.ToString()} + {num2.ToString()} = {sum.ToString()}");
            }
            //Creates catch method to inform user to input number, number and decimal, or just decimal
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and/or decimal only!");
            }
            
        }

        /// <summary>
        /// Create a method for the subtract button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {

            //get user input, parse it in try, catch exception to display it and inform user how to correct input,
            //perform subtraction and display in messagebox
            try
            {
                //Creates variables for user input and parse to double
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double sum = num1 - num2;
                MessageBox.Show($"{num1.ToString()} - {num2.ToString()} = {sum.ToString()}");
            }
            //Creates catch method to inform user to input number, number and decimal, or just decimal
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and/or decimal only!");
            }
        }

        /// <summary>
        /// Create a method for the multiply button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //get user input, parse it in try, catch exception to display it and inform user how to correct input,
            //perform multiplication and display in messagebox
            try
            {
                //Creates variables for user input and parse to double
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double sum = num1 * num2;
                MessageBox.Show($"{num1.ToString()} * {num2.ToString()} = {sum.ToString()}");
            }
            //Creates catch method to inform user to input number, number and decimal, or just decimal
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and/or decimal only!");
            }
        }
        
        /// <summary>
        /// Create a method for the divide button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            //get user input, parse it in try, catch exception to display it and inform user how to correct input,
            //perform division and display in messagebox, use if else for division by zero to inform user not to do that
            try
            {
                //Creates variables for user input and parse to double
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                //creates the if else method to deal with divide by zero
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
            //Creates catch method to inform user to input number, number and decimal, or just decimal
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message + " Please enter a number or a number and/or decimal only!");
            }
        }
    }//end of the class
}//end of namespace