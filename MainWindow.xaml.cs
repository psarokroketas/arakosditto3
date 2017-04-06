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

namespace Ergasia_allilepidrasi
{
    

    public partial class MainWindow : Window
    {

        public int gtemp = 0;
        public int radio = 0;
        public int tv = 0;
        public int lights = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.Source = new Uri(@"../sounds/PCsound.mp3", UriKind.Relative);
            mediaElement.Play();
            PCwindow pcw = new PCwindow(this);
            pcw.Show();
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            emergency emerg = new emergency(this);
            emerg.Show();
        }
    }
}
