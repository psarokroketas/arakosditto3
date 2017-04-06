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
using System.Windows.Shapes;

namespace Ergasia_allilepidrasi
{
    
    public partial class temperature : Window
    {
        
        System.Windows.Threading.DispatcherTimer timmer1;
        MainWindow main = new MainWindow();
        int temp;
        int temp0;
        int flag = 0;
        public temperature()  
        {
            InitializeComponent();
            textBox.IsReadOnly = true;
            textBox1.IsReadOnly = true;
            if (((MainWindow)Application.Current.MainWindow).gtemp == 0)
            {
                Random rnd = new Random();
                temp = rnd.Next(15, 35);
                temp0 = temp;
                ((MainWindow)Application.Current.MainWindow).gtemp = temp0;
            }
            else {
                temp = ((MainWindow)Application.Current.MainWindow).gtemp;
                temp0 = ((MainWindow)Application.Current.MainWindow).gtemp;
            }
            textBox.Text = ("Current temperature: ");
            textBox1.Text = temp.ToString();
            toggleButton.Opacity = 0;
            toggleButton.IsEnabled = false;
            toggleButton1.Opacity = 0;
            toggleButton1.IsEnabled = false;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (temp0 < temp)
            {
                temp0++;
                textBox1.Text = temp0.ToString();
                timmer1.Stop();
                timmer1.Start();
            }
            else if (temp0 > temp)
            {
                temp0--;
                textBox1.Text = temp0.ToString();
                timmer1.Stop();
                timmer1.Start();
            }
            else {
                button.Opacity = 100;
                button.IsEnabled = true;
                button.Content = ("Adjust temperature");
                textBox.Text = ("Current temperature: ");
                toggleButton.Opacity = 0;
                toggleButton.IsEnabled = false;
                toggleButton1.Opacity = 0;
                toggleButton1.IsEnabled = false;
                button1.Opacity = 100;
                button1.IsEnabled = true;
                timmer1.Stop();
            }
            
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                toggleButton.Opacity = 100;
                toggleButton.IsEnabled = true;
                toggleButton1.Opacity = 100;
                toggleButton1.IsEnabled = true;
                button.Content = ("Confirm");
                textBox.Text = ("Desired temperature: ");
                button1.Opacity = 0;
                button1.IsEnabled = false;
                flag = 1;
            }
            else if (flag == 1) {
                toggleButton.Opacity = 0;
                toggleButton.IsEnabled = false;
                toggleButton1.Opacity = 0;
                toggleButton1.IsEnabled = false;
                textBox1.Text = temp0.ToString();
                button.Opacity = 0;
                button.IsEnabled = false;
                textBox.Text = ("Current temperature: ");
                ((MainWindow)Application.Current.MainWindow).gtemp = temp;
                timmer1 = new System.Windows.Threading.DispatcherTimer();
                timmer1.Tick += new EventHandler(dispatcherTimer_Tick);
                timmer1.Interval = new TimeSpan(0, 0, 3);
                timmer1.Start();
                flag = 0;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).gtemp = temp0;
            this.Close();
        }

        private void toggleButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (temp <= 49 && temp >= 10)
            {
                temp++;
                textBox1.Text = temp.ToString();
            }
        }

        private void toggleButton1_Click(object sender, RoutedEventArgs e)
        {
            if (temp <= 50 && temp >= 11)
            {
                temp--;
                textBox1.Text = temp.ToString();
            }
        }
    }
}
