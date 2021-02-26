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

namespace Lab_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if ((ch1.IsChecked == true && ch2.IsChecked == true) || (ch2.IsChecked == true && ch3.IsChecked == true) 
                || (ch1.IsChecked == true && ch3.IsChecked == true) || (ch1.IsChecked == true && ch4.IsChecked == true) 
                || (ch3.IsChecked == true && ch4.IsChecked == true) || (ch2.IsChecked == true && ch4.IsChecked == true))
            {
                MessageBox.Show("Error! Input Number!");
            }
            int number = 0;
            bool check = int.TryParse(tb_1.Text, out number);
            if (check == true)
            {
                if (ComboBox.Text == "Из 10 системы")
                {
                    if (ch1.IsChecked == true)
                    {
                        int i = Convert.ToInt32(tb_1.Text);
                        tb_2.Text = Convert.ToString(i, 2);
                    }
                    else if (ch2.IsChecked == true)
                    {
                        int i = Convert.ToInt32(tb_1.Text);
                        tb_2.Text = Convert.ToString(i, 8);
                    }
                    else if (ch3.IsChecked == true)
                    {
                        int i = Convert.ToInt32(tb_1.Text);
                        tb_2.Text = Convert.ToString(i, 16);
                    }
                    else if (ch4.IsChecked == true)
                    {
                        int i = Convert.ToInt32(tb_1.Text);
                        tb_2.Text = Convert.ToString(i, 10);
                    }
                    else { tb_2.Text = tb_1.Text; }
                }
                else if (ComboBox.Text == "Из 2 системы")
                {
                    int i = Convert.ToInt32(tb_1.Text);
                    if (ch1.IsChecked == true)
                    {
                        tb_2.Text = tb_1.Text;
                    }
                    else if (ch2.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 2);
                        tb_2.Text = Convert.ToString(i, 8);
                    }
                    else if (ch3.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 2);
                        tb_2.Text = Convert.ToString(i, 16);
                    }
                    else if (ch4.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 2);
                        tb_2.Text = Convert.ToString(i, 10);
                    }
                }
                else if (ComboBox.Text == "Из 8 системы")
                {
                    int i = Convert.ToInt32(tb_1.Text);
                    if (ch1.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 8);
                        tb_2.Text = Convert.ToString(i, 2);
                    }
                    else if (ch2.IsChecked == true)
                    {
                        tb_2.Text = tb_1.Text;
                    }
                    else if (ch3.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 8);
                        tb_2.Text = Convert.ToString(i, 16);
                    }
                    else if (ch4.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 8);
                        tb_2.Text = Convert.ToString(i, 10);
                    }
                }
                else if (ComboBox.Text == "Из 16 системы")
                {
                    int i = Convert.ToInt32(tb_1.Text);
                    if (ch1.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 16);
                        tb_2.Text = Convert.ToString(i, 2);
                    }
                    else if (ch2.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 16);
                        tb_2.Text = Convert.ToString(i, 8);

                    }
                    else if (ch3.IsChecked == true)
                    {
                        tb_2.Text = tb_1.Text;
                    }
                    else if (ch4.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 16);
                        tb_2.Text = Convert.ToString(i, 10);
                    }
                }
                else if (ComboBox.Text == "Из 10 системы")
                {
                    int i = Convert.ToInt32(tb_1.Text);
                    if (ch1.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 10);
                        tb_2.Text = Convert.ToString(i, 2);
                    }
                    else if (ch2.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 10);
                        tb_2.Text = Convert.ToString(i, 8);

                    }
                    else if (ch3.IsChecked == true)
                    {
                        i = Convert.ToInt32(tb_1.Text, 10);
                        tb_2.Text = Convert.ToString(i, 16);
                    }
                    else if (ch4.IsChecked == true)
                    {
                        tb_2.Text = tb_1.Text;
                    }
                }
                else
                { MessageBox.Show("Error!"); }
            }
            else
            { MessageBox.Show("Error!"); }
        }
    }          
}
