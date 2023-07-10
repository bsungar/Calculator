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

namespace calc5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int choice = 0;
        double number1, number2, final;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            number1 = double.Parse(resultText.Text);
            choice = 4;
            resultText.Text = "0";
        }

        private void substractionButton_Click(object sender, RoutedEventArgs e)
        {
            number1 = double.Parse(resultText.Text);
            choice = 2;
            resultText.Text = "0";

        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            number1 = double.Parse(resultText.Text);
            choice = 1;
            resultText.Text = "0";
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultText.Text == "0")
                resultText.Text = "";
            
            resultText.Text = resultText.Text + ((Button)sender).Content; 
        }

        private void multiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            number1 = double.Parse(resultText.Text);
            choice = 3;
            resultText.Text = "0";

        }

        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultText.Text.IndexOf(",") < 1)
            {
                resultText.Text += ",";
            }

        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            number2 = double.Parse(resultText.Text);
            switch (choice)
            {
                case 1:
                    final = number1 + number2;
                break;
                case 2:
                    final = number1 - number2;
                break;
                case 3:
                    final = number1 * number2;
                break;
                case 4:
                    final = number1 / number2;
                 break;
            }
            resultText.Text = final.ToString();
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            resultText.Text = "0";
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
           
                 resultText.Text = resultText.Text.Substring(0, resultText.Text.Length - 1);
                  if (!resultText.Text.Equals("0"))
            { resultText.Text = "0"; }
                   if (resultText.Text == "0")
                {
                    resultText.Text = "0";
                }
            }
        
                
        

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if(resultText.Text!= "0") { 
                if(resultText.Text.StartsWith("-")){
                    resultText.Text.Replace("-", " ");

                                  }
                else if (resultText.Text.StartsWith("")) {
                   resultText.Text =  "-" + resultText.Text;
                }
                

                }
            }

        }
    }

