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
using System.Windows.Threading;

namespace Ergasia_allilepidrasi
{
    /// <summary>
    /// Interaction logic for emergency.xaml
    /// </summary>
    public partial class emergency : Window
    {
        private MainWindow mainWindow = null;

        System.Windows.Threading.DispatcherTimer timmer;
        public emergency(Window callingwindow)
        {

            timmer = new System.Windows.Threading.DispatcherTimer();
            timmer.Tick += new EventHandler(dispatcherTimer_Tick);
            timmer.Interval = new TimeSpan(0, 1, 0);
            timmer.Start();

            mainWindow = callingwindow as MainWindow;
            InitializeComponent();
            police.Opacity = 0;
            fire.Opacity = 0;
            hosp.Opacity = 0;
            close.Opacity = 0;
            close.IsEnabled = false;
            police.IsEnabled = false;
            fire.IsEnabled = false;
            hosp.IsEnabled = false;
            textBox.IsReadOnly = true;
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.Source = new Uri("../sounds/alarm.mp3", UriKind.Relative);         
            mediaElement.Play();
            mediaElement.MediaEnded += media_MediaEnded;

        }


        


        private void dispatcherTimer_Tick(object sender, EventArgs e) {

            textBox.Text = ("Your local police department has been informed and it is on it's way.");
            police.IsEnabled = false;
            fire.IsEnabled = false;
            hosp.IsEnabled = false;
            police.Opacity = 0;
            fire.Opacity = 0;
            hosp.Opacity = 0;
            close.Opacity = 100;
            close.IsEnabled = true;
            mediaElement.Stop();
            timmer.Stop();
        }


            private void media_MediaEnded(object sender, RoutedEventArgs e)
            {
                mediaElement.LoadedBehavior = MediaState.Manual;
                mediaElement.Source = new Uri("../sounds/alarm.mp3", UriKind.Relative);
                mediaElement.Play();
                mediaElement.MediaEnded += media_MediaEnded; 
            }

     

        private void buttonyes_Click(object sender, RoutedEventArgs e)
        {  
            textBox.Text = ("Whose help do you need?");
            buttonyes.Opacity = 0;
            buttonno.Opacity = 0;
            buttonyes.IsEnabled = false;
            buttonno.IsEnabled = false;
            police.IsEnabled = true;
            fire.IsEnabled = true;
            hosp.IsEnabled = true;
            police.Opacity = 100;
            fire.Opacity = 100;
            hosp.Opacity = 100;
            timmer.Stop();
        }

        private void police_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = ("Your local police department has been informed and it is on it's way.");
            police.IsEnabled = false;
            fire.IsEnabled = false;
            hosp.IsEnabled = false;
            police.Opacity = 0;
            fire.Opacity = 0;
            hosp.Opacity = 0;
            close.Opacity = 100;
            close.IsEnabled = true;
            mediaElement.Stop();
            timmer.Stop();
        }

        private void fire_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = ("Your local fire department has been informed and it is on it's way.");
            police.IsEnabled = false;
            fire.IsEnabled = false;
            hosp.IsEnabled = false;
            police.Opacity = 0;
            fire.Opacity = 0;
            hosp.Opacity = 0;
            close.Opacity = 100;
            close.IsEnabled = true;
            mediaElement.Stop();
            timmer.Stop();
        }

        private void hosp_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = ("Your hospital has been informed and it is on it's way.");
            police.IsEnabled = false;
            fire.IsEnabled = false;
            hosp.IsEnabled = false;
            police.Opacity = 0;
            fire.Opacity = 0;
            hosp.Opacity = 0;
            close.Opacity = 100;
            close.IsEnabled = true;
            mediaElement.Stop();
            timmer.Stop();
        }

        private void buttonno_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = ("We are happy to know that you are safe :)");
            buttonyes.Opacity = 0;
            buttonno.Opacity = 0;
            buttonyes.IsEnabled = false;
            buttonno.IsEnabled = false;
            close.Opacity = 100;
            close.IsEnabled = true;
            mediaElement.Stop();
            timmer.Stop();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            timmer.Stop();
        }
    }
}





