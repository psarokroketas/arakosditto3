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

    public partial class PCwindow : Window
    {
        private MainWindow mainWindow = null;
        public PCwindow(Window callingwindow)
        {
            mainWindow = callingwindow as MainWindow;
            InitializeComponent();
            if (mainWindow.lights == 1) { button.Content = ("Turn Lights Off"); }
            else if (mainWindow.lights == 0) { button.Content = ("Turn Lights On"); }
            if (mainWindow.radio == 0) { button3.Content = ("Turn Radio On"); }
            else if (mainWindow.radio == 1) { button3.Content = ("Turn Radio Off"); }
            if (mainWindow.tv == 0) { button4.Content = ("Turn TV On"); }
            else if (mainWindow.tv == 1) { button4.Content = ("Turn TV Off"); }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {   
            if (mainWindow.lights == 1)
            {
                mainWindow.Background = new ImageBrush(new BitmapImage(new Uri(".../images/closedtv.jpg", UriKind.Relative)));
                button.Content = ("Turn Lights On"); 
                mainWindow.lights = 0;
            }
            else if (mainWindow.lights == 0) {
                mainWindow.Background = new ImageBrush(new BitmapImage(new Uri(".../images/opentv.jpg", UriKind.Relative)));
                button.Content = ("Turn Lights Off");
                mainWindow.lights = 1;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.Source = new Uri("../sounds/PCsound2.mp3", UriKind.Relative);
            mediaElement.Play();

            mediaElement.MediaEnded += media_MediaEnded;
        }
           

        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plw = new PlantWindow();
            plw.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindow.radio == 0) {
                mainWindow.mediaElement1.LoadedBehavior = MediaState.Manual;
                mainWindow.mediaElement1.Source = new Uri("../sounds/radio.mp3", UriKind.Relative);
                mainWindow.mediaElement1.Volume = 1;
                mainWindow.mediaElement1.Play();
                button3.Content = ("Turn Radio Off");
                mainWindow.radio = 1;
            }
            else if (mainWindow.radio == 1) {
                mainWindow.mediaElement1.LoadedBehavior = MediaState.Manual;
                mainWindow.mediaElement1.Stop();
                button3.Content = ("Turn Radio On");
                mainWindow.radio = 0;
            }
       }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindow.tv == 0)
            {
                mainWindow.mediaElement2.LoadedBehavior = MediaState.Manual;
                mainWindow.mediaElement2.Source = new Uri("../videos/tv.mp4", UriKind.Relative);
                mainWindow.mediaElement2.Play();
                button4.Content = ("Turn TV Off");
                mainWindow.tv = 1;
            }
            else if (mainWindow.tv == 1)
            {
                mainWindow.mediaElement2.LoadedBehavior = MediaState.Manual;
                mainWindow.mediaElement2.Stop();
                mainWindow.mediaElement2.Source = null;
                button4.Content = ("Turn TV On");
                mainWindow.tv = 0;
            }

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            temperature temp = new temperature();
            temp.Show();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            about ab = new about();
            ab.Show();
        }
    }
     }
