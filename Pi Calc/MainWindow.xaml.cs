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


namespace Pi_Calc
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

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            

        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(radioButton.IsChecked == true)
            {
                decimal pi = 3.1415926535M;
                int dia = Int32.Parse(textBox.Text);
                decimal cir = dia * pi;
                
                if (radioButton2.IsChecked == true)
                {
                    decimal quater = cir / 4 + dia;
                    string strquater = quater.ToString();
                    MessageBox.Show(strquater + textBox1.Text);
                }
                
                else if (radioButton3.IsChecked == true)
                {
                    decimal semi = cir / 2 + dia;
                    string semifinal = semi.ToString();
                    MessageBox.Show(semifinal + textBox1.Text);
                }
                else
                {
                    string cirfinal = cir.ToString();
                    MessageBox.Show(cirfinal + textBox1.Text);
                }
            }
            if (radioButton1.IsChecked == true) 
            {
                int x = 0;

                if (Int32.TryParse(textBox.Text, out x)) 
                {
                    int rad = x / 2;
                    decimal pi = 3.1415926535M;

                    decimal Area = rad * rad * pi;
                    Console.WriteLine(Area);
                    
                    if (radioButton2.IsChecked == true)
                    {
                        decimal area4 = Area / 4;
                        string area4f = area4.ToString();
                        MessageBox.Show(area4f + textBox1.Text + "²");
                    }
                    else if (radioButton3.IsChecked == true)
                    {
                        decimal semiarea = Area / 2;
                        string Asemistr = semiarea.ToString();
                        MessageBox.Show(Asemistr + textBox1.Text + "²");
                    }
                    else
                    {
                        string Finala = Area.ToString();
                        MessageBox.Show(Finala + textBox1.Text + "²");
                    }
                
                
                    
                    
                }
                else
                {
                    MessageBox.Show("Please Enter a Number");
                }
            
                
                
            

        
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (textBox2.Text == ("Radius "))
            {

            }
            else
            {
                int con = Int32.Parse(textBox2.Text);
                int con1 = con * 2;
                string text1 = con1.ToString();
                
                textBox.Text = text1;
            }

           
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void radioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
