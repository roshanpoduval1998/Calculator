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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void drag_window(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void minimize_window(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void double_click_(object sender, MouseEventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }
        public void value_checker(string button_Text)
        {
            string text_data = text_box_.Text;
            if (text_data == "0")
            {
                text_box_.Text = "";
                text_box_.Text = text_box_.Text + button_Text;
            }
            else
            {
                text_box_.Text = text_box_.Text + button_Text;
            }
        }
        private void _1_(object sender, RoutedEventArgs e)
        {
            string button_Text = "1";
            value_checker(button_Text);
        }
        private void _2_(object sender, RoutedEventArgs e)
        {
            string button_Text = "2";
            value_checker(button_Text);
        }
        private void _3_(object sender, RoutedEventArgs e)
        {
            string button_Text = "3";
            value_checker(button_Text);
        }
        private void _4_(object sender, RoutedEventArgs e)
        {
            string button_Text = "4";
            value_checker(button_Text);
        }
        private void _5_(object sender, RoutedEventArgs e)
        {
            string button_Text = "5";
            value_checker(button_Text);
        }
        private void _6_(object sender, RoutedEventArgs e)
        {
            string button_Text = "6";
            value_checker(button_Text);
        }
        private void _7_(object sender, RoutedEventArgs e)
        {
            string button_Text = "7";
            value_checker(button_Text);
        }
        private void _8_(object sender, RoutedEventArgs e)
        {
            string button_Text = "8";
            value_checker(button_Text);
        }
        private void _9_(object sender, RoutedEventArgs e)
        {
            string button_Text = "9";
            value_checker(button_Text);
        }
        private void _0_(object sender, RoutedEventArgs e)
        {
            string button_Text = "0";
            value_checker(button_Text);
        }
        private void _00_(object sender, RoutedEventArgs e)
        {
            string button_Text = "00";
            value_checker(button_Text);
        }
        private void _dot_(object sender, RoutedEventArgs e)
        {
            string button_Text = ".";
            value_checker(button_Text);
        }
        private void _plus_(object sender, RoutedEventArgs e)
        {
            string button_Text = "+";
            value_checker(button_Text);
        }
        private void _minus_(object sender, RoutedEventArgs e)
        {
            string button_Text = "-";
            value_checker(button_Text);
        }
        private void _multiply_(object sender, RoutedEventArgs e)
        {
            string button_Text = "*";
            value_checker(button_Text);
        }
        private void _divide_(object sender, RoutedEventArgs e)
        {
            string button_Text = "/";
            value_checker(button_Text);
        }
        private void _clear_(object sender, RoutedEventArgs e)
        {
            text_box_.Text = "0";
        }
        private void _close_(object sender, RoutedEventArgs e)
        {
            string button_Text = ")";
            value_checker(button_Text);
        }
        private void _open_(object sender, RoutedEventArgs e)
        {
            string button_Text = "(";
            value_checker(button_Text);
        }
        private void _back_(object sender, RoutedEventArgs e)
        {
            string data = text_box_.Text;
            int len = data.Length;
            if (len <= 1)
            {
                text_box_.Text = "0";
            }
            else
            {
                string back_data = data.Substring(0, len - 1);
                text_box_.Text = back_data;
            }
        }
        public static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }
        private void _equal_(object sender, RoutedEventArgs e)
        {
            try
            {
                string Text_data = text_box_.Text;
                string output = Convert.ToString((Eval(Text_data)));
                text_box_.Text = output;
            }
            catch
            {
                text_box_.Text = "null";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}